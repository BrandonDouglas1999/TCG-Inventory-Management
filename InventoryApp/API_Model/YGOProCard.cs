using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.API_Model
{
    public class YGOProCard
    {
        public card[] data { get; set; }
    }

    public class card
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string race { get; set; }
        public Card_Sets[] card_sets { get; set; }
        public Card_Images[] card_images { get; set; }
        public Card_Prices[] card_prices { get; set; }
    }
    public class Card_Sets
    {
        public string set_name { get; set; }
        public string set_code { get; set; }
        public string set_rarity { get; set; }
        public string set_rarity_code { get; set; }
        public string set_price { get; set; }
    }

    public class Card_Images
    {
        //public int id { get; set; }
        public string image_url { get; set; }
        //public string image_url_small { get; set; }
    }

    public class Card_Prices
    {
        public string tcgplayer_price { get; set; }
    }
}
