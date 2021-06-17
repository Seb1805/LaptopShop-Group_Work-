using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop_MVC.Models;
using System.Linq;
using LaptopShop_MVC.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LaptopShop_MVC.Repositories
{
    public class OrderRepo : IOrder
    {
        private readonly LaptopContext _context;

        public OrderRepo(LaptopContext context)
        {
            _context = context;
        }

        public Order GetOrderbyId(int id)
        {
            return _context.Orders.Include(o => o.Customer).Include(o => o.Address).ThenInclude(o => o.postalCode)
                .Include(o => o.Orderlines).ThenInclude(ot => ot.Product).FirstOrDefault(o => o.OrderId == id);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _context.Orders.Include(o => o.Customer).Include(o => o.Address).ThenInclude(o => o.postalCode)
                .Include(o => o.Orderlines).ThenInclude(ot => ot.Product);
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
