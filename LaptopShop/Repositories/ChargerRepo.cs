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
        private readonly LaptopContext _laptopContext;

        public ChargerRepo(LaptopContext laptopContext)
        {
            _laptopContext = laptopContext;
        }

        public IEnumerable<Charger> GetAllCharger()
        {
            return _laptopContext.Chargers.ToList();
        }

        public Charger GetChargerById(int id)
        {
            return _laptopContext.Chargers.First(c => c.ChargerId == id);
        }
    }
}
