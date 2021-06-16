using LaptopShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Repositories
{
    interface IPortConnectionRepo
    {
        public PortConnection GetPortConnectionById(int id);

        public IEnumerable<PortConnection> GetConnectionByAmount(int amount);

        public PortConnection GetPortConnectionByProduct(int productId);
    }
}
