using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Model
{
    class Charger
    {
        public int ChargerId { get; set; }
        public string Voltage { get; set; }
        public string Current { get; set; }
        public string Adaptor { get; set; }
        public bool Ground { get; set; }
    }
}
