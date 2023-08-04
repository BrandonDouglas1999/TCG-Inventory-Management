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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Web;
using System.Collections;

namespace InventoryApp.Helpers
{

    class SQLHelper
    {
        //change this to your server name and the path for the image folder
        //public static readonly String connectionString = "Server=localhost\\SQLEXPRESS01; Database=TCG_Inventory3; Trusted_Connection=yes";
        public static readonly String connectionString = "Server = localhost\\SQLEXPRESS01; Database = TCG_Inventory3; Trusted_Connection = yes";
        public static readonly String path = @"C:\Users\Brandon\Desktop\TCG-Inventory-Management-Application-main\InventoryApp\CardImage"; //change this to your!!!


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
        public DataTable Select(string query)
        {
            SqlCommand myCommand;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                try
                {
                    myConnection.Open();
                    myCommand = new SqlCommand(query, myConnection); //preparing the query string
                    myCommand = new SqlCommand(query, myConnection);
                    adapter = new SqlDataAdapter(query, myConnection);
                    adapter.Fill(dt);
                    myConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dt = null;
                }
                finally {myConnection.Close(); }
            }
            return dt;
        }

        public int LoadCatalog(DataTable catalog, int scrollVal, string filters) /*Paging the result, passing in scroll value to indicate the start point*/
        {
            SqlCommand myCommand;
            filters = null; //Comment out to test filter string
            int total;
            int end = 0;
            string num = "SELECT COUNT(store_id) as num from YGOStorePrice where store_id = 1";
            string query = "select CM.image, S.card_id, CM.card_name, S.set_code, CM.set_name, S.rarity,  CM.market_price, S.store_price, S.copies from YGOStorePrice as S inner join YGOCurrentMarket as CM on S.card_id = " +
                "CM.card_id and S.set_code = CM.set_code and S.rarity = CM.rarity where S.store_id = 1";
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
                myConnection.Close();
            }
            return end;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------Card Related-------------------------------------------------------------
        public int InsertCard(string uid, string cid, string set_code, string cname, string ctype, string crace, string set_name, string rarity, string m_price, string copies, string image, string s_price) //return status code 
        {
            SqlCommand myCommand;
            SqlDataReader myReader;
            int status;
            cname = cname.Replace("'", "''");
            set_name = set_name.Replace("'", "''");
            String image_file = cid + ".jpg";
            String query = "Execute AddCard @UID, @CID, @Set_Code, @Rarity, @Game, @C_name, @C_type, @C_race, @Set_name, @M_price, @S_price, @Copies, @image, @Status output";
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@UID", SqlDbType.VarChar, 64).Value = uid; 
                myCommand.Parameters.Add("@CID", SqlDbType.Int).Value = cid;
                myCommand.Parameters.Add("@Set_Code", SqlDbType.VarChar, 50).Value = set_code;
                myCommand.Parameters.Add("@Rarity", SqlDbType.VarChar, 20).Value = rarity;
                myCommand.Parameters.Add("@Game", SqlDbType.VarChar, 20).Value = "YGO";
                myCommand.Parameters.Add("@C_name", SqlDbType.VarChar, -1).Value = cname;
                myCommand.Parameters.Add("@C_type", SqlDbType.VarChar, -1).Value = ctype;
                myCommand.Parameters.Add("@C_race", SqlDbType.VarChar, -1).Value = crace;
                myCommand.Parameters.Add("@Set_name", SqlDbType.VarChar, -1).Value = set_name;
                myCommand.Parameters.Add("@M_price", SqlDbType.Money).Value = m_price;
                myCommand.Parameters.Add("@S_price", SqlDbType.Money).Value = s_price;
                myCommand.Parameters.Add("@Copies", SqlDbType.Int).Value = copies;
                myCommand.Parameters.Add("@Image", SqlDbType.VarChar, -1).Value = image_file;
                myCommand.Parameters.Add("@Status", SqlDbType.Int).Direction = ParameterDirection.Output;
                try
                {
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                    status = (int)myCommand.Parameters["@Status"].Value;
                    SaveImage(image, cid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    status = -1; //db connection error
                }
                finally 
                { 
                     myConnection.Close(); 
                }
            }
            return status;
        }

        public int DeleteCard(string uid, string cid, string setcode, string rarity)
        {
            SqlCommand myCommand;
            SqlDataReader myReader;
            int status;
            String query = "Exec deleteCard @UID, @CID, @Setcode, @Rarity, @stat output";
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                /* This way will prevent sql injection attack*/
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@UID", SqlDbType.VarChar, 64).Value = uid;
                myCommand.Parameters.Add("@CID", SqlDbType.Int).Value = cid;
                myCommand.Parameters.Add("@Setcode", SqlDbType.VarChar, 20).Value = setcode;
                myCommand.Parameters.Add("@Rarity", SqlDbType.VarChar, 20).Value = rarity;
                myCommand.Parameters.Add("@stat", SqlDbType.Int).Direction = ParameterDirection.Output;
                try
                {
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                    status = (int)myCommand.Parameters["@stat"].Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    status = -1;
                    
                }
                finally 
                { 
                    myConnection.Close(); 
                }
            }
            return status;
        }

        private async void SaveImage(string url, string card_ID)
        {
            String file_name = card_ID + ".jpg";
            String file_path = path + @"\" + file_name;
            var uri = new Uri(url);
            if (File.Exists(file_path)) //check if file exist
            {
                return;
            }
            else
            {
                HttpClient client = new HttpClient();
                    using (var stream = await client.GetStreamAsync(uri))
                    {
                        using (var file_stream = new FileStream(file_path, FileMode.CreateNew))
                        {
                            await stream.CopyToAsync(file_stream);
                        }
                    }
                create_thumbnail(file_name);
            }
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
        
        public DataTable GetCardMarket(string query)
        {
            DataTable ds = new DataTable();
            SqlDataAdapter adapter;
            SqlCommand myCommand;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                try 
                {
                    myConnection.Open();
                    myCommand = new SqlCommand(query, myConnection);
                    adapter = new SqlDataAdapter(query, myConnection);
                    adapter.Fill(ds); 
                }
                catch (Exception ex)
                {
                    ds = null;
                }   
                finally { myConnection.Close(); }
            }
            return ds;
        }

        public DataTable CPriceHistory(string cid, string setcode, string rarity, string startdate, string enddate)
        {
            DataTable dt = new DataTable();
            string query = "Exec CardPriceHistory @CID, @SC, @R, @Start, @End";
            SqlCommand myCommand;
            SqlDataAdapter myAdapter = new SqlDataAdapter();
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@CID", SqlDbType.Int).Value= cid;
                myCommand.Parameters.Add("@SC", SqlDbType.VarChar, 50).Value = setcode;
                myCommand.Parameters.Add("@R", SqlDbType.VarChar, 50).Value = rarity;
                myCommand.Parameters.Add("@Start", SqlDbType.Date).Value= startdate;
                myCommand.Parameters.Add("@End", SqlDbType.Date).Value = enddate;
                try
                {
                    myConnection.Open();
                    myAdapter.SelectCommand = myCommand;
                    myAdapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dt = null;
                }
                finally { myConnection.Close(); }
            }
            return dt;
        }

        public int UpdateInventory(string uid, string cid, string setcode, string rarity, string s_price, string copies)
        {
            int status;
            string query = "Exec UpdateInventory @UID, @CID, @Set_code, @Rarity, @S_price, @Copies, @Status output";
            SqlCommand myCommand;
            SqlDataReader myReader;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@UID", SqlDbType.VarChar, -1).Value = uid;
                myCommand.Parameters.Add("@CID", SqlDbType.Int).Value = cid;
                myCommand.Parameters.Add("@Set_code", SqlDbType.VarChar, 50).Value = setcode;
                myCommand.Parameters.Add("@Rarity", SqlDbType.VarChar, 50).Value = rarity;
                myCommand.Parameters.Add("@S_price", SqlDbType.Money).Value = s_price;
                myCommand.Parameters.Add("@Copies", SqlDbType.Int).Value = copies;
                myCommand.Parameters.Add("@Status", SqlDbType.Int).Direction = ParameterDirection.Output;
                try
                {
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                    status = (int)myCommand.Parameters["@Status"].Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    status = -1;
                }
                finally { myConnection.Close(); }
            }
            return status;
        }

        public (string start, string end) DateRange(string cid, string setcode, string rarity)
        {
            string query = "Exec DateRange @CID, @SC, @R, @Start output, @End output";
            string start = null;
            string end = null;
            SqlCommand myCommand;
            SqlDataReader myReader;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@CID", SqlDbType.Int).Value = cid;
                myCommand.Parameters.Add("@SC", SqlDbType.VarChar, 50).Value = setcode;
                myCommand.Parameters.Add("@R", SqlDbType.VarChar, 50).Value = rarity;
                myCommand.Parameters.Add("@Start", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                myCommand.Parameters.Add("@End", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                try
                {
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                    start = myCommand.Parameters["@Start"].Value.ToString();
                    end = myCommand.Parameters["@End"].Value.ToString();
                    myConnection.Close();
                    return (start, end);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    myConnection.Close();
                    return (start, end);
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

        //-------------------------------------------------------------User Login----------------------------------------------------------------------

        public string ExternalLogin(string GID, string auth_type)
        {
            SqlCommand myCommand;
            SqlDataReader myReader;
            int status;
            string UID;
            string query = "Exec ExternalLogin @GID, @auth_type, @status output, @UID output";
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand= new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@GID", SqlDbType.VarChar, 64).Value = GID;
                myCommand.Parameters.Add("@auth_type", SqlDbType.VarChar, 50).Value = auth_type;
                myCommand.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                myCommand.Parameters.Add("@UID", SqlDbType.VarChar, 64).Direction = ParameterDirection.Output;
                try
                {
                    //status should be 1 if success
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                    status = (int)myCommand.Parameters["@status"].Value;
                    UID = myCommand.Parameters["@UID"].Value.ToString();
                }
                catch (Exception ex)
                {
                    status = 0;
                    UID = null;
                }
                finally 
                { 
                    myConnection.Close(); 
                }
            }
            return UID;
        }

        public int CreateExternalAccount(string GID, string auth_type, string email, string username)
        {
            SqlCommand myCommand;
            SqlDataReader myReader;
            int status;
            string query = "Exec CreateExternalLogin @GID, @auth_type, @Email, @Username, @status output";
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@GID", SqlDbType.VarChar, 64).Value = GID;
                myCommand.Parameters.Add("@auth_type", SqlDbType.VarChar, 50).Value = auth_type;
                myCommand.Parameters.Add("@Email", SqlDbType.VarChar, -1).Value = auth_type;
                myCommand.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = auth_type;
                myCommand.Parameters.Add("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
                try
                {
                    /*should be 1 if successfully create an account*/
                    myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                    status = (int)myCommand.Parameters["@status"].Value;
                }
                catch
                {
                    status = 0;
                }
                finally { myConnection.Close(); }
            }
            return status;
        }

        public string GetCartID(string shop_id)
        {
            SqlCommand myCommand;
            SqlDataReader myReader;
            string cart_id = "";
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myConnection.Open();
                String query = "Select shopping_cart_id from StoreLogin where user_id =" + shop_id;
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@cartID", System.Data.SqlDbType.VarChar, 50);
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows)
                {
                    cart_id = Convert.ToString(myReader.GetChar(0));
                }
            }
            return cart_id;
        }
    }
}
