using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop_MVC.Models;

namespace LaptopShop_MVC.Repositories
{
    interface IOrder
    {
        public Order GetOrderbyId(int id);
        public IEnumerable<Order> GetOrdersbyCustomerId(int customerId);
        public IEnumerable<Order> GetOrdersbyAddressId(int addressId);
    }
}
