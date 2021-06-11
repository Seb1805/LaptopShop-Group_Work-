using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    interface IBluetooth
    {
        public Bluetooth GetBluetoothById(int id);
        public Bluetooth GetBluetoothByDescription(string desc);
        public IEnumerable<Bluetooth> GetAllBluetooth();
    }
}
