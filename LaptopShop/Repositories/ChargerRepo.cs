using LaptopShop.Data;
using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaptopShop.Repositories
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
            return _context.Charger.ToList();
        }

        public Charger GetChargerById(int id)
        {
            return _context.Charger.First(c => c.ChargerId == id);
        }
    }
}
