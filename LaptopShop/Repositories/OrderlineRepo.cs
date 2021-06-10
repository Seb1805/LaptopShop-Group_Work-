﻿using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop.Data;
using LaptopShop.Model;
using System.Linq;

namespace LaptopShop.Repositories
{
    class OrderlineRepo : IOrderline
    {
        private LaptopContext _context;

        public OrderlineRepo(LaptopContext context)
        {
            _context = context;
        }


        public void AddOrderline(int orderId, int productId)
        {
            _context.Add(new Orderline() { OrderId = orderId, ProductId = productId });
            _context.SaveChanges();
        }

        public Orderline GetOrderlineById(int id)
        {
            return _context.Orderlines.FirstOrDefault(ol => ol.OrderLineId == id);
        }

        public Orderline GetOrderlineByOrder(int orderId)
        {
            return _context.Orderlines.FirstOrDefault(ol => ol.OrderId == orderId);
        }
    }
}
