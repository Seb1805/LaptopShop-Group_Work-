using LaptopShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Repositories
{
    interface ICharger
    {
        public Charger GetChargerById(int id);

        public IEnumerable<Charger> GetAllCharger();
    }
}
