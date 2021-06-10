using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    interface IRAMRepo
    {
        public RAM GetRAMById(int id);
        public RAM GetRAMByCapacity(int capacity);
        public RAM GetRAMByMHz(int mhz);
        public RAM GetRAMByBrandId(int brandId);
    }
}
