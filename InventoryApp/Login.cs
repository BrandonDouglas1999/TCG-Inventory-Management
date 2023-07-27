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
using Google.Apis.Auth.AspNetCore3;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Encodings.Web;

namespace InventoryApp
{
    public partial class Login : Form
    {

        const string clientID = "657611740650-i9i8o0846cs58juodncpo44hgpj8ju6s.apps.googleusercontent.com";
        const string secret = "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";
        const string redirect_uri = $"http://127.0.0.1:15000/";

        HttpListener response_listen = new HttpListener();


        public bool authenticated = false;
        public Login()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 26, 28, 60);
            user_input.ForeColor = Color.FromArgb(255, 237, 33, 125);
            user_input.BackColor = Color.FromArgb(255, 26, 28, 60);
            pw_input.ForeColor = Color.FromArgb(255, 237, 33, 125);
            pw_input.BackColor = Color.FromArgb(255, 26, 28, 60);
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username = user_input.Text;
            string password = pw_input.Text;


            // Hash the inputs and compare against the db stored value

            // If correct, close form, if not, show error
            if (authenticated)
            {
                this.Close();
            }
            else
            {
                incorrect_prompt.Visible = true;
            }

        }

        private void google_logo_Click(object sender, EventArgs e)
        {

            string authCode = getAuthCode();
            getToken(authCode);

            return;
        }

        private string getAuthCode()
        {

            string auth = $"https://accounts.google.com/o/oauth2/v2/auth?" +
                $"scope=profile%20email" +
                $"&response_type=code&" +
                $"redirect_uri={redirect_uri}&" +
                $"client_id={clientID}";

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

            // Query string is a NameValueCollection (basically a dictionary)
            // As of right now, contains the following keys:
            // code: the authorization code
            // scope: the resources we can access, only requesting email and profile for our app
            // authuser: number of the user being auth'd
            // prompt: The prompt for the user when signing in

            // If there is an error, error is the only key.

            string code = context.Request.QueryString.Get("code");
            response_listen.Stop();
            return code;
        }

        private async void getToken(string authCode)
        {
            // Create the Token request 

            string endpoint = "https://oauth2.googleapis.com/token";

            var needed_info= new Dictionary<string, string>
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

            var result = await response.Content.ReadAsStringAsync();

            Debug.WriteLine(result);

        }
    }
}
