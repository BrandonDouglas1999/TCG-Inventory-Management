using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Diagnostics;
using InventoryApp.Helpers;

namespace InventoryApp
{
    public partial class create_account : UserControl
    {
        public create_account()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            user_input.Clear();
            email_input.Clear();
            pw_input.Clear();
            repw_input.Clear();
            this.Visible = false;
        }

        private void create_account_button_Click(object sender, EventArgs e)
        {
            error_label.ForeColor = Color.Red;

            if (string.IsNullOrEmpty(user_input.Text) || string.IsNullOrEmpty(email_input.Text) || string.IsNullOrEmpty(pw_input.Text) || string.IsNullOrEmpty(repw_input.Text))
            {
                error_label.Text = "Error: All fields must be filled";
                return;
            }

            string hashed_user = hash_values(user_input.Text);
            string hashed_email = hash_values(email_input.Text);
            string hashed_pw = hash_values(pw_input.Text);
            string hashed_repw = hash_values(repw_input.Text);

            if (hashed_pw != hashed_repw)
            {
                error_label.Text = "Error: Passwords must match";
                return;
            }

            SQLHelper helper = new SQLHelper();

            int status = helper.CreateAccount(hashed_email, hashed_user, hashed_pw, hashed_repw);

            if (status == 0)
            {
                error_label.Text = "Error: Unable to create account";
                return;
            }

            error_label.ForeColor = Color.White;
            error_label.Text = "Account Successfully Created";

            user_input.Clear();
            email_input.Clear();
            pw_input.Clear();
            repw_input.Clear();
            
        }

        public string hash_values(string input)
        {
            byte[] input_as_bytes = Encoding.UTF8.GetBytes(input);
            byte[] hash_as_bytes;

            hash_as_bytes = SHA256.HashData(input_as_bytes);
            return Encoding.UTF8.GetString(hash_as_bytes);
        }
    }
}
