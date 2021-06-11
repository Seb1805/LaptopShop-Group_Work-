using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop.Model;

namespace LaptopShop.Repositories
{
    interface IGPU
    {
        public GPU GetGPU(int id);
        public IEnumerable<GPU> GetGPUsByDescription(string description);
        public IEnumerable<GPU> GetGPUsByBrandId(int brandId);
    }
}
