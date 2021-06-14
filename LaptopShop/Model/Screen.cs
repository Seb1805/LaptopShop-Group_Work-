using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Model
{
    class Screen
    {
        public int ScreenId { get; set; }
        public string AspectRatio { get; set; }
        public string Resolution { get; set; }
        public float Size { get; set; }
        public bool HDR { get; set; }
        public int RefreshRate { get; set; }
        public string ScreenTechnology { get; set; }
        public int Brightness { get; set; }
        public bool Touch { get; set; }
        public string SyncType { get; set; }
    }
}
