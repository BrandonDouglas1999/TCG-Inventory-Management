using InventoryApp.Helpers;
using InventoryApp.Processors;
using InventoryApp.API_Model;
using ScottPlot;
using ScottPlot.Plottable;
using System;
using System.Collections;
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
    public partial class ManuallyUpdateDB : Form
    {
        /*
            Use datagridview to show all the card that change it price, then user can select a card on the datagrid view then the chart will show the market trend of that card
        */
        SQLHelper db = new SQLHelper();

        public ManuallyUpdateDB()
        {
            InitializeComponent();
            update_db();
            
        }

        public async void update_db()
        {
            int result = await update_cards();
            if (result == 1)
            {
                this.Close();
            }
            else
            {
                label1.Text = "Error";
            }
        }

        private async Task<int> update_cards()
        {
            try
            {
                DataTable set_info = new DataTable(); //number of cards in each set
                DateTime date = DateTime.Now;
                string dateFormat = date.ToString("yyyy-MM-dd");
                String cards_set = "select distinct card_id, set_code, rarity from dbo.YGOMarketPrice";
                set_info = db.Select(cards_set);
                set_info.Columns.Add("update_date", typeof(string)).SetOrdinal(0); //Add update_date column to the front
                set_info.Columns.Add("current_price", typeof(string));
                set_info.Columns.Add("set_name", typeof(string));
                foreach (DataRow dr in set_info.Rows)
                {
                    dr["update_date"] = dateFormat;
                }
                foreach (DataRow dr in set_info.Rows)
                {
                    string card_id = dr["card_id"].ToString();
                    var api_card = await CardProcessor.LoadProDataID(card_id);
                    if (api_card != null)
                    {
                        foreach (var card in api_card.data[0].card_sets)
                        {
                            if (card.set_code == dr["set_code"].ToString() && card.set_rarity_code == dr["rarity"].ToString())
                            {
                                double new_price = Convert.ToDouble(card.set_price);
                                dr["current_price"] = Math.Round(new_price, 2).ToString(); //change card price in datatable
                                dr["set_name"] = card.set_name;
                            }
                        }
                    }
                }
                db.UpdateTable(set_info);
                return 1;
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
                return -1; }
        }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
