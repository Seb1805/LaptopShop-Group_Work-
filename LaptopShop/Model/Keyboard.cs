using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Model
{
    class Keyboard
    {
        public int keyboardId { get; set; }
        public bool Numpad { get; set; }
        public bool backlight { get; set; } 
        public string language { get; set; } 
        public string layout { get; set; } 

    }
}
