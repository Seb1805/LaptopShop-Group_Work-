using LaptopShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Repositories
{
    interface IBrand
    {
        public Brand GetBrandById(int id);
        public Brand GetBrandByName(string name);
        public IEnumerable<Brand> GetAllBrands();
    }
}
