using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LaptopShop_MVC.Models
{
    public class Speaker
    {
        [Key]
        public int SpeakerId { get; set; }
        public string Description { get; set; }


        public virtual IEnumerable<Product> Products { get; set; }
    }
}
