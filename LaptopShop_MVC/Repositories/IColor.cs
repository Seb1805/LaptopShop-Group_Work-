using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop_MVC.Models;

namespace LaptopShop_MVC.Repositories
{
    interface IColor
    {
        public Color GetColorById(int id);
        public Color GetColorByName(string name);
        public IEnumerable<Color> GetColors();
    }
}
