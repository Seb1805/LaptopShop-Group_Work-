using LaptopShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Repositories
{
    interface IWifiRepo
    {
        public Wifi GetWifiById(int id);
        public IEnumerable<Wifi> GetWifiByDescription(string desc);
    }
}
