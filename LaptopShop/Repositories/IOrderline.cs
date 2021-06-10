﻿using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    interface IOrderline
    {
        public Orderline GetOrderlineById(int id);
        public Orderline GetOrderlineByOrder(int orderId);

        public void AddOrderline(int orderId, int productId);
    }
}
