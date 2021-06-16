using LaptopShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Repositories
{
    interface IPostalCodeRepo
    {
        public PostalCode GetPostalCodeById(int id);
        public PostalCode GetPostalCodeByCity(string cityName);
    }
}
