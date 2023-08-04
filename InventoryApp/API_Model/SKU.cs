using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.API_Model
{
    public class SKU
    {
        public Data[] data { get; set; }
    }

    public class Data
    {
        public string id { get; set; }

    }
}
