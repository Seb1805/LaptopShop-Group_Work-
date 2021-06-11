using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    interface IBattery
    {
        public Battery GetBatteryById(int id);
        public Battery GetBatteryByChargerId(int id);
        public IEnumerable<Battery> GetBatteriesByChargerId(int id);
        public IEnumerable<Battery> GetBatteriesByCapacity(int capacity);
        public IEnumerable<Battery> GetBatteriesByType(string type);
        public IEnumerable<Battery> GetAllBatteries();



    }
}
