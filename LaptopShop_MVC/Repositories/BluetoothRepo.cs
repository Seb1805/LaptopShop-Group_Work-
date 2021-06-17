using LaptopShop_MVC.Data;
using LaptopShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaptopShop_MVC.Repositories
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
