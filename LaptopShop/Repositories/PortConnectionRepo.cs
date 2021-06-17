using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop.Data;
using LaptopShop.Model;
using System.Linq;

namespace LaptopShop.Repositories
{
    class PortConnectionRepo : IPortConnectionRepo
    {
        private readonly LaptopContext _context;

        public PortConnectionRepo(LaptopContext context)
        {
            _context = context;
        }
        public IEnumerable<PortConnection> GetConnectionByAmount(int amount)
        {
            return _context.PortConnections.Where(pc => pc.Amount >= amount);
        }

        public PortConnection GetPortConnectionById(int id)
        {
            return _context.PortConnections.FirstOrDefault(pc => pc.PortConnectionId == id);
        }

        public PortConnection GetPortConnectionByProduct(int productId)
        {
            return _context.PortConnections.FirstOrDefault(pc => pc.ProductId == productId);
        }
    }
}
