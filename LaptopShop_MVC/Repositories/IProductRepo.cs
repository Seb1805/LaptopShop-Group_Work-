using LaptopShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Repositories
{
    interface IProductRepo
    {
        public Product GetProductById(int id);
        public IEnumerable<Product> GetProductByFingerprintScanner(bool fingerprintScanner);
        public IEnumerable<Product> GetProductByWebcam(bool webcam);
        public IEnumerable<Product> GetProductByMicrophone(bool mic);
        public IEnumerable<Product> GetProductByModelNumber(string modelNumber);
        public IEnumerable<Product> SearchForProduct(string searchQuery);
        public IEnumerable<Product> GetProductByWeight(int weight);
    }
}
