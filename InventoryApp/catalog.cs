using InventoryApp.API_Model;
using InventoryApp.Helpers;
using InventoryApp.Processors;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace InventoryApp
{
    public partial class catalog : UserControl
    {
        public string path = Global.path;
        SQLHelper db = new SQLHelper();
        private ScottPlot.Plottable.ScatterPlot CardPlot;
        private ScottPlot.Plottable.MarkerPlot HighlightedPoint;
        private int LastHighlightedIndex2 = -1;
        int ScrollVal = 0;
        DataTable dt;

        //for passing around between tabs
        string cid;
        string sc;
        string r;
        string image;
        string sp; //Store price
        string c;  //copies

        public catalog()
        {
            InitializeComponent();
            //Hide Tabs

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            // disable left-click-drag pan
            marketChart.Configuration.Pan = false;
            // disable right-click-drag zoom
            marketChart.Configuration.Zoom = false;
            // disable scroll wheel zoom
            marketChart.Configuration.ScrollWheelZoom = false;
            // disable middle-click-drag zoom window
            marketChart.Configuration.MiddleClickDragZoom = false;
            marketChart.Plot.YAxis.Label(size: 16, bold: true);
            marketChart.Plot.XAxis.Label(size: 16, bold: true);

            panel1.BackColor = Color.FromArgb(255, 50, 55, 143);
            panel2.BackColor = Color.FromArgb(255, 50, 55, 143);
            panel3.BackColor = Color.FromArgb(255, 50, 55, 143);
        }

        //============================================================================Gridview Interaction================================================================== 


        private void catalog_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.ColumnIndex.ToString());

            //Code fails unless you move to next page then go back
            if (e.ColumnIndex >= 10 && e.RowIndex >= 0)
            {
                image = path + @"\" + catalog_view.Rows[e.RowIndex].Cells[1].Value.ToString();
                cid = catalog_view.Rows[e.RowIndex].Cells[2].Value.ToString();
                sc = catalog_view.Rows[e.RowIndex].Cells[4].Value.ToString();
                r = catalog_view.Rows[e.RowIndex].Cells[6].Value.ToString();
                sp = catalog_view.Rows[e.RowIndex].Cells[8].Value.ToString();
                c = catalog_view.Rows[e.RowIndex].Cells[9].Value.ToString();
                if (e.ColumnIndex == 10 && e.RowIndex >= 0) //View Market Trend
                {
                    plot_market();
                    tabControl1.SelectedIndex = 2;
                    return;
                }
                if (e.ColumnIndex == 11 && e.RowIndex >= 0) //Edit Inventory
                {
                    load_cardInfo();
                    tabControl1.SelectedIndex = 1;
                    return;
                }
                if (e.ColumnIndex == 13 && e.RowIndex >= 0) //Add to shopping cart
                {
                    int quantity;
                    object quantity_value = catalog_view.Rows[e.RowIndex].Cells[12].Value;
                    string quantity_string;
                    if (quantity_value == null)
                    {
                        MessageBox.Show("Quantity Must Not Be Empty");
                        return;
                    }

                    quantity_string = catalog_view.Rows[e.RowIndex].Cells[12].Value.ToString();

                    if (String.IsNullOrEmpty(quantity_string))
                    {
                        MessageBox.Show("Quantity Must Not Be Empty");
                    }
                    else if (!int.TryParse(quantity_string, out quantity))
                    {
                        MessageBox.Show("Quantity Must Be Numeric");
                    }
                    else if (quantity <= 0)
                    {
                        MessageBox.Show("Quantity Must Be Positive");
                    }
                    else
                    {
                        int success = db.AddToShoppingCart(Global.uid, cid, sc, r, quantity);
                        if (success == 1)
                        {
                            MessageBox.Show("Card added to cart");
                        }
                        else if (success == 0)
                        {
                            MessageBox.Show("Quantity amount exceed the amount of copies on-hand.");
                        }
                    }
                    return;
                }
            }
            else
            {
                return;
            }
        }

        //============================================================================Catalog Gridview===================================================================
        public void paging_catalog() /*Default load for catalog*/
        {
            setup_dttable();
            format_view();

            //Fill combo boxes
            DataTable rarity_datatable = db.GetRarities();
            rarity_datatable.DefaultView.Sort = "Rarity ASC";
            rarity_combobox.DataSource = rarity_datatable;
            rarity_combobox.DisplayMember = "Rarity";

            DataTable card_type_datatable = db.GetCardType();
            DataRow emptyRow = card_type_datatable.NewRow();
            emptyRow["card_type"] = "";
            card_type_datatable.Rows.Add(emptyRow);
            card_type_datatable.DefaultView.Sort = "card_type ASC";
            card_type_combobox.DataSource = card_type_datatable;
            card_type_combobox.DisplayMember = "card_type";


            DataTable card_race_datatable = db.GetCardRace();
            emptyRow = card_race_datatable.NewRow();
            emptyRow["card_race"] = "";
            card_race_datatable.Rows.Add(emptyRow);
            card_race_datatable.DefaultView.Sort = "card_race ASC";
            card_race_combobox.DataSource = card_race_datatable;
            card_race_combobox.DisplayMember = "card_race";

        }

        private void prev_catalog_Click(object sender, EventArgs e)
        {
            ScrollVal -= 20;
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
            ScrollVal += 20;
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
            //dt.Load(myreader); //load sql result into datatable

            int end = db.LoadCatalog(dt, Global.uid, ScrollVal, Global.filters);

            dt.Columns["Card_Name"].ColumnName = "Card Name";
            dt.Columns["Set_Code"].ColumnName = "Set Code";
            dt.Columns["set_name"].ColumnName = "Set Name";
            dt.Columns["rarity"].ColumnName = "Rarity";
            dt.Columns["market_price"].ColumnName = "Market Price";
            dt.Columns["Store_Price"].ColumnName = "Store Price";
            dt.Columns["Copies"].ColumnName = "Copies";

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
            if (end == 1)
            {
                next_catalog.Enabled = false;
            }
            else
            {
                next_catalog.Enabled = true;
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
            catalog_view.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 47, 76, 100); //change header cell color
            catalog_view.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;                 //change header text color

            catalog_view.Columns[1].Visible = false; //hide image file name
            catalog_view.Columns[2].Visible = false; //hide card id

            //Change prices decimal points
            catalog_view.Columns[7].DefaultCellStyle.Format = "$0.00##";
            catalog_view.Columns[8].DefaultCellStyle.Format = "$0.00##";

            //Add buttons to gridview
            DataGridViewButtonColumn update_card = new DataGridViewButtonColumn();
            update_card.FlatStyle = FlatStyle.Standard;
            update_card.Text = "Market Info";
            update_card.UseColumnTextForButtonValue = true; //display text for button 
            update_card.CellTemplate.Style.ForeColor = Color.FromArgb(254, 38, 171, 254);
            catalog_view.Columns.Add(update_card);

            DataGridViewButtonColumn edit_card = new DataGridViewButtonColumn();
            edit_card.Text = "Edit Inventory";
            edit_card.UseColumnTextForButtonValue = true; //display text for button 
            catalog_view.Columns.Add(edit_card);

            catalog_view.Columns.Add("Qty.", "Qty.");
            catalog_view.Columns[12].ValueType = typeof(string);
            catalog_view.Columns[12].ReadOnly = false;
            //catalog_view.Columns[12].AllowNumericOnly = true;


            DataGridViewButtonColumn add_to_cart = new DataGridViewButtonColumn();
            add_to_cart.Text = "Add to Cart";
            add_to_cart.UseColumnTextForButtonValue = true;
            catalog_view.Columns.Add(add_to_cart);

            //Edit cell and column size
            catalog_view.RowTemplate.Height = 153;
            catalog_view.Columns[0].Width = 105;
            catalog_view.Columns[3].Width = 220;
            catalog_view.Columns[6].Width = 50;
            catalog_view.Columns[7].Width = 65;
            catalog_view.Columns[8].Width = 65;
            catalog_view.Columns[9].Width = 50;
            catalog_view.Columns[12].Width = 35;

            //Make sure columns are not editable
            catalog_view.Columns[0].ReadOnly = true;
            catalog_view.Columns[1].ReadOnly = true;
            catalog_view.Columns[2].ReadOnly = true;
            catalog_view.Columns[3].ReadOnly = true;
            catalog_view.Columns[4].ReadOnly = true;
            catalog_view.Columns[5].ReadOnly = true;
            catalog_view.Columns[6].ReadOnly = true;
            catalog_view.Columns[7].ReadOnly = true;
            catalog_view.Columns[8].ReadOnly = true;
            catalog_view.Columns[9].ReadOnly = true;
            catalog_view.Columns[10].ReadOnly = true;
            catalog_view.Columns[11].ReadOnly = true;
            catalog_view.Columns[12].ReadOnly = false; //Make sure quantity is editable
            catalog_view.Columns[13].ReadOnly = true;

            foreach (DataGridViewRow r in catalog_view.Rows)
            {
                r.Cells[12].Value = 1;
            }
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
        public static string return_filter_string(string search_string, string card_type, string card_race, string rarity, string card_price_lower, string card_price_upper, string inventory_lower, string inventory_upper)
        {

            string filter_string = ""; //empty string to be used for filters for SQL select statement

            //If card_name has a filter string
            if (!string.IsNullOrEmpty(search_string))
            {
                filter_string += "UPPER(card_name) like UPPER('%" + search_string + "%')";
                filter_string += " and UPPER(set_name) like UPPER('%" + search_string + "%')";
                filter_string += " and UPPER(set_code) like UPPER('%" + search_string + "%')";
            }

            if (!string.IsNullOrEmpty(card_type))
            {
                if (!string.IsNullOrEmpty(filter_string))
                {
                    filter_string += " and ";
                }
                filter_string += "card_type = " + card_type;
            }

            if (!string.IsNullOrEmpty(card_race))
            {
                if (!string.IsNullOrEmpty(filter_string))
                {
                    filter_string += " and ";
                }
                filter_string += "card_race = " + card_race;
            }

            if (!string.IsNullOrEmpty(rarity))
            {
                if (!string.IsNullOrEmpty(filter_string))
                {
                    filter_string += " and ";
                }
                filter_string += "rarity = " + rarity;
            }

            if (!string.IsNullOrEmpty(card_price_lower))
            {
                if (!string.IsNullOrEmpty(filter_string))
                {
                    filter_string += " and ";
                }
                filter_string += "store_price >= " + card_price_lower;
            }

            if (!string.IsNullOrEmpty(card_price_upper))
            {
                if (!string.IsNullOrEmpty(filter_string))
                {
                    filter_string += " and ";
                }
                filter_string += "store_price <= " + card_price_upper;
            }

            if (!string.IsNullOrEmpty(inventory_lower))
            {
                if (!string.IsNullOrEmpty(filter_string))
                {
                    filter_string += " and ";
                }
                filter_string += "copies >= " + inventory_lower;
            }

            if (!string.IsNullOrEmpty(inventory_upper))
            {
                if (!string.IsNullOrEmpty(filter_string))
                {
                    filter_string += " and ";
                }
                filter_string += "copies <= " + inventory_upper;
            }

            if (!string.IsNullOrEmpty(filter_string))
            {
                return null;
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
                int status = db.DeleteCard(Global.uid, card_id.Text, set_code.Text, card_rarity.Text);
                if (status == 1)
                {
                    MessageBox.Show("Product Successfully Removed From Your Inventory");
                    paging_catalog();
                    tabControl1.SelectedIndex = 0;
                }
            }
            else
            {
                return;
            }
        }

        private void load_cardInfo()
        {
            string query = String.Format("Select card_name, card_type, card_race, set_name, ROUND(market_price / R.rate, 2) as market_price from dbo.YGOCurrentMarket, dbo.ConversionRate as R where card_id = {0} and set_code = '{1}' and rarity = '{2}' " +
                "and R.update_date = (Select MAX(update_date) from ConversionRate)", cid, sc, r);
            warning_label.Visible = false;
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
            market_price.Text = dt.Rows[0]["market_price"].ToString();
        }

        private void update_card_Click(object sender, EventArgs e)
        {
            int num;
            float num2;
            if (store_price.Text == "")
            {
                warning_label.Text = "* Invalid input for Store Price and/or Card Copies.";
                warning_label.Visible = true;
                return;
            }
            else if (float.TryParse(store_price.Text, out num2) == false)
            {
                warning_label.Text = "* Invalid value for Store Price and/or Card Copies";
                warning_label.Visible = true;
                return;
            }
            int status = db.UpdateInventory(Global.uid, card_id.Text, set_code.Text, card_rarity.Text, store_price.Text, card_copies.Value.ToString());
            if (status == 1)
            {
                paging_catalog();
                tabControl1.SelectedIndex = 0;
            }
            else
            {
                return;
            }
        }

        private void cancel_bttn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        //=============================================================================Graph view===============================================================================================================


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

        //return to catalog page
        private void graphReturn_Click(object sender, EventArgs e)
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

            CardPlot = marketChart.Plot.AddScatter(x, y);
            marketChart.Plot.XAxis.DateTimeFormat(true);
            marketChart.Plot.YAxis.Label("Card Price (CAD)");
            marketChart.Plot.SetAxisLimits(x.Min() - .5, x.Max() + .7, y.Min() - 2, y.Max() + 1);

            marketChart.Plot.XAxis.TickLabelStyle(rotation: 45);

            //Add red circle as highlight point indicator
            HighlightedPoint = marketChart.Plot.AddPoint(0, 0);
            HighlightedPoint.Color = Color.Green;
            HighlightedPoint.MarkerSize = 10;
            HighlightedPoint.MarkerShape = ScottPlot.MarkerShape.openCircle;
            HighlightedPoint.IsVisible = false;
            marketChart.MouseMove += card_MouseMove;

            marketChart.Refresh();
            EndRange.Value = date[0];
            StartRange.Value = date[dt.Rows.Count - 1];
        }

        private void card_MouseMove(object sender, MouseEventArgs e)
        {
            // determine point nearest the cursor
            (double mouseCoordX, double mouseCoordY) = marketChart.GetMouseCoordinates();
            double xyRatio = marketChart.Plot.XAxis.Dims.PxPerUnit / marketChart.Plot.YAxis.Dims.PxPerUnit;
            (double pointX, double pointY, int pointIndex) = CardPlot.GetPointNearest(mouseCoordX, mouseCoordY, xyRatio);

            // place the highlight over the point of interest
            HighlightedPoint.X = pointX;
            HighlightedPoint.Y = pointY;
            HighlightedPoint.IsVisible = true;
            DateTime date = DateTime.FromOADate(pointX);
            date_label.Text = date.ToString("yyyy-MM-dd");
            price_label.Text = "$" + pointY.ToString();

            // render if the highlighted point chnaged
            if (LastHighlightedIndex2 != pointIndex)
            {
                LastHighlightedIndex2 = pointIndex;
                marketChart.Render();
            }
        }
        private void search_button_Click(object sender, EventArgs e)
        {
            if (search_box.Text == "")
            {
                return;
            }


        }

        private void search_box_TextChanged(object sender, EventArgs e)
        {
            DataTable search = new DataTable();
            string query;
            if (search_box.TextLength >= 5)
            {
                return;
            }
        }
    }
}
