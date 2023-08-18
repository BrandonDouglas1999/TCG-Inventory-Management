using InventoryApp.Helpers;
using InventoryApp.Processors;
using System.Data;
using System.Diagnostics;

namespace InventoryApp
{

    class Global
    {
        public static string uid;
        public static string path = @"..\..\..\CardImage";

        //public static readonly String connectionString = "Server=localhost\\SQLEXPRESS01; Database=TCG_Inventory3; Trusted_Connection=yes";
        //public static readonly String connectionString = "Server = DESKTOP-NDGJ14Q\\SQLEXPRESS; Database = TCG_Inventory3; Trusted_Connection = yes";
        public static readonly String connectionString = "Server = JACKACE-PCMARK1\\MSSQLSERVER01; Database = TCG_Inventory3; Trusted_Connection = yes";
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            
            ApplicationConfiguration.Initialize();
            SQLHelper db = new SQLHelper();
            if (db.CheckIfUpdated() == 0)
            {
                Application.Run(new ManuallyUpdateDB());
            }
            Login login_screen = new Login();
            Main main = new Main();
            Application.Run(login_screen);

            while (true)
            {
                if (login_screen.authenticated)
                {
                    main = new Main();
                    main.user = login_screen.logged_user;
                    main.uid = login_screen.uid;
                    Global.uid = login_screen.uid;
                    Application.Run(main);
                }

                if (main.logout_selected)
                {
                    // Have to re-establish a new object after its closed.
                    login_screen = new Login();
                    Application.Run(login_screen);
                    main.logout_selected = false;
                }
                else
                {
                    break;
                }


            }
            


        }
        private static async Task<int> update_cards(SQLHelper db)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
    }
}