using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    interface IPorts
    {
        public Ports GetPortById(int id);
        public IEnumerable<Ports> GetPortByType(string typeName);
        public IEnumerable<Ports> GetPortByModel(string modelName);
    }
}
