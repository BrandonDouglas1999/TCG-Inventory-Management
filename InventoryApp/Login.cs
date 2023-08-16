using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Encodings.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using InventoryApp.Helpers;

namespace InventoryApp
{
    public partial class Login : Form
    {

        const string clientID = "657611740650-i9i8o0846cs58juodncpo44hgpj8ju6s.apps.googleusercontent.com";
        const string secret = "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";
        const string redirect_uri = $"http://127.0.0.1:15000/";
        SQLHelper db = new SQLHelper();


        public bool authenticated = false;
        public string logged_user = null;
        public string uid = null;
        public Login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(user_input.Text) || string.IsNullOrEmpty(pw_input.Text))
            {
                incorrect_prompt.Text = "Incorrect Username or Password";
                incorrect_prompt.Visible = true;
                return;
            }
            string hashed_username = create_account_uc.hash_values(user_input.Text);
            string hashed_password = create_account_uc.hash_values(pw_input.Text);

            // Hash the inputs and compare against the db stored value
            var login = db.AppLogin(hashed_username, hashed_password);

            // If correct, close form, if not, show error
            if (login.status == 1)
            {
                this.logged_user = user_input.Text;
                this.uid = login.uid;
                this.authenticated = true;
                this.Close();
            }
            else
            {
                incorrect_prompt.Text = "Incorrect Username or Password";
                incorrect_prompt.Visible = true;
            }
        }

        private string getAuthCode()
        {

            string auth = $"https://accounts.google.com/o/oauth2/v2/auth?" +
                $"scope=profile%20email" +
                $"&response_type=code&" +
                $"redirect_uri={redirect_uri}&" +
                $"client_id={clientID}";
            HttpListener response_listen = new HttpListener();

            // Create a URI to redirect the authorization code to on port 15000

            string redirect_URI = $"http://{IPAddress.Loopback}:15000/";

            // Listen for the OAuth token.
            response_listen.Prefixes.Add(redirect_URI);
            response_listen.Start();

            ProcessStartInfo auth_url = new ProcessStartInfo(auth);
            auth_url.UseShellExecute = true;
            Process.Start(auth_url);

            // From the HttpListener, get the context and extract the authorized code
            // Add some kind of error check here too
            HttpListenerContext context = response_listen.GetContext();

            // Change the text to prompt user to close window.
            string prompt_html = "<html><body><font size=\"46\">Return to the app.</font></body></html>";
            var encoded_html = Encoding.UTF8.GetBytes(prompt_html);
            var response = context.Response;
            var loopback_stream = response.OutputStream;
            // make the response body length the same as the HTML code
            response.ContentLength64 = encoded_html.Length;

            loopback_stream.Write(encoded_html, 0, encoded_html.Length);

            response_listen.Stop();

            // Query string is a NameValueCollection (basically a dictionary)
            // As of right now, contains the following keys:
            // code: the authorization code
            // scope: the resources we can access, only requesting email and profile for our app
            // authuser: number of the user being auth'd
            // prompt: The prompt for the user when signing in

            // If there is an error, error is the only key.

            if (context.Request.QueryString.Get("error") != null)
            {
                incorrect_prompt.Text = "Failed to Login via Google";
                incorrect_prompt.Visible = true;
                return null;
            }

            string code = context.Request.QueryString.Get("code");

            return code;
        }

        private async void getToken(string authCode)
        {
            // Create the Token request 

            string endpoint = "https://oauth2.googleapis.com/token";

            var needed_info = new Dictionary<string, string>
            {
                {"code", authCode},
                {"client_id", clientID},
                {"client_secret", secret},
                {"redirect_uri", redirect_uri},
                {"grant_type", "authorization_code"},
            };


            var formatted_info = new FormUrlEncodedContent(needed_info);

            HttpClient client = new HttpClient();

            var response = await client.PostAsync(endpoint, formatted_info);

            string result = await response.Content.ReadAsStringAsync();

            // Isolate the Token from the response.
            // Do not need refresh token or type
            result = result.Replace("\"", "");
            String[] split = result.Split(',');
            String[] split_again = split[0].Split(":");

            string token = split_again[1].Trim();


            // Make a GET call to obtain user profile

            var profile_info = await client.GetStringAsync($"https://www.googleapis.com/oauth2/v1/userinfo?access_token={token}");
            string google_id = profile_info.Replace("\"", "").Split(',')[0].Split(':')[1].Trim();
            string email = profile_info.Replace("\"", "").Split(',')[1].Split(':')[1].Trim();
            string user_name = profile_info.Replace("\"", "").Split(',')[3].Split(':')[1].Trim();

            SQLHelper sqlHelper = new SQLHelper();
            var login = sqlHelper.ExternalLogin(google_id, "google");
            if (login.status == 0)
            {
                int success = sqlHelper.CreateExternalAccount(google_id, "google", email, user_name);

                if (success == 0)
                {
                    return;
                }
            }
            this.logged_user = user_name;
            this.uid = login.uid;
            this.authenticated = true;
            this.Close();
        }

        private void google_login_Click(object sender, EventArgs e)
        {
            string authCode = getAuthCode();
            if (authCode == null) { return; }
            getToken(authCode);

            return;
        }

        private void new_account_Click(object sender, EventArgs e)
        {
            create_account_uc.Visible = true;
        }

    }
}
