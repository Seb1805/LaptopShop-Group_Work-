using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LaptopShop.Model;
using LaptopShop.Data;

namespace LaptopShop.Repositories
{
    class GPURepo : IGPU
    {
        private readonly LaptopContext _context;

        public GPURepo(LaptopContext laptopContext)
        {
            _context = laptopContext;
        }

        public GPU GetGPU(int id)
        {
            return _context.GPUs.FirstOrDefault(g => g.GpuId == id);
        }
        public IEnumerable<GPU> GetGPUsByDescription(string description)
        {
            return _context.GPUs.Where(g => g.Description.Contains(description)).ToList();
        }

        public IEnumerable<GPU> GetGPUsByBrandId(int brandId)
        {
            return _context.GPUs.Where(g => g.BrandId == brandId).ToList();
        }
    }
}
