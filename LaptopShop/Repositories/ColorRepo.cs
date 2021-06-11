using LaptopShop.Data;
using LaptopShop.Model;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    class ColorRepo
    {
        private readonly LaptopContext _context;

        public ColorRepo(LaptopContext context)
        {
            _context = context;
        }

        public Color GetColorById(int id)
        {
            return _context.Colors.FirstOrDefault(c => c.ColorId == id);
        }

        public Color GetColorByName(string name)
        {
            return _context.Colors.FirstOrDefault(c => c.ColorName == name);
        }
    }
}
