using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaptopShop.Data
{
    class ColorRepo
    {
        private readonly LaptopContext _laptopContext;

        public ColorRepo(LaptopContext laptopContext)
        {
            _laptopContext = laptopContext;
        }

        public Color GetColorById(int id)
        {
            return _laptopContext.Colors.First(c => c.ColorId == id);
        }

        public List<Color> GetAll()
        {
            return _laptopContext.Colors.ToList();
        }
        public Color GetColorByName(string name)
        {
            return _laptopContext.Colors.First(c => c.ColorName == name);
        }
    }
}
