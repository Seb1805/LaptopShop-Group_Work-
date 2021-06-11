using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LaptopShop.Data;

namespace LaptopShop.Repositories
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
    }
}
