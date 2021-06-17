using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Models
{
    public class Product
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
        public bool FingerprintScanner { get; set; }
        public int SpeakerId { get;set; }
        public int WifiId { get; set; }
        public int BluetoothId { get; set; }
        public int KeyboardId { get; set; }
        public bool Microphone { get; set; }
        public bool Webcam { get; set; }
        public string ModelNumber { get; set; }
        public int Price { get; set; }

        public virtual CPU CPU { get; set; }
        public virtual GPU GPU { get; set; }
        public virtual RAM RAM { get; set; }
        public virtual Color Color { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Storage Storage { get; set; }
        public virtual Battery Battery { get; set; }
        public virtual Screen Screen { get; set; }
        public virtual Speaker Speaker { get; set; }
        public virtual Wifi Wifi { get; set; }
        public virtual Bluetooth Bluetooth { get; set; }
        public virtual Keyboard Keyboard { get; set; }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
