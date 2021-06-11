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
        private readonly LaptopContext _laptopContext;

        public BatteryRepo(LaptopContext laptopContext)
        {
            _laptopContext = laptopContext;
        }
        public IEnumerable<Battery> GetAllBatteries()
        {
            return _laptopContext.Batteries.ToList();
        }

        public IEnumerable<Battery> GetBatteriesByCapacity(int capacity)
        {
            return _laptopContext.Batteries.Where(b => b.Capacity == capacity).ToList();
        }

        public IEnumerable<Battery> GetBatteriesByChargerId(int id)
        {
            return _laptopContext.Batteries.Where(b => b.ChargerId == id).ToList();
        }

        public IEnumerable<Battery> GetBatteriesByType(string type)
        {
            return _laptopContext.Batteries.Where(b => b.Type == type).ToList();
        }

        public Battery GetBatteryByChargerId(int id)
        {
            return _laptopContext.Batteries.First(b => b.ChargerId == id);
        }

        public Battery GetBatteryById(int id)
        {
            return _laptopContext.Batteries.First(b => b.BatteryId == id);
        }
    }
}
