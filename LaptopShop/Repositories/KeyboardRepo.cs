using LaptopShop.Data;
using LaptopShop.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    class KeyboardRepo : IKeyBoardRepo
    {
        private readonly LaptopContext _context;

        public KeyboardRepo (LaptopContext context)
        {
            _context = context;
        }

        public IEnumerable<Keyboard> GetAllKeyboards()
        {
            return _context.Keyboards.ToList();
        }

        public IEnumerable<Keyboard> GetKeyboardByBackligt(bool backlight)
        {
            return _context.Keyboards.Where(k => k.Backlight == backlight).ToList();
        }

        public Keyboard GetKeyboardById(int id)
        {
            return _context.Keyboards.FirstOrDefault(k => k.KeyboardId == id);
        }

        public IEnumerable<Keyboard> GetKeyboardByLanguage(string language)
        {
            return _context.Keyboards.Where(k => k.Language == language).ToList();
        }

        public IEnumerable<Keyboard> GetKeyboardByLayout(string layoutName)
        {
            return _context.Keyboards.Where(k => k.Layout == layoutName);
        }

        public IEnumerable<Keyboard> GetKeyboardByNumpad(bool numpad)
        {
            return _context.Keyboards.Where(k => k.Numpad == numpad).ToList();
        }
    }
}
