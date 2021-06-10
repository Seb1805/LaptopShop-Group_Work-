using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    interface IPortConnection
    {
        public PortConnection GetPortConnectionById(int id);

        public IEnumerable<PortConnection> GetConnectionByAmount(int amount);

        public PortConnection GetPortConnectionByProduct(int productId);
    }
}
