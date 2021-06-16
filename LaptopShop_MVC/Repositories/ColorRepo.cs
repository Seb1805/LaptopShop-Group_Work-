using LaptopShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaptopShop_MVC.Data
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
            return _context.Colors.First(c => c.ColorId == id);
        }

        public List<Color> GetAll()
        {
            return _context.Colors.ToList();
        }
        public Color GetColorByName(string name)
        {
            return _context.Colors.First(c => c.ColorName == name);
        }
    }
}
