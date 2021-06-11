using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop.Model;

namespace LaptopShop.Repositories
{
    interface ICPU
    {
        public CPU GetCPUById(int id);
        public IEnumerable<CPU> GetCPUsByGeneration(int generation);
        public IEnumerable<CPU> GetCPUsByModelNumber(string modelNumber);
        // TODO: Range
        public IEnumerable<CPU> GetCPUsByGHzRange(float ghzMin, float ghzMax);
        public IEnumerable<CPU> GetCPUsByGHz(float ghz);
        public IEnumerable<CPU> GetCPUsByBrandId(int brandId);
        public IEnumerable<CPU> GetCPUs();
    }
}
