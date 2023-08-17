using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using InventoryApp.Helpers;
using InventoryApp.API_Model;

namespace InventoryApp.Processors
{
    public class ConversionRate
    {
        public static async Task<ConversionModel> LoadRate()
        {
            string url = $"https://v6.exchangerate-api.com/v6/b9a3424b87e292d7bc95bf3e/pair/CAD/USD/1"; //need to save API key elsewhere
            using (HttpResponseMessage response = await APIHelper.APIClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    SQLHelper db = new SQLHelper();
                    ConversionModel rate = await response.Content.ReadAsAsync<ConversionModel>();
                    rate.db_rate = db.InsertRate(rate.conversion_rate);
                    return rate;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
