using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LaptopShop.Model;

namespace LaptopShop.Repositories
{
    class GPURepo : IGPU
    {
        private readonly LaptopContext _laptopContext;

        public GPURepo(LaptopContext laptopContext)
        {
            _laptopContext = laptopContext;
        }

        public GPU GetGPU(int id)
        {
            return _laptopContext.gpu.FirstOrDefault(g => g.gpuId == id);
        }
        public IEnumerable<GPU> GetGPUsByDescription(string description)
        {
            return _laptopContext.gpu.Where(g => g.description.Contains(description)).ToList();
        }

        public IEnumerable<GPU> GetGPUsByBrandId(int brandId)
        {
            return _laptopContext.gpu.Where(g => g.brandId == brandId).ToList();
        }
    }
}
