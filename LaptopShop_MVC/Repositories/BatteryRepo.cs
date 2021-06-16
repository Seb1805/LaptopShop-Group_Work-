using LaptopShop_MVC.Data;
using LaptopShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaptopShop_MVC.Repositories
{
    class BatteryRepo : IBattery
    {
        private readonly LaptopContext _context;

        public BatteryRepo(LaptopContext context)
        {
            _context = context;
        }
        public IEnumerable<Battery> GetAllBatteries()
        {
            return _context.Batteries.ToList();
        }

        public IEnumerable<Battery> GetBatteriesByCapacity(int capacity)
        {
            return _context.Batteries.Where(b => b.Capacity == capacity).ToList();
        }

        public IEnumerable<Battery> GetBatteriesByChargerId(int id)
        {
            return _context.Batteries.Where(b => b.ChargerId == id).ToList();
        }

        public IEnumerable<Battery> GetBatteriesByType(string type)
        {
            return _context.Batteries.Where(b => b.Type == type).ToList();
        }

        public Battery GetBatteryByChargerId(int id)
        {
            return _context.Batteries.First(b => b.ChargerId == id);
        }

        public Battery GetBatteryById(int id)
        {
            return _context.Batteries.First(b => b.BatteryId == id);
        }
    }
}
