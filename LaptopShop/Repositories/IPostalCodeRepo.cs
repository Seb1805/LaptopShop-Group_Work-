using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    interface IPostalCodeRepo
    {
        public PostalCode GetPostalCodeById(int id);
        public PostalCode GetPostalCodeByCity(string cityName);
    }
}
