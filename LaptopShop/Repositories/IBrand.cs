using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    interface IBrand
    {
        public Brand GetBrandById(int id);
        public Brand GetBrandByName(string name);
        public IEnumerable<Brand> GetAllBrands();
    }
}
