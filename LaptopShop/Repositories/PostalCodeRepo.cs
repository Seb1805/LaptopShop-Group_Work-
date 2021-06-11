using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop.Data;
using LaptopShop.Model;
using System.Linq;

namespace LaptopShop.Repositories
{
    class PostalCodeRepo : IPostalCodeRepo
    {
        private LaptopContext _context;

        public PostalCodeRepo(LaptopContext context)
        {
            _context = context;
        }

        public PostalCode GetPostalCodeByCity(string cityName)
        {
            return _context.PostalCodes.FirstOrDefault(pc => pc.City == cityName);
        }

        public PostalCode GetPostalCodeById(int id)
        {
            return _context.PostalCodes.FirstOrDefault(pc => pc.Postal_Code == id);
        }
    }
}
