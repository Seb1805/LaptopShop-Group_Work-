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
        private readonly LaptopContext _context;

        public BluetoothRepo(LaptopContext context)
        {
            _context = context;
        }

        public IEnumerable<Bluetooth> GetAllBluetooth()
        {
            return _context.Bluetooth.ToList();
        }

        public Bluetooth GetBluetoothByDescription(string desc)
        {
            return _context.Bluetooth.First(b => b.Description == desc);
        }

        public Bluetooth GetBluetoothById(int id)
        {
            return _context.Bluetooth.First(b => b.BluetoothId == id);
        }
    }
}
