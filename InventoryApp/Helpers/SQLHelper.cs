using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using InventoryApp.Processors;
using InventoryApp.API_Model;
using System.IO;


namespace InventoryApp.Helpers
{

    class SQLHelper
    {
        //change this to your server name and the path for the image folder
        public static readonly String connectionString = "Server = JACKACE-PCMARK1\\MSSQLSERVER01; Database = TCG_Inventory; Trusted_Connection = yes";
        public String path = @"D:\Users\hang_\Documents\School\Capstone\GitHub\TCG-Inventory-Management-Application\InventoryApp\CardImage"; //change this to your!!!

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
        //---------------------------------------------------------------------------------------------------------------------------------------------

        //Card Related---------------------------------------------------------------------------------------------------------------------------------
        public int InsertCard(string cid, string set_code, string cname, string ctype, string crace, string set_name, string rarity, string price, string inv, string image, string s_price) //return status code 
        {
            SqlConnection myConnection = new SqlConnection(connectionString);
            SqlCommand myCommand;
            SqlDataReader myReader;
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

        private async void SaveImage(string url, string card_ID)
        {
            String file_name = card_ID + ".jpg";
            String file_path = path + @"\" + file_name;
            if (File.Exists(file_path)) //check if file exist
            {
                return;
            }
            var uri = new Uri(url);
            HttpClient client = new HttpClient();
            using (var stream = await client.GetStreamAsync(uri))
            {
                using (var file_stream = new FileStream(file_path, FileMode.CreateNew))
                {
                    await stream.CopyToAsync(file_stream);
                }
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
