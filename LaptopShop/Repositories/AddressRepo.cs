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
            return _laptopContext.Addresses.First(a => a.AddressId == id);
        }

        public IEnumerable<Address> GetAllAdresses()
        {
            return _laptopContext.Addresses.ToList();
            return _context.Addresses.FirstOrDefault(a => a.CustomerId == id);
        }
    }
}
