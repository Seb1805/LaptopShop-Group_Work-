using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LaptopShop.Repositories
{
    class ColorRepo : IColor
    {
        private readonly LaptopContext _laptopContext;

        public ColorRepo(LaptopContext laptopContext)
        {
            _laptopContext = laptopContext;
        }

        public Color GetColorById(int id)
        {
            return _laptopContext.colors.FirstOrDefault(c => c.ColorId == id);
        }

        public Color GetColorByName(string name)
        {
            return _laptopContext.colors.FirstOrDefault(c => c.ColorName == name);
        }

        public IEnumerable<Color> GetColors()
        {
            return _laptopContext.colors.ToList();
        }
    }
}
