using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Model
{
    class CPU
    {
        public int CPUId { get; set; }
        public int Generation { get; set; }
        public string ModelNumber{ get; set; }
        public float Ghz { get; set; }
        public int BrandId { get; set; }
    }
}
