using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LaptopShop_MVC.Models
{
    class Charger
    {
        [Key]
        public int ChargerId { get; set; }
        public string Voltage { get; set; }
        public string Current { get; set; }
        public string Adaptor { get; set; }
        public bool Ground { get; set; }
    }
}
