using LaptopShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Repositories
{
    interface IPortsRepo
    {
        public Port GetPortById(int id);
        public IEnumerable<Port> GetPortByType(string typeName);
        public IEnumerable<Port> GetPortByModel(string modelName);
    }
}
