using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LaptopShop.Repositories
{
    class AddressRepo
    {
        private readonly LaptopContext _laptopContext;

        public AddressRepo(LaptopContext laptopContext)
        {
            _laptopContext = laptopContext;
        }

        public Address GetAddressByID(int id)
        {
            return _laptopContext.addresses.First(a => a.AddressId == id);
        }
    }
}
