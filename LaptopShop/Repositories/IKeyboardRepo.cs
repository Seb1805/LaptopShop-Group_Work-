using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    interface IKeyBoardRepo{

        public IEnumerable<Keyboard> GetAllKeyboards();

        public Keyboard GetKeyboardById(int id);

        public IEnumerable<Keyboard> GetKeyboardByNumpad(bool numpad);

        public IEnumerable<Keyboard> GetKeyboardByBackligt(bool backlight);

        public IEnumerable<Keyboard> GetKeyboardByLanguage(string language);

        public IEnumerable<Keyboard> GetKeyboardByLayout(string layoutName);


    }
}