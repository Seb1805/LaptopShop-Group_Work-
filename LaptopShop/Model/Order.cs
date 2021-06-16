using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LaptopShop.Model
{
    class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int AddressId { get; set; }

        public override string ToString()
        {
            return $"OrderId: {OrderId}\nCustomerId: {CustomerId}\nAddressId: {AddressId}";
        }
    }
}
