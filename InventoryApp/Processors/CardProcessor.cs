using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryApp.API_Model;
using InventoryApp.Helpers;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace InventoryApp.Processors
{
    public class CardProcessor
    {
        //Get a single card using YGO Pro Deck API, will return multiple version
        public static async Task<YGOProCard> LoadProData(string cardName = "")
        {
            string url = "";
            if (!String.IsNullOrEmpty(cardName))
            {
                url = $"https://db.ygoprodeck.com/api/v7/cardinfo.php?name={cardName}";
            }
            else
                url = $"https://db.ygoprodeck.com/api";

            using (HttpResponseMessage response = await APIHelper.APIClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {

                    YGOProCard card = await response.Content.ReadAsAsync<YGOProCard>();
                    return card;
                }
                else
                {
                    //return null card model
                    MessageBox.Show("Error");
                    YGOProCard card = new YGOProCard();
                    return card;
                }
            }
        }
    }
}
