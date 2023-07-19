using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    internal class Card
    {
        public int card_id { get; }
        public int set_code { get; }
        public string rarity { get; }

        public Card(int card_id, int set_code, string rarity)
        {
            this.card_id = card_id;
            this.set_code = set_code;
            this.rarity = rarity;
        }
    }
}
