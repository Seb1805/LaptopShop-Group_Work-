using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    interface IWifiRepo
    {
        public Wifi GetWifiById(int id);
        public IEnumerable<Wifi> GetWifiByDescription(string desc);
    }
}
