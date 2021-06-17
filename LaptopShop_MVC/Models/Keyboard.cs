using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Models
{
    public class Keyboard
    {
        public int KeyboardId { get; set; }
        public bool Numpad { get; set; }
        public bool Backlight { get; set; } 
        public string Language { get; set; } 
        public string Layout { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }

    }
}
