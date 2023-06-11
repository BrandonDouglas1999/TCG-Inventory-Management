using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace InventoryApp.Helpers
{
    public static class APIHelper
    {
        //open a tcp ip port, persistent connection, for multiple request until the user done. 
        //think of it as a browser for the application, to get data/information from
        public static HttpClient APIClient { get; set; } = new HttpClient();
        public static void InitializeClient()
        {
            APIClient = new HttpClient();

            //add a header to request for data with type json
            APIClient.DefaultRequestHeaders.Accept.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
