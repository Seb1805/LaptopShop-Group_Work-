using LaptopShop_MVC.Data;
using LaptopShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaptopShop_MVC.Repositories
{
    class BrandRepo : IBrand
    {
        private readonly LaptopContext _context;

        public BrandRepo(LaptopContext context)
        {
            _context = context;
        }

        public IEnumerable<Brand> GetAllBrands()
        {
            return _context.Brands.ToList();
        }

        public Brand GetBrandById(int id)
        {
            return _context.Brands.First(b => b.BrandId == id);
        }

        public Brand GetBrandByName(string name)
        {
            return _context.Brands.First(b => b.BrandName == name);
        }
    }
}
