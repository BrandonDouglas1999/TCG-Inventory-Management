using InventoryApp.API_Model;
using InventoryApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Processors
{
    internal class ShoppingCartProcessor
    {
        public async Task<Token> GetConnectionToken()
        {
            //Curl to C# conversion from https://curl.olsh.me/
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://top-deck-inventory.commercelayer.io/oauth/token"))
                {
                    request.Headers.TryAddWithoutValidation("Accept", "application/json");

                    request.Content = new StringContent("{\n  \"grant_type\": \"client_credentials\",\n  \"client_id\": \"2KndBevzpWtkYOc9t_ylX5IUJylfexMSxw5T-rYDYS0\",\n  \"client_secret\": \"2mOrfU8AyJKWQVACVNTrl7gebHc_z0w_08MEEOHOptc\"\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                    if (response.IsSuccessStatusCode)
                    {

                        Token access_token = await response.Content.ReadAsAsync<Token>();
                        string bbbb = access_token.access_token;
                        return access_token;
                    }
                    else
                    {
                        //return null token
                        Token access_token = new Token();
                        return access_token;
                    }

                }
            }
        }
        //Will create a new shopping cart for a client
        public async Task<ShoppingCart> CreateShoppingCart(string access_token)
        {
            //Curl to C# conversion from https://curl.olsh.me/
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://yourdomain.commercelayer.io/api/orders"))
                {
                    request.Headers.TryAddWithoutValidation("Accept", "application/vnd.api+json");
                    request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + access_token);

                    request.Content = new StringContent("{\n  \"data\": {\n    \"type\": \"orders\"\n    }\n},\n    \"relationships\": {\n      \"market\": {\n        \"data\": {\n          \"type\": \"markets\",\n          \"id\": \"vlzmJheBvg\"\n        }\n      }\n    }\n  }\n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/vnd.api+json"); ;

                    var response = await httpClient.SendAsync(request);
                    if (response.IsSuccessStatusCode)
                    {

                        ShoppingCart cart = await response.Content.ReadAsAsync<ShoppingCart>();
                        return cart;
                    }
                    else
                    {
                        //return null shopping cart model
                        ShoppingCart cart = new ShoppingCart();
                        return cart;
                    }
                }
            }
        }

        //Get a shopping cart from CommerceLayer API
        public static async Task<ShoppingCart> LoadShoppingCart(string orderNumber)
        {
            //order number unique to each customer
            string url = "https://top-deck-inventory.commercelayer.io/api/orders/" + orderNumber + "?include=line_items&fields[orders]=skus_count,line_items&fields[line_items]=name,quantity";

            //Curl to C# conversion from https://curl.olsh.me/
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"),url))
                {
                    request.Headers.TryAddWithoutValidation("Accept", "application/vnd.api+json");
                    request.Headers.TryAddWithoutValidation("Authorization", "sXaW-zbM4EUe05sctf_Nr-2dHMXGMWw4zgOxutHKPn4");

                    var response = await httpClient.SendAsync(request);
                    if (response.IsSuccessStatusCode)
                    {

                        ShoppingCart cart = await response.Content.ReadAsAsync<ShoppingCart>();
                        return cart;
                    }
                    else
                    {
                        //return null shopping cart model
                        ShoppingCart cart = new ShoppingCart();
                        return cart;
                    }
                }
            }
        }

        //Will create a new SKU for given card
        public static async Task<SKU> CreateSKU(int card_id, string set_code, string rarity)
        {
            string sku_name = card_id.ToString() + "," + set_code + "," + rarity;
            string data = "{\n  \"data\": {\n    \"type\": \"skus\",\n    \"attributes\": {\n      \"name\": \"" + sku_name + "\"\n    },\n    \"relationships\": {\n      \"shipping_category\": {\n        \"data\": {\n          \"type\": \"shipping_categories\",\n          \"id\": \"VNoxGForxw\"\n        }\n      }\n    }\n  }\n}";
            //Curl to C# conversion from https://curl.olsh.me/
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://top-deck-inventory.commercelayer.io/api/skus"))
                {
                    request.Headers.TryAddWithoutValidation("Accept", "application/vnd.api+json");
                    request.Headers.TryAddWithoutValidation("Authorization", "sXaW-zbM4EUe05sctf_Nr-2dHMXGMWw4zgOxutHKPn4");

                    request.Content = new StringContent(data);
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/vnd.api+json");

                    var response = await httpClient.SendAsync(request);
                    if (response.IsSuccessStatusCode)
                    {

                        SKU new_sku = await response.Content.ReadAsAsync<SKU>();
                        return new_sku;
                    }
                    else
                    {
                        //return null SKU model
                        SKU new_sku = new SKU();
                        return new_sku;
                    }
                }
            }
        }

        //Will add SKU to given cart
        public static async Task<LineItem> AddToCart(int quantity, string SKU, string orderNumber, string access_token)
        {
            string data = "\"{\\n    \\\"data\\\": {\\n      \\\"type\\\": \\\"line_items\\\",\\n      \\\"attributes\\\": {\\n        \\\"quantity\\\": ";
            data += quantity.ToString() + "\n      },\n      \"relationships\": {\n        \"order\": {\n          \"data\": {\n            \"type\": \"orders\",\n            \"id\": \"";
            data += orderNumber + "\"\n          }\n        },\n        \"item\": {\n          \"data\": {\n            \"type\": \"skus\",\n            \"id\": \"";
            data += SKU + "\"\n          }\n        }\n      }\n    }\n  }";
            //Curl to C# conversion from https://curl.olsh.me/
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://top-deck-inventory.commercelayer.io/api/line_items"))
                {
                    request.Headers.TryAddWithoutValidation("Accept", "application/vnd.api+json");
                    request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + access_token);

                    request.Content = new StringContent(data);
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/vnd.api+json");

                    var response = await httpClient.SendAsync(request);
                    if (response.IsSuccessStatusCode)
                    {

                        LineItem new_line_item = await response.Content.ReadAsAsync<LineItem>();
                        return new_line_item;
                    }
                    else
                    {
                        LineItem new_line_item = new LineItem();
                        return new_line_item;
                    }
                }
            }
        }
    }
}
