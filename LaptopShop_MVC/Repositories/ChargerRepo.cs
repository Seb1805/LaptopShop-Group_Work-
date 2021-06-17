using LaptopShop_MVC.Data;
using LaptopShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaptopShop_MVC.Repositories
{
    class ChargerRepo : ICharger
    {
        private readonly LaptopContext _context;

        public ChargerRepo(LaptopContext context)
        {
            _context = context;
        }

        public IEnumerable<Charger> GetAllCharger()
        {
            return _context.Chargers.ToList();
        }

        public Charger GetChargerById(int id)
        {
            return _context.Chargers.First(c => c.ChargerId == id);
        }
    }
}
