using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LaptopShop_MVC.Models
{
    class Port
    {
        [Key]
        public int PortId { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
    }
}
