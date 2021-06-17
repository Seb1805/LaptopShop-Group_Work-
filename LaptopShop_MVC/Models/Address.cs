using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LaptopShop_MVC.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public int PostalCode { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        [ForeignKey("PostalCode")]
        public virtual PostalCode postalCode { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; }

    }
}
