using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop_MVC.Models;

namespace LaptopShop_MVC.Repositories
{
    interface IKeyboard
    {
        public Keyboard GetKeyboardById(int id);
        public IEnumerable<Keyboard> GetKeyboardsByNumpad(bool numpad);
        public IEnumerable<Keyboard> GetKeyboardsByBacklight(bool backlight);
        public IEnumerable<Keyboard> GetKeyboardsByLanguage(string language);
        public IEnumerable<Keyboard> GetKeyboardsByLayout(string layout);
    }
}
