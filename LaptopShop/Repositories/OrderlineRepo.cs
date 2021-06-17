using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop.Data;
using LaptopShop.Model;
using System.Linq;

namespace LaptopShop.Repositories
{
    class OrderlineRepo : IOrderlineRepo
    {
        private LaptopContext _context;

        public OrderlineRepo(LaptopContext context)
        {
            _context = context;
        }

        public Orderline GetOrderlineById(int id)
        {
            return _context.Orderline.FirstOrDefault(ol => ol.OrderLineId == id);
        }

        public Orderline GetOrderlineByOrder(int orderId)
        {
            return _context.Orderline.FirstOrDefault(ol => ol.OrderId == orderId);
        }

        public void AddOrderline(Orderline ol)
        {
            _context.Orderline.Add(ol);
            _context.SaveChanges();
        }
    }
}
