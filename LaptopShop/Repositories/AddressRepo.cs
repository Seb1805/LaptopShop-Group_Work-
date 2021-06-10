using LaptopShop.Data;
using LaptopShop.Model;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    class AddressRepo
    {
        private readonly LaptopContext _context;

        public AddressRepo(LaptopContext context)
        {
            _context = context;
        }

        public Address GetAddressById(int id)
        {
            return _context.Addresses.FirstOrDefault(a => a.CustomerId == id);
        }
    }
}
