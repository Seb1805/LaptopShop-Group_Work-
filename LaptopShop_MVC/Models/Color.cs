using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Models
{
    public class Color
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }

        public virtual IEnumerable<Product> Products { get; set; }
    }
}
