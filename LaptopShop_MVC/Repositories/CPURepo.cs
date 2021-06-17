using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LaptopShop_MVC.Models;
using LaptopShop_MVC.Data;

namespace LaptopShop_MVC.Repositories
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
            return _context.CPUs.FirstOrDefault(c => c.CPUId == id);
        }

        public IEnumerable<CPU> GetCPUs()
        {
            return _context.CPUs.ToList();
        }

        public IEnumerable<CPU> GetCPUsByBrandId(int brandId)
        {
            return _context.CPUs.Where(c => c.BrandId == brandId).ToList();
        }

        public IEnumerable<CPU> GetCPUsByGeneration(int generation)
        {
            return _context.CPUs.Where(c => c.Generation == generation).ToList();
        }

        // TODO: range
        public IEnumerable<CPU> GetCPUsByGHzRange(float ghzMin, float ghzMax)
        {
            return _context.CPUs.Where(c => c.Ghz > ghzMin && c.Ghz < ghzMax).ToList();
        }
        public IEnumerable<CPU> GetCPUsByGHz(float ghz)
        {
            return _context.CPUs.Where(c => c.Ghz < ghz).ToList();
        }

        public IEnumerable<CPU> GetCPUsByModelNumber(string modelNumber)
        {
            return _context.CPUs.Where(c => c.ModelNumber.Contains(modelNumber)).ToList();
        }
    }
}
