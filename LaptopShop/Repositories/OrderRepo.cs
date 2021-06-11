using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop.Model;
using System.Linq;

namespace LaptopShop.Repositories
{
    class OrderRepo : IOrder
    {
        private readonly LaptopContext _laptopContext;

        public OrderRepo(LaptopContext laptopContext)
        {
            _laptopContext = laptopContext;
        }

        public Order GetOrderbyId(int id)
        {
            return _laptopContext.order.FirstOrDefault(o => o.OrderId == id);
        }

        public IEnumerable<Order> GetOrdersbyAddressId(int addressId)
        {
            return _laptopContext.order.Where(o => o.AddressId == addressId).ToList();
        }

        public IEnumerable<Order> GetOrdersbyCustomerId(int customerId)
        {
            return _laptopContext.order.Where(o => o.CustomerId == customerId).ToList();
        }
    }
}
