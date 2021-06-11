using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LaptopShop.Model;

namespace LaptopShop.Repositories
{
    class KeyboardRepo : IKeyboard
    {
        private readonly LaptopContext _context;

        public KeyboardRepo(LaptopContext context)
        {
            _context = context;
        }

        public Keyboard GetKeyboardById(int id)
        {
            return _context.Keyboard.FirstOrDefault(k => k.KeyboardId == id);
        }

        IEnumerable<Keyboard> IKeyboard.GetKeyboardsByNumpad(bool numpad)
        {
            return _context.Keyboard.Where(k => k.Numpad == numpad).ToList();
        }

        IEnumerable<Keyboard> IKeyboard.GetKeyboardsByBacklight(bool backlight)
        {
            return _context.Keyboard.Where(k => k.Backlight == backlight).ToList();
        }

        IEnumerable<Keyboard> IKeyboard.GetKeyboardsByLanguage(string language)
        {
            return _context.Keyboard.Where(k => k.Language == language).ToList();
        }

        IEnumerable<Keyboard> IKeyboard.GetKeyboardsByLayout(string layout)
        {
            return _context.Keyboard.Where(k => k.Layout == layout).ToList();
        }
    }
}
