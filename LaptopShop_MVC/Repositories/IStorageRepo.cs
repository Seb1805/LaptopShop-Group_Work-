using LaptopShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Repositories
{
    interface IStorageRepo
    {
        public Storage GetStoageById(int id); 
        public IEnumerable<Storage> GetStoageByCapacity(int capacity); 
        public IEnumerable<Storage> GetStoageByType(string type); 
        public IEnumerable<Storage> GetStoageByBrand(int brand); 
        public IEnumerable<Storage> GetStoageByReadSpeed(int readSpeed); 
        public IEnumerable<Storage> GetStoageByWriteSpeed(int writeSpeed); 
        public IEnumerable<Storage> GetStoageByModelNumber(string modelNumber); 
    }
}
