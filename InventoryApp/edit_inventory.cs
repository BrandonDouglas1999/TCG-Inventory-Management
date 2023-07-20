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
    public partial class edit_inventory : UserControl
    {
        public edit_inventory()
        {
            InitializeComponent();
        }

        private void edit_inventory_Load(object sender, EventArgs e)
        {

        }
        private void delete_card_Click(object sender, EventArgs e)
        {
            string message = "\tAre you sure? \nYou want to delete this product";
            DialogResult result = MessageBox.Show(message, "Deleting Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //delete card
                return;
            }
            else
            {
                return;
            }
        }

        /*Update changes that has been made*/
        private void update_card_Click(object sender, EventArgs e)
        {

        }

        /*Load card info from database*/
        private void load_cardInfo()
        {


        }
    }
}
