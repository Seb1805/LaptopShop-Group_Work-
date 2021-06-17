using LaptopShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Repositories
{
    interface IOrderlineRepo
    {
        public Orderline GetOrderlineById(int id);
        public Orderline GetOrderlineByOrder(int orderId);

        public void AddOrderline(Orderline ol);
    }
}
