using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.API_Model
{
    public class ConversionModel
    {
        public string result { get; set; }
        public string time_net_update_utc { get; set; } //could use this info
        public double conversion_rate { get; set; }
    }
}
