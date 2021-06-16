using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LaptopShop_MVC.Models
{
    class PostalCode
    {
        [Key]
        public int Postal_Code { get; set; }
        public string City { get; set; }
    }
}
