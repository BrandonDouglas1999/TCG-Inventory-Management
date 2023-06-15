using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventoryApp.Helpers
{

    class SQLHelper
    {
        //change this to your server name
        public static readonly String connectionString = "Server = JACKACE-PCMARK1\\MSSQLSERVER01; Database = TCG_Inventory; Trusted_Connection = yes";

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
                myConnection.Close(); //close connection for 
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

        public int InsertCard(string query) //return status code 
        {
            SqlConnection myConnection = new SqlConnection(connectionString);
            SqlCommand myCommand;
            SqlDataReader myReader;
            try
            {
                myConnection.Open();
                myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.Add("@stat", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;
                myReader = myCommand.ExecuteReader();
                int status = (int)myCommand.Parameters["@stat"].Value;
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

    }
}
