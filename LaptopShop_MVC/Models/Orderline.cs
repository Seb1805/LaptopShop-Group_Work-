using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Models
{
    class Orderline
    {
        public int OrderLineId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public override string ToString()
        {
            return $"OrderLineId: {OrderLineId}\nOrderId: {OrderId}\nProductId: {ProductId}";
        }
    }
}
