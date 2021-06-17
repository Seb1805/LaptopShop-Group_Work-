using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Models
{
    public class PortConnection
    {
        public int PortConnectionId { get; set; }
        public int PortId { get; set; }
        public int Amount { get; set; }
        public int ProductId { get; set; }

        public virtual Port Port { get; set; }
        public virtual Product Product { get; set; }
    }
}
