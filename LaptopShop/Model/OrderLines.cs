using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Model
{
    class OrderLines
    {
        public int OrderLineId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}
