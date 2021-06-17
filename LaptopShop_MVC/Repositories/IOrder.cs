using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaptopShop_MVC.Models;

namespace LaptopShop_MVC.Repositories
{
    public interface IOrder
    {
        public Order GetOrderbyId(int id);

        public  IEnumerable<Order> GetAllOrders();
        public IEnumerable<Order> GetOrdersbyCustomerId(int customerId);
        public IEnumerable<Order> GetOrdersbyAddressId(int addressId);
        public int AddOrder(Order o);

    }
}
