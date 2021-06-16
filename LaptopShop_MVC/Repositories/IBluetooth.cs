using LaptopShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Repositories
{
    interface IBluetooth
    {
        public Bluetooth GetBluetoothById(int id);
        public Bluetooth GetBluetoothByDescription(string desc);
        public IEnumerable<Bluetooth> GetAllBluetooth();
    }
}
