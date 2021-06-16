using LaptopShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LaptopShop_MVC.Data;

namespace LaptopShop_MVC.Repositories
{
    class AddressRepo
    {
        private readonly LaptopContext _context;

        public AddressRepo(LaptopContext context)
        {
            _context = context;
        }

        public Address GetAddressByID(int id)
        {
            return _context.Addresses.First(a => a.AddressId == id);
        }

        internal Address GetAddressByCustomerId(int customerId)
        {
            return _context.Addresses.First(a => a.CustomerId == customerId);

        }
    }
}
