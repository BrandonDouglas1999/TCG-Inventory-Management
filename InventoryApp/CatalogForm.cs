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
using System.IO;
using System.Data.SqlClient;

namespace InventoryApp
{
    public partial class CatalogForm : Form
    {
        public String path = @"D:\Users\hang_\Documents\School\Capstone\GitHub\TCG-Inventory-Management-Application\InventoryApp\CardImage";
        SQLHelper db = new SQLHelper();
        DataTable dt;
        int ScrollVal; //Value for paging
        public CatalogForm()
        {
            InitializeComponent();
            ScrollVal= 0;
            prev_catalog.Enabled = false;
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            paging_catalog();
        }

//============================================================================Gridview Interaction================================================================== 

        private void catalog_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11) //Update Online Price
            {
                return;
            }
            if (e.ColumnIndex == 12) //Edit Inventory
            {
                return;
            }
            if (e.ColumnIndex == 13) //Add to shopping cart
            {
                return;
            }
        }

        //mouse over event
        private void catalog_view_mouseover(object sender, DataGridViewCellMouseEventArgs e)
        {
            return;
        }

//============================================================================Catalog Gridview===================================================================
        private void paging_catalog() /*Default load for catalog*/
        {
            setup_dttable();
            format_view();
        }

        private void prev_catalog_Click(object sender, EventArgs e)
        {
            ScrollVal = ScrollVal - 20;
            if (ScrollVal < 0) 
            {
                ScrollVal= 0;
            }
            setup_dttable();
            format_view();
            if (ScrollVal == 0)
            {
                prev_catalog.Enabled = false;
            }
        }  
        
        private void next_catalog_Click(object sender, EventArgs e)
        {
            ScrollVal = ScrollVal + 20;
            if (ScrollVal > 0)
            {
                prev_catalog.Enabled= true;
            }
            setup_dttable();
            format_view();
        }
        
        private void setup_dttable() /*Set up datatable for query result*/
        {
            dt = new DataTable();
            dt.Columns.Add("Card Image", Type.GetType("System.Byte[]")); //Thumbnail
            dt.Columns.Add("Card Image Full", Type.GetType("System.Byte[]")); //full image
            //dt.Load(myreader); //load sql result into datatable
            db.LoadCatalog(dt, ScrollVal);
            dt.Columns["Card_Name"].ColumnName = "Card Name";
            dt.Columns["Set_Code"].ColumnName = "Set Code";
            dt.Columns["Current_Price"].ColumnName = "Online Price";
            dt.Columns["Store_Price"].ColumnName = "Store Price";
            dt.Columns["Set_Name"].ColumnName = "Set Name";
            //get image into table
            foreach (DataRow row in dt.Rows)
            {
                String image_thumbnail = path + @"\Card_Thumbnails\" + row["Image"].ToString();
                row["Card Image"] = File.ReadAllBytes(image_thumbnail);
                String full_image = path + @"\" + row["Image"].ToString();
                row["Card Image Full"] = File.ReadAllBytes(full_image);
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
            catalog_view.DataSource = null;
            catalog_view.Rows.Clear();
            catalog_view.Columns.Clear();
            catalog_view.DataSource = dt;
            catalog_view.EnableHeadersVisualStyles = false;
            catalog_view.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 26, 28, 60); //change header cell color
            catalog_view.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;                 //change header text color
            catalog_view.Columns[1].Visible = false; //hide full image
            catalog_view.Columns[2].Visible = false; //hide image file name
            catalog_view.Columns[3].Visible = false; //hide card_id
            //Resizing columns
            catalog_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            catalog_view.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            catalog_view.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            catalog_view.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            catalog_view.AutoSizeRowsMode= DataGridViewAutoSizeRowsMode.AllCells;
            //Change prices decimal points
            catalog_view.Columns[8].DefaultCellStyle.Format = "0.00##";
            catalog_view.Columns[9].DefaultCellStyle.Format = "0.00##";

            //Add buttons to gridview
            DataGridViewButtonColumn update_card = new DataGridViewButtonColumn();
            update_card.FlatStyle = FlatStyle.Standard;
            update_card.Text = "Update";
            update_card.UseColumnTextForButtonValue = true; //display text for button 
            update_card.CellTemplate.Style.ForeColor = Color.FromArgb(254, 38, 171, 254);
            catalog_view.Columns.Add(update_card);

            DataGridViewButtonColumn edit_card = new DataGridViewButtonColumn();
            edit_card.Text = "Edit";
            edit_card.UseColumnTextForButtonValue = true; //display text for button 
            catalog_view.Columns.Add(edit_card);

            DataGridViewButtonColumn add_to_cart = new DataGridViewButtonColumn();
            add_to_cart.Text = "Add to Cart";
            add_to_cart.UseColumnTextForButtonValue = true;
            catalog_view.Columns.Add(add_to_cart);
        }

        //===============================================================================================================================================================   
    }
}
