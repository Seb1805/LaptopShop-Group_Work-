using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop_MVC.Models;

namespace LaptopShop_MVC.Repositories
{
    interface IGPU
    {
        public GPU GetGPU(int id);
        public IEnumerable<GPU> GetGPUsByDescription(string description);
        public IEnumerable<GPU> GetGPUsByBrandId(int brandId);
    }
}
