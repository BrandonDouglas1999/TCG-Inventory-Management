using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryApp.API_Model;
using InventoryApp.Helpers;
using System.Net.Http;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace InventoryApp.Processors
{
    public class CardProcessor
    {
        //Get a cards information using YGO Pro Deck API, will return multiple version
        public static async Task<YGOProCard> LoadProData(int option, string cardName = "")
        {
            string url = "";
            if (!String.IsNullOrEmpty(cardName))
            {
                switch (option) {
                    case 0:
                        url = $"https://db.ygoprodeck.com/api/v7/cardinfo.php?name={cardName}";
                        break;
                    case 1:
                        url = $"https://db.ygoprodeck.com/api/v7/cardinfo.php?id={cardName}";
                        break;
                    case 2:
                        url = $"https://db.ygoprodeck.com/api/v7/cardinfo.php?cardset={cardName}";
                        break;
                    default:
                        YGOProCard card = new YGOProCard();
                        return card;
                }
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
                    YGOProCard card = new YGOProCard();
                    return card;
                }
            }
        }
    }
}
