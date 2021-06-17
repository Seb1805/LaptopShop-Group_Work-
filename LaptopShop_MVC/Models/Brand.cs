using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
