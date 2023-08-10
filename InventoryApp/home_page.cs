using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class home_page : UserControl
    {
        public home_page()
        {
            InitializeComponent();

            logged_user.ForeColor = Color.White;
            user_label.ForeColor = Color.White;

        }

        public void update_username(string user_name)
        {
            logged_user.Text = user_name;
        }
    }
}
