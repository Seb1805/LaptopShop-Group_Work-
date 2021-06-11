using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop.Data;
using LaptopShop.Model;
using System.Linq;

namespace LaptopShop.Repositories
{
    class PortsRepocs : IPortsRepo
    {
        private readonly LaptopContext _context;

        public PortsRepocs(LaptopContext context)
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
