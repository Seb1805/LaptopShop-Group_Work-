using LaptopShop.Data;
using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaptopShop.Repositories
{
    class BrandRepo : IBrand
    {
        private readonly LaptopContext _laptopContext;

        public BrandRepo(LaptopContext laptopContext)
        {
            _laptopContext = laptopContext;
        }

        public IEnumerable<Brand> GetAllBrands()
        {
            return _laptopContext.Brands.ToList();
        }

        public Brand GetBrandById(int id)
        {
            return _laptopContext.Brands.First(b => b.BrandId == id);
        }

        public Brand GetBrandByName(string name)
        {
            return _laptopContext.Brands.First(b => b.BrandName == name);
        }
    }
}
