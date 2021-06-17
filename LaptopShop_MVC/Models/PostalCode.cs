using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LaptopShop_MVC.Models
{
    public class PostalCode
    {
        [Key]
        [Column("PostalCode")]
        public int Postal_Code { get; set; }
        public string City { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
