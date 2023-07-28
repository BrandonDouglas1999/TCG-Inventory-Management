using InventoryApp.Helpers;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryApp
{
    public partial class Full_ImageForm : Form
    {
        public string image_path { get; set; } = @"D:\Users\hang_\Documents\School\Capstone\CardAPITest\CardAPITest\Card_Images\3410461.jpg";
        SQLHelper db = new SQLHelper();
        public Full_ImageForm()
        {
            InitializeComponent();
            //MessageBox.Show(image_path);
            //show_image(image_path);
        }

        public void show_image (string image_path)
        {
            Bitmap image = new Bitmap(image_path);
            //card_image.Image = (Image)image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Fill chart 
            DataTable dt = new DataTable();
            string card_id = "3410461";
            string set_code = "DIFO-EN035";
            string r = "(StR)";
            string query = string.Format("Select update_date, market_price from dbo.YGOMarketPrice where card_id = {0} and set_code = '{1}' and rarity = '{2}'", card_id, set_code, r);
            dt = db.GetCardMarket(query);
            dataGridView1.DataSource = dt;

            DateTime[] date = new DateTime[dt.Rows.Count];
            double[] y = new double[dt.Rows.Count];
            string[] y_label = new string[dt.Rows.Count];
            for (int count = 0; count < dt.Rows.Count; count++)
            {
                date[count] = Convert.ToDateTime(dt.Rows[count]["update_date"].ToString());
                y[count] = Math.Round(Convert.ToDouble(dt.Rows[count]["market_price"]), 2);
                y_label[count] = y[count].ToString();
            }
            //convert date time to double
            double[] x = date.Select(x => x.ToOADate()).ToArray();
            var plot = chart.Plot.AddScatter(x, y);
            chart.Plot.XAxis.DateTimeFormat(true);
            chart.Plot.XAxis.Label("Date");
            chart.Plot.YAxis.Label("Card Price (CAD)");
            plot.DataPointLabels = y_label;
            chart.Plot.SetAxisLimits(x.Min(), x.Max() + 1, y.Min() - 10, y.Max() + 10);
            // disable left-click-drag pan
            chart.Configuration.Pan = false;
            // disable right-click-drag zoom
            chart.Configuration.Zoom = false;
            // disable scroll wheel zoom
            chart.Configuration.ScrollWheelZoom = false;
            // disable middle-click-drag zoom window
            chart.Configuration.MiddleClickDragZoom = false;
            chart.Refresh();
        }
    }
}
