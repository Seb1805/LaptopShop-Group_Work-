using LaptopShop.Data;
using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaptopShop.Repositories
{
    class RAMRepo : IRAMRepo
    {
        private readonly LaptopContext _context;

        public RAMRepo(LaptopContext context)
        {
            _context = context;
        }

        public RAM GetRAMByBrandId(int brandId)
        {
            return _context.RAM.FirstOrDefault(r => r.BrandId == brandId);
        }

        public IEnumerable<RAM> GetRAMByCapacity(int capacity)
        {
            return _context.RAM.Where(r => r.Capacity == capacity).ToList();
        }

        public RAM GetRAMById(int ramId)
        {
            return _context.RAM.FirstOrDefault(r => r.RamId == ramId);
        }

        public IEnumerable<RAM> GetRAMByMHz(int mhz)
        {
            return _context.RAM.Where(r => r.Mhz == mhz).ToList();
        }
    }
}
