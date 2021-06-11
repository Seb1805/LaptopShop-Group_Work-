using LaptopShop.Data;
using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaptopShop.Repositories
{
    class BluetoothRepo : IBluetooth
    {
        private readonly LaptopContext _laptopContext;

        public BluetoothRepo(LaptopContext laptopContext)
        {
            _laptopContext = laptopContext;
        }

        public IEnumerable<Bluetooth> GetAllBluetooth()
        {
            return _laptopContext.Bluetooth.ToList();
        }

        public Bluetooth GetBluetoothByDescription(string desc)
        {
            return _laptopContext.Bluetooth.First(b => b.Description == desc);
        }

        public Bluetooth GetBluetoothById(int id)
        {
            return _laptopContext.Bluetooth.First(b => b.BluetoothId == id);
        }
    }
}
