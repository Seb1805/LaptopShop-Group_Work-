using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LaptopShop.Model;

namespace LaptopShop.Repositories
{
    class CPURepo : ICPU
    {
        private readonly LaptopContext _laptopContext;

        public CPURepo(LaptopContext laptopContext)
        {
            _laptopContext = laptopContext;
        }

        public CPU GetCPUById(int id)
        {
            return _laptopContext.cpu.FirstOrDefault(c => c.CPUId == id);
        }

        public IEnumerable<CPU> GetCPUs()
        {
            return _laptopContext.cpu.ToList();
        }

        public IEnumerable<CPU> GetCPUsByBrandId(int brandId)
        {
            return _laptopContext.cpu.Where(c => c.brandId == brandId).ToList();
        }

        public IEnumerable<CPU> GetCPUsByGeneration(int generation)
        {
            return _laptopContext.cpu.Where(c => c.Generation == generation).ToList();
        }

        // TODO: range
        public IEnumerable<CPU> GetCPUsByGHzRange(float ghzMin, float ghzMax)
        {
            return _laptopContext.cpu.Where(c => c.ghz > ghzMin && c.ghz < ghzMax).ToList();
        }
        public IEnumerable<CPU> GetCPUsByGHz(float ghz)
        {
            return _laptopContext.cpu.Where(c => c.ghz < ghz).ToList();
        }

        public IEnumerable<CPU> GetCPUsByModelNumber(string modelNumber)
        {
            return _laptopContext.cpu.Where(c => c.modelNumber.Contains(modelNumber)).ToList();
        }
    }
}
