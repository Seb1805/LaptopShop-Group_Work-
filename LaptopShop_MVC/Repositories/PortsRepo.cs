using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop_MVC.Models;
using System.Linq;
using LaptopShop_MVC.Data;

namespace LaptopShop_MVC.Repositories
{
    class PortsRepo : IPortsRepo
    {
        private readonly LaptopContext _context;

        public PortsRepo(LaptopContext context)
        {
            _context = context;
        }

        public Port GetPortById(int id)
        {
            return _context.Ports.FirstOrDefault(p => p.PortId == id);
        }

        public IEnumerable<Port> GetPortByModel(string modelName)
        {
            return _context.Ports.Where(p => p.Model.Contains(modelName));
        }

        public IEnumerable<Port> GetPortByType(string typeName)
        {
            return _context.Ports.Where(p => p.Type.Contains(typeName));
        }
    }
}
