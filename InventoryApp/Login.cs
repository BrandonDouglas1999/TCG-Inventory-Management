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
    }
}
