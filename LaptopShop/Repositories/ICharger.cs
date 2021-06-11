using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    interface ICharger
    {
        public Charger GetChargerById(int id);

        public IEnumerable<Charger> GetAllCharger();
    }
}
