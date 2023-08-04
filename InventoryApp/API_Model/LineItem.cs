using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.API_Model
{
    public class LineItem
    {
        public added_to_cart[] data { get; set; }
        public Errors[] errors { get; set; }
    }

    public class added_to_cart
    {
        public string id { get; set; }
    }

    public class Errors
    {
        public string code { get; set; }
    }
}
