using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LaptopShop.Model;

namespace LaptopShop.Repositories
{
    class KeyboardRepo : IKeyboard
    {
        private readonly LaptopContext _laptopContext;

        public KeyboardRepo(LaptopContext laptopContext)
        {
            _laptopContext = laptopContext;
        }

        public Keyboard GetKeyboardById(int id)
        {
            return _laptopContext.keyboard.FirstOrDefault(k => k.keyboardId == id);
        }

        IEnumerable<Keyboard> IKeyboard.GetKeyboardsByNumpad(bool numpad)
        {
            return _laptopContext.keyboard.Where(k => k.Numpad == numpad).ToList();
        }

        IEnumerable<Keyboard> IKeyboard.GetKeyboardsByBacklight(bool backlight)
        {
            return _laptopContext.keyboard.Where(k => k.backlight == backlight).ToList();
        }

        IEnumerable<Keyboard> IKeyboard.GetKeyboardsByLanguage(string language)
        {
            return _laptopContext.keyboard.Where(k => k.language == language).ToList();
        }

        IEnumerable<Keyboard> IKeyboard.GetKeyboardsByLayout(string layout)
        {
            return _laptopContext.keyboard.Where(k => k.layout == layout).ToList();
        }
    }
}
