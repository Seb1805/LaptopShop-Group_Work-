using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Models
{
    public class RAM
    {
        public int RamId { get; set; }
        public int Capacity { get; set; }
        public int Mhz { get; set; }
        public int BrandId { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
