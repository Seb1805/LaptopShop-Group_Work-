using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LaptopShop_MVC.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int AddressId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Address Address { get; set; }

        public virtual ICollection<Orderline> Orderlines { get; set; }

        public override string ToString()
        {
            return $"OrderId: {OrderId}\nCustomerId: {CustomerId}\nAddressId: {AddressId}";
        }
    }
}
