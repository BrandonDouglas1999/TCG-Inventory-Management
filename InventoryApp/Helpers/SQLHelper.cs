using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using InventoryApp.Processors;
using InventoryApp.API_Model;
using System.IO;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Xml.Schema;

namespace InventoryApp.Helpers
{

    class SQLHelper
    {
        //change this to your server name and the path for the image folder
        //public static readonly String connectionString = "Server=localhost\\SQLEXPRESS01; Database=TCG_Inventory3; Trusted_Connection=yes";
        public static readonly String connectionString = "Server = JACKACE-PCMARK1\\MSSQLSERVER01; Database = TCG_Inventory3; Trusted_Connection = yes";
        public static readonly String path = @"D:\Users\hang_\Documents\School\Capstone\GitHub\TCG-Inventory-Management-Application\InventoryApp\CardImage"; //change this to your!!!


        //-------------------------------------------------------------------Basic Functionality-------------------------------------------------------
        /*
         This function only execute the sql query, it does not read the result from SELECT query
        */
        public void Execute(string Query)
        {
            //setting up connection with DB
            SqlConnection myConnection = new SqlConnection(connectionString);
            SqlCommand myCommand; //passing query command here
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand(Query, myConnection); //preparing the query string
                myCommand.ExecuteNonQuery();    //execute query
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myConnection.Close(); //close connection
            }
        }

        /*
         This function will return the result of a query 
        */
        public SqlDataReader Select(string Query)
        {
            SqlConnection myConnection = new SqlConnection(connectionString);
            SqlCommand myCommand;
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand(Query, myConnection); //preparing the query string
                //read database output and close connection
                return myCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }



        public int LoadCatalog(DataTable catalog, int scrollVal, string filters) /*Paging the result, passing in scroll value to indicate the start point*/
        {
            SqlCommand myCommand;
            filters = null; //Comment out to test filter string
            int total;
            int end = 0;
            string num = "SELECT COUNT(user_id) as num from YGOStorePrice where user_id = 1";
            string query = "select CM.image, S.card_id, CM.card_name, S.set_code, S.rarity,  CM.market_price, S.store_price, S.copies from YGOStorePrice as S inner join YGOCurrentMarket as CM on S.card_id = " +
                "CM.card_id and S.set_code = CM.set_code and S.rarity = CM.rarity where S.user_id = 1";
            if (filters !=  null) { query += "WHERE " + filters + " "; }
            query += " ORDER BY card_name";
            
            SqlDataAdapter pagingAdapter;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myConnection.Open();
                myCommand = new SqlCommand(num, myConnection);
                total = (int)myCommand.ExecuteScalar();
                pagingAdapter = new SqlDataAdapter(query, myConnection);
                //Check if end of database is reached
                if (scrollVal + 20 > total) 
                {
                    pagingAdapter.Fill(scrollVal, scrollVal + 20 - total, catalog);
                    end = 1;
                }
                else
                {
                    pagingAdapter.Fill(scrollVal, 20, catalog);
                }
            }
            return end;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------Card Related-------------------------------------------------------------
        public int InsertCard(string cid, string set_code, string cname, string ctype, string crace, string set_name, string rarity, string price, string inv, string image, string s_price) //return status code 
        {
            SqlConnection myConnection = new SqlConnection(connectionString);
            SqlCommand myCommand;
            SqlDataReader myReader;
            cname = cname.Replace("'", "''");
            set_name = set_name.Replace("'", "''");
            String image_file = cid + ".jpg";
            String query = String.Format("Execute AddCard {0}, '{1}',  '{2}', 'YGO','{3}', '{4}', '{5}', '{6}', {7}, {8}, '{9}', '{10}', @stat output",
                           cid, set_code, rarity, cname, ctype, crace, set_name, price, s_price, inv, image_file);
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@stat", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;
                myReader = myCommand.ExecuteReader();
                int status = (int)myCommand.Parameters["@stat"].Value;
                SaveImage(image, cid);
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myConnection.Close();
                return -1;
            }
        }

        public void DeleteCard(string cid, string setcode, string rarity)
        {
            SqlCommand myCommand;
            SqlDataReader myReader;
            String image_file = "";
            int status;
            String query = "Exec deleteCard @CID, @Setcode, @Rarity, @image output, @stat output";
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                /* This way will prevent sql injection attack*/
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@CID", SqlDbType.Int).Value = cid;
                myCommand.Parameters.Add("@Setcode", SqlDbType.VarChar, 20).Value = setcode;
                myCommand.Parameters.Add("@Rarity", SqlDbType.VarChar, 20).Value = rarity;
                myCommand.Parameters.Add("@image", SqlDbType.VarChar, -1).Direction = ParameterDirection.Output; //-1 for max
                myCommand.Parameters.Add("@stat", SqlDbType.Int).Direction = ParameterDirection.Output;
                try
                {
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                    image_file = myCommand.Parameters["@image"].Value.ToString();
                    status = (int)myCommand.Parameters["@stat"].Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    myConnection.Close();
                    return;
                }
            }
            if (status == 1) /*delete the image corresponding to the card data if it is the only one using the image file*/
            {
                DeleteImage(image_file);
            }
        }

        public DataTable GetCardMarket(string query)
        {
            DataTable ds = new DataTable();
            SqlDataAdapter adapter;
            SqlCommand myCommand;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myConnection.Open();
                myCommand = new SqlCommand(query, myConnection);
                adapter = new SqlDataAdapter(query, myConnection);
                adapter.Fill(ds);
            }
            return ds;
        }

        private async void SaveImage(string url, string card_ID)
        {
            String file_name = card_ID + ".jpg";
            String file_path = path + @"\" + file_name;
            var uri = new Uri(url);
            HttpClient client = new HttpClient();
            using (var stream = await client.GetStreamAsync(uri))
            {
                if (File.Exists(file_path)) //check if file exist
                {
                    return;
                }
                using (var file_stream = new FileStream(file_path, FileMode.CreateNew))
                {
                    await stream.CopyToAsync(file_stream);
                }
            }
            create_thumbnail(file_name);
        }

        /*Create thumbnail from image*/
        private void create_thumbnail(String file_name)
        {
            DirectoryInfo d = new DirectoryInfo(path);
            string save_path = path + @"\Card_Thumbnails\";
            Image img = new Bitmap(path + @"\" + file_name);
            Image myThumbnail = img.GetThumbnailImage(105, 153, () => false, IntPtr.Zero);
            myThumbnail.Save(save_path + file_name);
        }

        /*Delete card image and thumbnail*/
        private void DeleteImage(string image_file)
        {
            String file_path = path + @"\" + image_file;
            String thumbnail = path + @"\Card_Thumbnails\" + image_file;
            if (File.Exists(file_path))
            {
                MessageBox.Show(file_path);
                File.Delete(file_path);
            }
            if (File.Exists(thumbnail)) 
            {
                File.Delete(thumbnail);
            }
        }



        //---------------------------------------------------------------------------------------------------------------------------------------------

        //-----------------------------------------------------------------Conversion Rate Related-----------------------------------------------------
        /*
         Check current rate from database with api rate
        */
        public double GetRate()
        {
            SqlCommand myCommand;
            SqlDataReader myReader;
            double rate = 0;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myConnection.Open();
                String query = "Select Rate from ConversionRate where Date = (Select MAX(Date) as date from ConversionRate)";
                myCommand= new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@rate", System.Data.SqlDbType.Float).Direction= System.Data.ParameterDirection.Output;
                myReader= myCommand.ExecuteReader();
                if (myReader.HasRows) 
                {
                    rate = myReader.GetDouble(0);
                }
            }
            return rate; 
        }

        /*Insert and return the previously latest or latest rate in the database*/
        public double InsertRate(double rate)
        {
            SqlCommand myCommand;
            SqlDataReader myReader;
            double db_rate = 0;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myConnection.Open();
                String query = String.Format("Exec InsertRate {0}, @rate output", rate);
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@rate", System.Data.SqlDbType.Float).Direction = System.Data.ParameterDirection.Output;
                myReader = myCommand.ExecuteReader();
                db_rate = (double)myCommand.Parameters["@rate"].Value;
            }
            return db_rate;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------
    }
}
