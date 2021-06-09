using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Model
{
    class Address
    {
        public int AddressId { get; set; }
        public int CustomerId { get; set; }
        public string Street { get; set; }
        public int PostalCode { get; set; }
    }
}
