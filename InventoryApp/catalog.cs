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
        class Global
        {
            public static string filters = CatalogForm.return_filter_string(1, "card_name = 'Alghoul Mazera'", null, null, null, null, null, null);
        }

        public String path = @"D:\Users\hang_\Documents\School\Capstone\GitHub\TCG-Inventory-Management-Application\InventoryApp\CardImage";
        SQLHelper db = new SQLHelper();
        DataTable dt;
        int ScrollVal; //Value for paging
        public catalog()
        {
            InitializeComponent();
            ScrollVal = 0;
            prev_catalog.Enabled = false;
            game_combobox.MouseWheel += (o, e) => ((HandledMouseEventArgs)e).Handled = true; //prevent mouse scrolling on combobox
        }

        //============================================================================Gridview Interaction================================================================== 

        private void catalog_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0) 
            {
                string image= path + @"\" + catalog_view.Rows[e.RowIndex].Cells[2].Value.ToString();
                //Show full image in a dialog box
                using (Full_ImageForm full_image = new Full_ImageForm())
                {
                    full_image.image_path = image;
                    full_image.ShowDialog();
                } 
            }

            if (e.ColumnIndex == 11 && e.RowIndex >= 0) //Update Online Price
            {
                MessageBox.Show("Update");
                return;
            }
            if (e.ColumnIndex == 12 && e.RowIndex >= 0) //Edit Inventory
            {
                /*
                    Pass row info: Card ID, Set Code, Rarity and change user form edit_inventory
                 */
                String card_id = catalog_view.Rows[e.RowIndex].Cells[3].Value.ToString();
                String set_code = catalog_view.Rows[e.RowIndex].Cells[5].Value.ToString();
                String rarity = catalog_view.Rows[e.RowIndex].Cells[6].Value.ToString();
                String image_path = path + @"\" + catalog_view.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            if (e.ColumnIndex == 13 && e.RowIndex >= 0) //Add to shopping cart
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
                ScrollVal = 0;
            }
            setup_dttable();
            format_view();
            if (ScrollVal == 0)
            {
                prev_catalog.Enabled = false;
            }
            if (setup_dttable() == 0)
            {
                next_catalog.Enabled = true;
            }

        }

        private void next_catalog_Click(object sender, EventArgs e) //need to work on in case of hitting the end of result
        {
            ScrollVal = ScrollVal + 20;
            if (ScrollVal > 0)
            {
                prev_catalog.Enabled = true;
            }
            if (setup_dttable() == 1)
            {
                next_catalog.Enabled = false;
            }
            format_view();
        }

        private int setup_dttable() /*Set up datatable for query result*/
        {
            int end; //indicate that the table have reached the end of database
            dt = new DataTable();
            dt.Columns.Add("Card Image", Type.GetType("System.Byte[]")); //Thumbnail
            dt.Columns.Add("Card Image Full", Type.GetType("System.Byte[]")); //full image
            //dt.Load(myreader); //load sql result into datatable
            end = db.LoadCatalog(dt, ScrollVal, Global.filters);
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
            return end;
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
            catalog_view.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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

        /*
         * Function to be run when you wish to filter what options the catalog is showing.
         * 
         * Inputs:
         * total_filters: Total number of filters that aren't null
         * card_name, card_type, etc. - Strings containing sql filter statements corresponding to desired filters(ie. card_price = "card_price > 32")
         *                         or NULL if you do not wish to filter category
         *                       
         * Outputs: filter_string - String to be used for SQL select statement where clause
         */
        public static string return_filter_string(int total_filters, string card_name, string card_type, string card_race, string card_price, string rarity, string inventory, string set_name)
        {
            if (total_filters == 0) { return null; }

            int current_filter = 0; //Way to check current number of implemented filters
            string filter_string = ""; //empty string to be used for filters for SQL select statement

            //Repeated for each category that can be filtered
            //If card_name has a filter string
            if (!string.IsNullOrEmpty(card_name))
            {
                //Increase current filter and add card_name to filter string
                current_filter += 1;
                filter_string += card_name;
                //If there's another filter to be added, add " and " to SQL filter string
                if (current_filter < total_filters)
                {
                    filter_string += " and ";
                }
            }

            if (!string.IsNullOrEmpty(card_type))
            {
                current_filter += 1;
                filter_string += card_type;
                if (current_filter < total_filters)
                {
                    filter_string += " and ";
                }
            }

            if (!string.IsNullOrEmpty(card_race))
            {
                current_filter += 1;
                filter_string += card_race;
                if (current_filter < total_filters)
                {
                    filter_string += " and ";
                }
            }

            if (!string.IsNullOrEmpty(card_price))
            {
                current_filter += 1;
                filter_string += card_price;
                if (current_filter < total_filters)
                {
                    filter_string += " and ";
                }
            }

            if (!string.IsNullOrEmpty(rarity))
            {
                current_filter += 1;
                filter_string += rarity;
                if (current_filter < total_filters)
                {
                    filter_string += " and ";
                }
            }

            if (!string.IsNullOrEmpty(inventory))
            {
                current_filter += 1;
                filter_string += inventory;
                if (current_filter < total_filters)
                {
                    filter_string += " and ";
                }
            }

            if (!string.IsNullOrEmpty(set_name))
            {
                current_filter += 1;
                filter_string += set_name;
                if (current_filter < total_filters)
                {
                    filter_string += " and ";
                }
            }

            return filter_string;
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void game_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (game_combobox.SelectedIndex == 0)
            {
                paging_catalog();
            }
        }
    }


}
