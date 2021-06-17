using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop.Model;
using System.Linq;
using LaptopShop.Data;

namespace LaptopShop.Repositories
{
    class OrderRepo : IOrder
    {
        private readonly LaptopContext _context;

        public OrderRepo(LaptopContext context)
        {
            _context = context;
        }

        public Order GetOrderbyId(int id)
        {
            return _context.Orders.FirstOrDefault(o => o.OrderId == id);
        }

        public IEnumerable<Order> GetOrdersbyAddressId(int addressId)
        {
            return _context.Orders.Where(o => o.AddressId == addressId).ToList();
        }

        public IEnumerable<Order> GetOrdersbyCustomerId(int customerId)
        {
            return _context.Orders.Where(o => o.CustomerId == customerId).ToList();
        }

        public int AddOrder(Order o)
        {
            _context.Orders.Add(o);
            _context.SaveChanges();
            return o.OrderId;
        }


    }
}
