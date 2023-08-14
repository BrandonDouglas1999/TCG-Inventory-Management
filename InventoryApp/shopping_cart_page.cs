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

        //For use in updating quantities
        string cid;
        string set_code;
        string rarity;
        string quantity;

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
            if (dt == null || dt.Rows.Count == 0)
            {
                total_price.Text = taxes.Text = sub_total.Text = "$0.00";
                return;
            }
            dt.Columns.Add("Card Image", Type.GetType("System.Byte[]"));
            dt.Columns["Card_Name"].ColumnName = "Card Name";
            dt.Columns["Set_Code"].ColumnName = "Set Code";
            dt.Columns["rarity"].ColumnName = "Rarity";
            dt.Columns["price"].ColumnName = "Price";
            dt.Columns["Quantity"].ColumnName = "Quantity";

            //dt.Columns.Add("Copies", Type.GetType("System.Int32"));

            //get image into table
            foreach (DataRow row in dt.Rows)
            {
                String image_thumbnail = path + @"\Card_Thumbnails\" + row["Image"].ToString();
                try
                {
                    row["Card Image"] = File.ReadAllBytes(image_thumbnail);
                    //row["Copies"] = row["Quantity"];
                }
                catch
                {
                    image_thumbnail = path + @"\Card_Thumbnails\21727231.jpg";
                    row["Card Image"] = File.ReadAllBytes(image_thumbnail);
                    //row["Copies"] = row["Quantity"];
                }
            }

            if (dt.Rows.Count > 0) //get total price before GST
            {
                Double totalprice = Convert.ToDouble(dt.Compute("SUM(Price)", string.Empty));
                sub_total.Text = totalprice.ToString("$0.00");
                taxes.Text = (totalprice * 0.05).ToString("$0.00");
                total_price.Text = (totalprice + (totalprice * 0.05)).ToString("$0.00");
            }
        }

        private void format_view() /*Setting up gridview*/
        {
            shopping_cart_view.DataSource = null;
            shopping_cart_view.Rows.Clear();
            shopping_cart_view.Columns.Clear();
            if (dt == null || dt.Rows.Count <= 0)
            {
                shopping_cart_view.ColumnCount = 1;
                shopping_cart_view.Columns[0].Name = "Shopping Cart is Currently Empty";
                return;
            }
            shopping_cart_view.DataSource = dt;
            shopping_cart_view.EnableHeadersVisualStyles = false;
            shopping_cart_view.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 47, 76, 100); //change header cell color
            shopping_cart_view.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;                 //change header text color
            shopping_cart_view.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            shopping_cart_view.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            shopping_cart_view.Columns[1].Visible = false; //hide image file name
            shopping_cart_view.Columns[2].Visible = false; //hide card id

            //Make everything but the quantity read only
            shopping_cart_view.Columns[0].ReadOnly = true;
            shopping_cart_view.Columns[1].ReadOnly = true;
            shopping_cart_view.Columns[2].ReadOnly = true;
            shopping_cart_view.Columns[3].ReadOnly = true;
            shopping_cart_view.Columns[4].ReadOnly = true;
            shopping_cart_view.Columns[6].ReadOnly = true;
            

            //Change prices decimal points
            shopping_cart_view.Columns[6].DefaultCellStyle.Format = "$0.00##";

            //Add buttons to gridview
            DataGridViewButtonColumn update_card = new DataGridViewButtonColumn();
            update_card.FlatStyle = FlatStyle.Standard;
            update_card.Text = "Update Quantity";
            update_card.UseColumnTextForButtonValue = true; //display text for button 
            update_card.CellTemplate.Style.ForeColor = Color.FromArgb(254, 38, 171, 254);
            shopping_cart_view.Columns.Add(update_card);
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            int success = db.ClearShoppingCart(Global.uid);
            if (success == 1)
            {
                MessageBox.Show("Cart cleared");
                paging_catalog();
                total_price.Text = taxes.Text = sub_total.Text = "$0.00";
            }
            else
            {
                MessageBox.Show("An error has occured");
            }
            return;
        }


        private void check_out_Click(object sender, EventArgs e)
        {
            db.Check_Out(Global.uid, dt, total_price.Text);
            paging_catalog();
            total_price.Text = taxes.Text = sub_total.Text = "$0.00";
        }

        private void shopping_cart_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 8)
            {
                cid = shopping_cart_view.Rows[e.RowIndex].Cells[2].Value.ToString();
                set_code = shopping_cart_view.Rows[e.RowIndex].Cells[3].Value.ToString();
                rarity = shopping_cart_view.Rows[e.RowIndex].Cells[4].Value.ToString();
                quantity = shopping_cart_view.Rows[e.RowIndex].Cells[5].Value.ToString();

                int status = db.EditShoppingCart(Global.uid, cid, set_code, rarity, Convert.ToInt32(quantity));
                if (status == 2)
                {
                    MessageBox.Show("Card Removed From Cart");
                }
                else if(status == 1)
                {
                    MessageBox.Show("Quantity Has Been Updated");
                }   
                paging_catalog();
                return;
            }
        }
    }
}
