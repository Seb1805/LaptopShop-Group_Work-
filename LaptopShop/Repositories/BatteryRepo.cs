using LaptopShop.Data;
using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaptopShop.Repositories
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
            return _context.Battery.ToList();
        }

        public IEnumerable<Battery> GetBatteriesByCapacity(int capacity)
        {
            return _context.Battery.Where(b => b.Capacity == capacity).ToList();
        }

        public IEnumerable<Battery> GetBatteriesByChargerId(int id)
        {
            return _context.Battery.Where(b => b.ChargerId == id).ToList();
        }

        public IEnumerable<Battery> GetBatteriesByType(string type)
        {
            return _context.Battery.Where(b => b.Type == type).ToList();
        }

        public Battery GetBatteryByChargerId(int id)
        {
            return _context.Battery.First(b => b.ChargerId == id);
        }

        public Battery GetBatteryById(int id)
        {
            return _context.Battery.First(b => b.BatteryId == id);
        }
    }
}
