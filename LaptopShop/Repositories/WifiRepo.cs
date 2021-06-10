using LaptopShop.Data;
using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaptopShop.Repositories
{
    class WifiRepo : IWifiRepo
    {
        private readonly LaptopContext _context;

        public WifiRepo(LaptopContext context)
        {
            _context = context;
        }

        public IEnumerable<Wifi> GetWifiByDescription(string desc)
        {
            return _context.Wifi.Where(w => w.description == desc);
        }

        public Wifi GetWifiById(int id)
        {
            return _context.Wifi.FirstOrDefault(w => w.wifiId == id);
        }
    }
}
