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
                        url = $"https://db.ygoprodeck.com/api/v7/cardinfo.php?fname={cardName}&tcgplayer_data";
                        break;
                    case 1:
                        url = $"https://db.ygoprodeck.com/api/v7/cardinfo.php?id={cardName}&tcgplayer_data";
                        break;
                    case 2:
                        url = $"https://db.ygoprodeck.com/api/v7/cardinfo.php?cardset={cardName}&tcgplayer_data";
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

        public static async Task<YGOProCard> GetImage(string cardName = "")
        {
           
            string url = $"https://db.ygoprodeck.com/api/v7/cardinfo.php?id={cardName}&tcgplayer_data";
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

        private async void SaveImage(string card_ID)
        {
            YGOProCard card = await GetImage(card_ID);
            string url = card.data[0].card_images[0].image_url;
            String file_name = card_ID + ".jpg";
            String file_path = Global.path + @"\" + file_name;
            String save_path = Global.path + @"\Card_Thumbnails\" + file_name;
            var uri = new Uri(url);
            if (File.Exists(save_path)) //check if file exist
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
            DirectoryInfo d = new DirectoryInfo(Global.path);
            string save_path = Global.path + @"\Card_Thumbnails\";
            Image img = new Bitmap(Global.path + @"\" + file_name);
            Image myThumbnail = img.GetThumbnailImage(105, 153, () => false, IntPtr.Zero);
            myThumbnail.Save(save_path + file_name);
        }
    }
}
