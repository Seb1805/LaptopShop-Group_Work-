using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop_MVC.Data;
using LaptopShop_MVC.Models;
using System.Linq;

namespace LaptopShop_MVC.Repositories
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
            return _context.Orderlines.FirstOrDefault(ol => ol.OrderLineId == id);
        }

        public Orderline GetOrderlineByOrder(int orderId)
        {
            return _context.Orderlines.FirstOrDefault(ol => ol.OrderId == orderId);
        }

        public void AddOrderline(Orderline ol)
        {
            _context.Orderlines.Add(ol);
            _context.SaveChanges();
        }
    }
}
