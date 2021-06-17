using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Models
{
    public class Wifi
    {
        public int wifiId { get; set; }
        public string description { get; set; }


        public virtual IEnumerable<Product> Products { get; set; }
    }
}
