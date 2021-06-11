using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop.Model;

namespace LaptopShop.Repositories
{
    interface IColor
    {
        public Color GetColorById(int id);
        public Color GetColorByName(string name);
        public IEnumerable<Color> GetColors();
    }
}
