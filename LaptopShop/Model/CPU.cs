using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Model
{
    class CPU
    {
        public int CPUId { get; set; }
        public int Generation { get; set; }
        public string modelNumber{ get; set; }
        public float ghz { get; set; }
        public int brandId { get; set; }
    }
}
