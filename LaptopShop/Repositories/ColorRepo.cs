using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LaptopShop.Repositories
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
            return _laptopContext.colors.First(c => c.ColorId == id);
        }
        public Color GetColorByDescription(string name)
        {
            return _laptopContext.colors.First(c => c.ColorName == name);
        }


    }
}
