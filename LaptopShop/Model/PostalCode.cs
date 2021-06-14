using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LaptopShop.Model
{
    class PostalCode
    {
        [Key]
        public int Postal_Code { get; set; }
        public string City { get; set; }
    }
}
