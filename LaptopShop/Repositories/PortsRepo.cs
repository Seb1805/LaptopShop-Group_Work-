using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop.Model;
using System.Linq;
using LaptopShop.Data;

namespace LaptopShop.Repositories
{
    class PortsRepo : IPortsRepo
    {
        private readonly LaptopContext _context;

        public PortsRepo(LaptopContext context)
        {
            _context = context;
        }

        public Ports GetPortById(int id)
        {
            return _context.Ports.FirstOrDefault(p => p.PortId == id);
        }

        public IEnumerable<Ports> GetPortByModel(string modelName)
        {
            return _context.Ports.Where(p => p.Model.Contains(modelName));
        }

        public IEnumerable<Ports> GetPortByType(string typeName)
        {
            return _context.Ports.Where(p => p.Type.Contains(typeName));
        }
    }
}
