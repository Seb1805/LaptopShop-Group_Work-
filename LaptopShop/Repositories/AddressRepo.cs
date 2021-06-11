using LaptopShop.Data;
using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace LaptopShop.Repositories
{
    class AddressRepo : IAddress
    {
        private readonly LaptopContext _laptopContext;

        public AddressRepo(LaptopContext laptopContext)
        {
            _laptopContext =laptopContext;
        }

        public Address GetAddressByAddressId(int id)
        {
            return _laptopContext.Addresses.First(a => a.AddressId == id);
        }

        public Address GetAddressByCustomerId(int id)
        {
            return _laptopContext.Addresses.First(a => a.CustomerId == id);
        }

        public Address GetAddressById(int id)
        {
            return _laptopContext.Addresses.First(a => a.AddressId == id);
        }

        public IEnumerable<Address> GetAllAdresses()
        {
            return _laptopContext.Addresses.ToList();
        }
    }
}
