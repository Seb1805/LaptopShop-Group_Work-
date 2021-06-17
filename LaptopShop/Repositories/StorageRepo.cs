using LaptopShop.Data;
using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaptopShop.Repositories
{
    class StorageRepo : IStorageRepo
    {
        private readonly LaptopContext _context;

        public StorageRepo(LaptopContext context)
        {
            _context = context;
        }

        public IEnumerable<Storage> GetStoageByBrand(int brand)
        {
            return _context.Storages.Where(s => s.Brand == brand);
        }

        public IEnumerable<Storage> GetStoageByCapacity(int capacity)
        {
            return _context.Storages.Where(s => s.Capacity == capacity);
        }

        public Storage GetStoageById(int id)
        {
            return _context.Storages.FirstOrDefault(s => s.StorageId == id);
        }

        public IEnumerable<Storage> GetStoageByModelNumber(string modelNumber)
        {
            return _context.Storages.Where(s => s.ModelNumber == modelNumber);
        }

        public IEnumerable<Storage> GetStoageByReadSpeed(int readSpeed)
        {
            return _context.Storages.Where(s => s.ReadSpeed == readSpeed);
        }

        public IEnumerable<Storage> GetStoageByType(string type)
        {
            return _context.Storages.Where(s => s.Type == type);
        }

        public IEnumerable<Storage> GetStoageByWriteSpeed(int writeSpeed)
        {
            return _context.Storages.Where(s => s.WriteSpeed == writeSpeed);
        }
    }
}
