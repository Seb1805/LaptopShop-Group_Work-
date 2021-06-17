using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Models
{
    public class GPU
    {
        public int GpuId { get; set; }
        public string Description { get; set; }
        public int Vram { get; set; }
        public int BrandId { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
