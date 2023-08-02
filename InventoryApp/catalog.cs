using InventoryApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        public String path = @"D:\Users\hang_\Documents\School\Capstone\GitHub\TCG-Inventory-Management-Application\InventoryApp\CardImage"; //change this too
        SQLHelper db = new SQLHelper();
        int ScrollVal = 0;
        DataTable dt;

        //for passing around between tabs
        string cid;
        string sc;
        string r;
        string image;
        string sp; //Store price
        string c;   //copies
        
        public catalog()
        {
            InitializeComponent();
            //Hide Tabs
            /*
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            prev_catalog.Enabled = false;
            */
            paging_catalog();
        }

        //============================================================================Gridview Interaction================================================================== 

        private void catalog_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.ColumnIndex.ToString());
            image = path + @"\" + catalog_view.Rows[e.RowIndex].Cells[5].Value.ToString();
            cid = catalog_view.Rows[e.RowIndex].Cells[6].Value.ToString();
            sc = catalog_view.Rows[e.RowIndex].Cells[8].Value.ToString();
            r = catalog_view.Rows[e.RowIndex].Cells[9].Value.ToString();
            sp = catalog_view.Rows[e.RowIndex].Cells[11].Value.ToString();
            c = catalog_view.Rows[e.RowIndex].Cells[12].Value.ToString();
            if (e.ColumnIndex == 0 && e.RowIndex >= 0) //View Market Trend
            {
                plot_market();
                tabControl1.SelectedIndex = 2;
                return;
            }
            if (e.ColumnIndex == 1 && e.RowIndex >= 0) //Edit Inventory
            {
                load_cardInfo();
                tabControl1.SelectedIndex = 1;
                return;
            }
            if (e.ColumnIndex == 2 && e.RowIndex >= 0) //Add to shopping cart
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
            MessageBox.Show(ScrollVal.ToString());
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
        }

        private void next_catalog_Click(object sender, EventArgs e) //need to work on in case of hitting the end of result
        {
            ScrollVal = ScrollVal + 20;
            MessageBox.Show(ScrollVal.ToString());
            if (ScrollVal > 0)
            {
                prev_catalog.Enabled = true;
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
            ScrollVal = db.LoadCatalog(dt, ScrollVal, Global.filters);
            
            dt.Columns["Card_Name"].ColumnName = "Card Name";
            dt.Columns["Set_Code"].ColumnName = "Set Code";
            dt.Columns["market_price"].ColumnName = "Market Price";
            dt.Columns["Store_Price"].ColumnName = "Store Price";

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
            catalog_view.Columns[10].Visible = false;
            //Resizing columns
            catalog_view.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            catalog_view.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            catalog_view.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            catalog_view.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            catalog_view.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //Change prices decimal points
            catalog_view.Columns[7].DefaultCellStyle.Format = "0.00##";
            catalog_view.Columns[8].DefaultCellStyle.Format = "0.00##";

            //Add buttons to gridview
            DataGridViewButtonColumn update_card = new DataGridViewButtonColumn();
            update_card.FlatStyle = FlatStyle.Standard;
            update_card.Text = "Market Info";
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
//======================================================================Edit Card Tab===========================================================================================================
        private void delete_card_Click(object sender, EventArgs e)
        {
            string message = "\tAre you sure? \nYou want to delete this product";
            DialogResult result = MessageBox.Show(message, "Deleting Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //delete card
                tabControl1.SelectedIndex = 0;
                return;
            }
            else
            {
                return;
            }
        }

        private void load_cardInfo()
        {
            string query = String.Format("Select card_name, card_type, card_race, set_name, market_price from dbo.YGOCurrentMarket where card_id = {0} and set_code = '{1}' and rarity = '{2}'", cid, sc, r);
            DataTable dt = new DataTable();
            dt = db.Select(query);
            CardImage.Image = Image.FromFile(image);
            CardImage.SizeMode = PictureBoxSizeMode.StretchImage;
            card_id.Text = cid;
            set_code.Text = sc;
            card_rarity.Text = r;
            store_price.Text = sp.Substring(0, sp.Length - 2);
            card_copies.Text = c;
            card_name.Text = dt.Rows[0]["card_name"].ToString();
            card_type.Text = dt.Rows[0]["card_type"].ToString();
            card_race.Text = dt.Rows[0]["card_race"].ToString();
            set_name.Text = dt.Rows[0]["set_name"].ToString();
            string mp = dt.Rows[0]["market_price"].ToString();
            market_price.Text = mp.Substring(0, mp.Length - 2);
        }
        
        private void cancel_bttn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
//=====================================================================Graph view===============================================================================================================

        /*Load the default plot and set up date boxes range*/
        private void plot_market()
        {
            marketChart.Plot.Clear();
            marketChart.Plot.XAxis.Label("Market Price For The Past 7 Days");
            GraphPic.Image = Image.FromFile(image);
            GraphPic.SizeMode = PictureBoxSizeMode.StretchImage;
            string query = string.Format("Select Top 7 update_date, market_price from dbo.YGOMarketPrice where card_id = {0} and set_code = '{1}' and rarity = '{2}' order by update_date desc", 
                cid, sc, r);
            DataTable marketdt = new DataTable();
            marketdt = db.GetCardMarket(query);
            if (marketdt == null)
            {
                StartRange.CustomFormat = "yyyy-MM-dd";
                EndRange.CustomFormat = "yyyy-MM-dd";
                StartRange.MaxDate = DateTime.Today;
                StartRange.MinDate = DateTime.Today;
                EndRange.MaxDate = DateTime.Today;
                EndRange.MinDate = DateTime.Today;
                return;
            }
            plot_data(marketdt);
            dateBoxes();
        }

        /*Setting range for datebox*/
        private void dateBoxes()
        {
            var range = db.DateRange(cid, sc, r);
            StartRange.MinDate = Convert.ToDateTime(range.start);
            StartRange.MaxDate = Convert.ToDateTime(range.end);
            EndRange.MinDate = Convert.ToDateTime(range.start);
            EndRange.MaxDate = Convert.ToDateTime(range.end);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void refresh_chart_Click(object sender, EventArgs e)
        {
            if (StartRange.Value > EndRange.Value)
            {
                return;
            }
            string start = StartRange.Value.ToString("yyy-MM-dd");
            string end = EndRange.Value.ToString("yyyy-MM-dd");
            DataTable dt = new DataTable();
            dt = db.CPriceHistory(cid, sc, r, start, end);
            if (dt == null) 
            {
                return; 
            }
            marketChart.Plot.Clear();
            marketChart.Plot.XAxis.Label(String.Format("Market Price From {0} to {1}", start, end));
            plot_data(dt);
        }

        private void plot_data(DataTable dt)
        {
            DateTime[] date = new DateTime[dt.Rows.Count];
            double[] y = new double[dt.Rows.Count];
            string[] y_label = new string[dt.Rows.Count];
            for (int count = 0; count < dt.Rows.Count; count++)
            {
                date[count] = Convert.ToDateTime(dt.Rows[count]["update_date"].ToString());
                y[count] = Math.Round(Convert.ToDouble(dt.Rows[count]["market_price"]), 2);
                y_label[count] = "$" + y[count].ToString();
            }
            //convert date time to double
            double[] x = date.Select(x => x.ToOADate()).ToArray();

            var plot = marketChart.Plot.AddScatter(x, y);
            marketChart.Plot.XAxis.DateTimeFormat(true);
            marketChart.Plot.YAxis.Label("Card Price (CAD)");
            plot.DataPointLabels = y_label;
            marketChart.Plot.SetAxisLimits(x.Min() - .5, x.Max() + .7, y.Min() - 2, y.Max() + 1);
            // disable left-click-drag pan
            marketChart.Configuration.Pan = false;
            // disable right-click-drag zoom
            marketChart.Configuration.Zoom = false;
            // disable scroll wheel zoom
            marketChart.Configuration.ScrollWheelZoom = false;
            // disable middle-click-drag zoom window
            marketChart.Configuration.MiddleClickDragZoom = false;
            marketChart.Refresh();
            EndRange.Value = date[0];
            StartRange.Value = date[dt.Rows.Count - 1];
        }
    }


}
