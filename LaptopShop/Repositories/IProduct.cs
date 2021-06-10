using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    interface IProduct
    {
        public Product GetProductById(int id);
        public IEnumerable<Product> GetProductByFingerprintScanner(bool fingerprintScanner);
        public IEnumerable<Product> GetProductByWebcam(bool webcam);
        public IEnumerable<Product> GetProductByMicrophone(bool mic);
        public IEnumerable<Product> GetProductByModelNumber(string modelNumber);
        public IEnumerable<Product> GetProductBySearch(string searchQuery);
    }
}
