using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    interface IBattery
    {
        public int BatteryId { get; set; }
        public int ChargerId { get; set; }
        public int Capacity { get; set; }
        public string Type { get; set; }
    }
}
