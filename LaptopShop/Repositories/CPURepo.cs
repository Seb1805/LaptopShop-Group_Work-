using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LaptopShop.Model;
using LaptopShop.Data;

namespace LaptopShop.Repositories
{
    class CPURepo : ICPU
    {
        private readonly LaptopContext _context;

        public CPURepo(LaptopContext context)
        {
            _context = context;
        }

        public CPU GetCPUById(int id)
        {
            return _context.CPU.FirstOrDefault(c => c.CPUId == id);
        }

        public IEnumerable<CPU> GetCPUs()
        {
            return _context.CPU.ToList();
        }

        public IEnumerable<CPU> GetCPUsByBrandId(int brandId)
        {
            return _context.CPU.Where(c => c.BrandId == brandId).ToList();
        }

        public IEnumerable<CPU> GetCPUsByGeneration(int generation)
        {
            return _context.CPU.Where(c => c.Generation == generation).ToList();
        }

        // TODO: range
        public IEnumerable<CPU> GetCPUsByGHzRange(float ghzMin, float ghzMax)
        {
            return _context.CPU.Where(c => c.Ghz > ghzMin && c.Ghz < ghzMax).ToList();
        }
        public IEnumerable<CPU> GetCPUsByGHz(float ghz)
        {
            return _context.CPU.Where(c => c.Ghz < ghz).ToList();
        }

        public IEnumerable<CPU> GetCPUsByModelNumber(string modelNumber)
        {
            return _context.CPU.Where(c => c.ModelNumber.Contains(modelNumber)).ToList();
        }
    }
}
