using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.API_Model
{
    public class ShoppingCart
    {
        public order[] data { get; set; }
        public line_items[] included { get; set; }
    }

    public class order
    {
        public int id { get; set; }
        public string type { get; set; }
        public order_attributes[] attributes { get; set; }

    }

    public class order_attributes
    {
        public string skus_count { get; set; }
    }

    public class line_items
    {
        public int id { get; set; }
        public string type { get; set; }
        public line_item_attributes[] attributes { get; set; }
    }

    public class line_item_attributes
    {
        public string name { get; set; }
        public int quantity { get; set; }
    }
}
