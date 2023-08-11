using InventoryApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InventoryApp
{
    public partial class shopping_cart_page : UserControl
    {
        SQLHelper db = new SQLHelper();
        DataTable dt;
        public string path = Global.path;
        int ScrollVal = 0;
        public shopping_cart_page()
        {
            InitializeComponent();

        }

        public void paging_catalog() /*Default load for shopping cart*/
        {
            setup_dttable();
            format_view();
        }

        private void setup_dttable() /*Set up datatable for query result*/
        {

            dt = db.GetShoppingCart(Global.uid);
            dt.Columns.Add("Card Image", Type.GetType("System.Byte[]"));
            dt.Columns["Card_Name"].ColumnName = "Card Name";
            dt.Columns["Set_Code"].ColumnName = "Set Code";
            dt.Columns["rarity"].ColumnName = "Rarity";
            dt.Columns["market_price"].ColumnName = "Market Price";
            dt.Columns["Quantity"].ColumnName = "Quantity";

            //get image into table
            foreach (DataRow row in dt.Rows)
            {
                String image_thumbnail = path + @"\Card_Thumbnails\" + row["Image"].ToString();
                try
                {
                    row["Card Image"] = File.ReadAllBytes(image_thumbnail);
                }
                catch
                {
                    image_thumbnail = path + @"\Card_Thumbnails\21727231.jpg";
                    row["Card Image"] = File.ReadAllBytes(image_thumbnail);
                }

            }
        }

        private void format_view() /*Setting up gridview*/
        {
            //Header Cell index in display: 0, 4-10
            /*Topdeck Color Code (ARGB): 
                * 255, 237, 33, 125 
                * 255, 26, 28, 60
                * 254, 38, 171, 254
                * White(obviously)
            */
            shopping_cart_view.DataSource = null;
            shopping_cart_view.Rows.Clear();
            shopping_cart_view.Columns.Clear();
            shopping_cart_view.DataSource = dt;
            shopping_cart_view.EnableHeadersVisualStyles = false;
            shopping_cart_view.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 47, 76, 100); //change header cell color
            shopping_cart_view.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;                 //change header text color

            shopping_cart_view.Columns[1].Visible = false; //hide image file name
            shopping_cart_view.Columns[2].Visible = false; //hide card id

            //Change prices decimal points
            shopping_cart_view.Columns[6].DefaultCellStyle.Format = "$0.00##";
            //shopping_cart_view.Columns[8].DefaultCellStyle.Format = "$0.00##";

            //Add buttons to gridview
            DataGridViewButtonColumn update_card = new DataGridViewButtonColumn();
            update_card.FlatStyle = FlatStyle.Standard;
            update_card.Text = "Edit Quantity";
            update_card.UseColumnTextForButtonValue = true; //display text for button 
            update_card.CellTemplate.Style.ForeColor = Color.FromArgb(254, 38, 171, 254);
            shopping_cart_view.Columns.Add(update_card);

            //Edit cell and column size
            shopping_cart_view.RowTemplate.Height = 153;
            shopping_cart_view.Columns[0].Width = 220;
            shopping_cart_view.Columns[4].Width = 50;
            shopping_cart_view.Columns[5].Width = 50;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            int success = db.ClearShoppingCart(Global.uid);
            if (success == 1)
            {
                MessageBox.Show("Cart cleared");
                paging_catalog();
            }
            else
            {
                MessageBox.Show("An error has occured");
            }
            return;
        }

        private void check_out_Click(object sender, EventArgs e)
        {
            db.Check_Out(Global.uid, dt);
        }
    }
}
