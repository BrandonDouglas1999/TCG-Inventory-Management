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
    public partial class home_page : UserControl
    {
        /*
        Use datagridview to show all the card that change it price, then user can select a card on the datagrid view then the chart will show the market trend of that card
        */
        SQLHelper db = new SQLHelper();
        private ScottPlot.Plottable.MarkerPlot HighlightedPoint;
        private ScottPlot.Plottable.ScatterPlot CurrencyPlot;
        private ScottPlot.Plottable.ScatterPlot CardPlot;
        private int LastHighlightedIndex = -1; //for currency chart
        private int LastHighlightedIndex2 = -1; //for card chart
        public string uid = null;
        public home_page()
        {
            InitializeComponent();

            logged_user.ForeColor = Color.White;
            user_label.ForeColor = Color.White;

        }



        /*Load currency exchange rate for the last 7 days*/
        private void load_rateChart()
        {
            chart2.Plot.Clear();
            //Fill chart 
            DataTable dt = new DataTable();
            string query = "Select top 7 update_date, rate from dbo.ConversionRate order by update_date desc";
            dt = db.Select(query);
            if (dt == null)
            {
                return;
            }
            DateTime[] date = new DateTime[dt.Rows.Count];
            double[] y = new double[dt.Rows.Count];
            string[] y_label = new string[dt.Rows.Count];
            for (int count = 0; count < dt.Rows.Count; count++)
            {
                date[count] = Convert.ToDateTime(dt.Rows[count]["update_date"].ToString());
                y[count] = Math.Round(Convert.ToDouble(dt.Rows[count]["rate"]), 3);
                y_label[count] = y[count].ToString();
            }
            //convert date time to double
            double[] x = date.Select(x => x.ToOADate()).ToArray();
            CurrencyPlot = chart2.Plot.AddScatter(x, y);
            chart2.Plot.XAxis.DateTimeFormat(true);
            chart2.Plot.XAxis.Label("Date");
            chart2.Plot.YAxis.Label("Conversion Rate (CAD to USD)");
            //plot.DataPointLabels = y_label;
            chart2.Plot.SetAxisLimits(x.Min() - .5, x.Max() + .5, y.Min() - 0.01, y.Max() + 0.01);
            // disable left-click-drag pan
            chart2.Configuration.Pan = false;
            // disable right-click-drag zoom
            chart2.Configuration.Zoom = false;
            // disable scroll wheel zoom
            chart2.Configuration.ScrollWheelZoom = false;
            // disable middle-click-drag zoom window
            chart2.Configuration.MiddleClickDragZoom = false;
            chart2.Plot.Grid(false);
            chart2.Plot.XAxis.TickLabelStyle(rotation: 45);

            //Add red circle as highlight point indicator
            HighlightedPoint = chart2.Plot.AddPoint(0, 0);
            HighlightedPoint.Color = Color.Red;
            HighlightedPoint.MarkerSize = 10;
            HighlightedPoint.MarkerShape = ScottPlot.MarkerShape.openCircle;
            HighlightedPoint.IsVisible = false;

            chart2.Refresh();
        }

        private void currency_MouseMove(object sender, MouseEventArgs e)
        {
            // determine point nearest the cursor
            (double mouseCoordX, double mouseCoordY) = chart2.GetMouseCoordinates();
            double xyRatio = chart2.Plot.XAxis.Dims.PxPerUnit / chart2.Plot.YAxis.Dims.PxPerUnit;
            (double pointX, double pointY, int pointIndex) = CurrencyPlot.GetPointNearest(mouseCoordX, mouseCoordY, xyRatio);

            // place the highlight over the point of interest
            HighlightedPoint.X = pointX;
            HighlightedPoint.Y = pointY;
            HighlightedPoint.IsVisible = true;
            DateTime date = DateTime.FromOADate(pointX);
            date_label.Text = date.ToString("yyyy-MM-dd");
            rate_label.Text = pointY.ToString();

            // render if the highlighted point chnaged
            if (LastHighlightedIndex != pointIndex)
            {
                LastHighlightedIndex = pointIndex;
                chart2.Render();
            }
        }

        private void load_priceChange()
        {
            increaseTable.Columns.Clear();
            DataTable dt = new DataTable();
            string query = "select SP.card_id, AP.card_name, SP.set_code, SP.rarity, AP.lastWeekAVG, AP.thisWeekAVG, AP.differ from YGOStorePrice as SP inner join " +
                "(select C.card_name, A.card_id, A.set_code, A.rarity, A.lastWeekAVG, A.thisWeekAVG, A.differ from YGOPriceAVG as A inner join " +
                "YGOCardsInfo as C on  A.card_id = C.card_id where A.differ > 5 or A.differ < -4) as AP on SP.card_id = AP.card_id and SP.set_code " +
                $"= AP.set_code and SP.rarity = AP.rarity and SP.user_id = '{uid}'";
            dt = db.Select(query);
            increaseTable.DataSource = dt;
            increaseTable.Columns[0].Visible = false;
            increaseTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            increaseTable.Columns[4].DefaultCellStyle.Format = "$0.00##";
            increaseTable.Columns[5].DefaultCellStyle.Format = "$0.00##";
            increaseTable.Columns[6].DefaultCellStyle.Format = "$0.00##";
            DataGridViewButtonColumn graph_card = new DataGridViewButtonColumn();
            graph_card.Text = "See Market Trend";
            graph_card.UseColumnTextForButtonValue = true;
            increaseTable.Columns.Add(graph_card);
        }

        private void increaseTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string cid = increaseTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                string sc = increaseTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                string r = increaseTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (e.ColumnIndex == 7)
                {
                    load_cardTrend(cid, sc, r);
                }
            }
        }

        private void load_cardTrend(string cid, string setcode, string rarity)
        {
            DataTable dt = new DataTable();
            string query = String.Format("select update_date, market_price from YGOMarketPrice where card_id = {0} and set_code = '{1}' and rarity = '{2}' and " +
                "update_date > DATEADD(week, -2, format(GETDATE(), 'yyyy-MM-dd'))", cid, setcode, rarity);
            dt = db.Select(query);
            plot_data(dt);
        }

        private void plot_data(DataTable dt)
        {
            chart.Plot.Clear();
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
            CardPlot = chart.Plot.AddScatter(x, y);
            chart.Plot.XAxis.DateTimeFormat(true);
            chart.Plot.YAxis.Label("Card Price (CAD)");
            chart.Plot.XAxis.Label("Market Price for the Past 2 Weeks");
            //plot.DataPointLabels = y_label;
            chart.Plot.SetAxisLimits(x.Min() - 1, x.Max() + .9, y.Min() - 2, y.Max() + 1);
            chart.Plot.XAxis.TickLabelStyle(rotation: 45);

            //Add red circle as highlight point indicator
            HighlightedPoint = chart.Plot.AddPoint(0, 0);
            HighlightedPoint.Color = Color.Green;
            HighlightedPoint.MarkerSize = 10;
            HighlightedPoint.MarkerShape = ScottPlot.MarkerShape.openCircle;
            HighlightedPoint.IsVisible = false;
            chart.MouseMove += card_MouseMove;
            chart.Refresh();
        }

        private void card_MouseMove(object sender, MouseEventArgs e)
        {
            // determine point nearest the cursor
            (double mouseCoordX, double mouseCoordY) = chart.GetMouseCoordinates();
            double xyRatio = chart.Plot.XAxis.Dims.PxPerUnit / chart.Plot.YAxis.Dims.PxPerUnit;
            (double pointX, double pointY, int pointIndex) = CardPlot.GetPointNearest(mouseCoordX, mouseCoordY, xyRatio);

            // place the highlight over the point of interest
            HighlightedPoint.X = pointX;
            HighlightedPoint.Y = pointY;
            HighlightedPoint.IsVisible = true;
            DateTime date = DateTime.FromOADate(pointX);
            date_label.Text = date.ToString("yyyy-MM-dd");
            rate_label.Text = "$" + pointY.ToString();

            // render if the highlighted point chnaged
            if (LastHighlightedIndex2 != pointIndex)
            {
                LastHighlightedIndex2 = pointIndex;
                chart.Render();
            }
        }

        public void load_dashboard()
        {
            load_rateChart();
            load_priceChange();
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void update_username(string user_name)
        {
            logged_user.Text = user_name;
        }
    }
}
