using InventoryApp.Helpers;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataSet = System.Data.DataSet;

namespace InventoryApp
{
    public partial class sales_report : UserControl
    {
        public string uid = null;
        SQLHelper db = new SQLHelper();

        public sales_report()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            // disable left-click-drag pan
            cardPlot.Configuration.Pan = false;
            // disable right-click-drag zoom
            cardPlot.Configuration.Zoom = false;
            // disable scroll wheel zoom
            cardPlot.Configuration.ScrollWheelZoom = false;
            // disable middle-click-drag zoom window
            cardPlot.Configuration.MiddleClickDragZoom = false;
        }

        public void load_sales()
        {
            start_date.MaxDate = DateTime.Today;
            end_date.MaxDate = DateTime.Today;
            end_date.Value = DateTime.Today;
            start_date.Value = new DateTime(start_date.Value.Year, start_date.Value.Month, 1);
            load_table();
        }

        public void load_table()
        {
            receipt_view.DataSource = null;
            pop_cards.DataSource = null;
            cardPlot.Plot.Clear();
            cardPlot.Refresh();
            receipt_view.Columns.Clear();
            DataSet ds = new DataSet();
            ds = db.load_receipt(start_date.Value.ToString(), end_date.Value.ToString(), Global.uid);
            if (ds.Tables[0].Rows.Count <= 0)
            {
                receipt_view.ColumnCount = 1;
                receipt_view.Columns[0].Name = "No receipt data matching your query was found in the database";
            }
            if (ds.Tables[1].Rows.Count <= 0)
            {
                pop_cards.ColumnCount = 1;
                pop_cards.Columns[0].Name = "No data available";
                return;
            }
            receipt_view.DataSource = ds.Tables[0];
            receipt_view.Columns[3].DefaultCellStyle.Format = "$0.00##";
            DataGridViewButtonColumn view_receipt = new DataGridViewButtonColumn();
            view_receipt.Text = "See Receipt";
            view_receipt.UseColumnTextForButtonValue = true;
            receipt_view.Columns.Add(view_receipt);
            pop_cards.DataSource = ds.Tables[1];
            if (ds.Tables[1].Rows.Count > 0)
            {
                bar_chart(ds.Tables[1]);
            }
            pop_cards.ClearSelection();
            receipt_view.ClearSelection();
        }

        private void receipt_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                string transaction_id = receipt_view.Rows[e.RowIndex].Cells[1].Value.ToString();
                load_receiptInfo(transaction_id);
                tabControl1.SelectedIndex = 1;
            }
        }

        private void pie_chart(DataTable dt)
        {
            double[] y = new double[dt.Rows.Count];
            for (int count = 0; count < dt.Rows.Count; count++)
            {
                y[count] = Math.Round(Convert.ToDouble(dt.Rows[count]["Unit Sold"]), 2);
            }
            var pie = cardPlot.Plot.AddPie(y);
            pie.Explode = true;
            pie.ShowValues = true;
            cardPlot.Refresh();
        }

        private void bar_chart(DataTable dt)
        {
            List<ScottPlot.Plottable.Bar> bars = new();
            int[] y = new int[dt.Rows.Count];
            string[] x = new string[dt.Rows.Count];
            string[] x_labels = new string[dt.Rows.Count];
            double[] positions = new double[dt.Rows.Count];
            for (int count = 0; count < dt.Rows.Count; count++)
            {
                int value = Convert.ToInt32(dt.Rows[count]["Unit Sold"]);
                string card = dt.Rows[count]["Card Name"].ToString();
                x_labels[count] = card.Split(' ')[0];
                positions[count] = count;
                ScottPlot.Plottable.Bar b = new()
                {
                    Value = value,
                    Position = count,
                    FillColor = ScottPlot.Palette.Category10.GetColor(count),
                    Label = value.ToString(),
                    LineWidth = 2,
                };
                bars.Add(b);
                pop_cards.Rows[count].DefaultCellStyle.BackColor = ScottPlot.Palette.Category10.GetColor(count);
            }
            var bar = cardPlot.Plot;
            bar.AddBarSeries(bars);
            bar.Legend(location: Alignment.UpperRight);
            bar.SetAxisLimitsY(0, Convert.ToInt32(dt.Rows[0]["Unit Sold"]) + 2);
            bar.YAxis.AxisTicks.MajorLineWidth = 2;
            bar.YAxis.AxisTicks.MinorLineWidth = 1;
            bar.XTicks(positions, x_labels);
            cardPlot.Refresh();
        }

        //-------------------------------------------------------------------Receipt Info Tab------------------------------------------------------------------------------
        public void load_receiptInfo(string transaction_id)
        {
            receipt_info.DataSource = null;
            DataTable dt = new DataTable();
            string query = "Select C.image, C.card_name as 'Card Name', R.set_code as 'Set Code', R.rarity as 'Rarity', R.quantity as Qty, R.price as Price from " +
                "(Select card_id, set_code, rarity, quantity, price from dbo.ReceiptInfo " +
                    $"where user_id = '{Global.uid}' and transaction_id = {transaction_id}) R inner join dbo.YGOCardsInfo as C on C.card_id = R.card_id";

            dt = db.Select(query);
            dt.Columns.Add("Card Image", Type.GetType("System.Byte[]")); //Thumbnail
            foreach (DataRow row in dt.Rows)
            {
                String image_thumbnail = Global.path + @"\Card_Thumbnails\" + row["Image"].ToString();
                try
                {
                    row["Card Image"] = File.ReadAllBytes(image_thumbnail);
                }
                catch
                {
                    image_thumbnail = Global.path + @"\Card_Thumbnails\21727231.jpg";
                    row["Card Image"] = File.ReadAllBytes(image_thumbnail);
                }
            }
            receipt_info.DataSource = dt;
            receipt_info.ClearSelection();
            receipt_info.Columns[0].Visible = false;
            receipt_info.Columns[5].DefaultCellStyle.Format = "$0.00##";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (start_date.Value <= end_date.Value)
            {
                load_table();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
    }
}
