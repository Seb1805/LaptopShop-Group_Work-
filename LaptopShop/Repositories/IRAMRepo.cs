using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    interface IRAMRepo
    {
        public RAM GetRAMById(int id);
        public IEnumerable<RAM> GetRAMByCapacity(int capacity);
        public IEnumerable<RAM> GetRAMByMHz(int mhz);
        public RAM GetRAMByBrandId(int brandId);
    }
}
