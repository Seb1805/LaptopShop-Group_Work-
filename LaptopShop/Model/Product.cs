using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Model
{
    class Product
    {
        public int ProductId { get; set; }
        public int CPUId { get; set; }
        public int GPUId { get; set; }
        public int RAMId { get; set; }
        public int ColorId { get; set; }
        public int BrandId { get; set; }
        public int StorageId { get; set; }
        public int BatteryId { get; set; }
        public int ScreenId { get; set; }
        public int Weight { get;set; }
        public bool DockingStation { get; set; }
        public bool FingerprintScanner { get; set; }
        public int SpeakerId { get;set; }
        public int WifiId { get; set; }
        public int BluetoothId { get; set; }
        public int KeyboardId { get; set; }
        public bool Microphone { get; set; }
        public bool Webcam { get; set; }
        public string ModelNumber { get; set; }

    }
}
