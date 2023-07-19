using InventoryApp.Helpers;
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
    public partial class catalog : UserControl
    {
        SQLHelper db = new SQLHelper();

        public catalog()
        {
            InitializeComponent();
        }

        private void load_catalog() //Load catalog of cards into catalog_gridview
        {
            //String query = "";
        }
    }


}
