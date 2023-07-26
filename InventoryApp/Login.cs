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

namespace InventoryApp
{
    public partial class Login : Form
    {

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

            HttpListener get_code = new HttpListener();
            string auth = $"https://accounts.google.com/o/oauth2/v2/auth?" +
                $"scope=profile%20email" +
                $"&response_type=code&" +
                $"redirect_uri=http://{IPAddress.Loopback}:15000/&" +
                $"client_id=657611740650-i9i8o0846cs58juodncpo44hgpj8ju6s.apps.googleusercontent.com";

            Debug.Print(auth);

            // Create a URI to redirect the authorization code to on port 15000

            string redirect_URI = $"http://{IPAddress.Loopback}:15000/";

            // Listen for the OAuth token.
            get_code.Prefixes.Add(redirect_URI);
            get_code.Start();

            ProcessStartInfo auth_url = new ProcessStartInfo(auth);
            auth_url.UseShellExecute = true;
            Process.Start(auth_url);

            // From the HttpListener, get the context and extract the authorized code
            // Add some kind of error check here too
            HttpListenerContext context = get_code.GetContext();

            //string code = context.Request.QueryString.Get("code");

            // Query string is a NameValueCollection (basically a dictionary)
            // As of right now, contains the following keys:
            // code: the authorization code
            // scope: the resources we can access, only requesting email and profile for our app
            // authuser: number of the user being auth'd
            // prompt: The prompt for the user when signing in

            // If there is an error, error is the only key.


            get_code.Stop();

            return;
        }
    }
}
