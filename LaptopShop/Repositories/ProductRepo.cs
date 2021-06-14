using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop.Data;
using LaptopShop.Model;
using System.Linq;

namespace LaptopShop.Repositories
{
    class ProductRepo : IProductRepo
    {
        private readonly LaptopContext _context;

        public ProductRepo(LaptopContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetProductByFingerprintScanner(bool fingerprintScanner)
        {
            return _context.Product.Where(p => p.FingerprintScanner == fingerprintScanner);
        }

        public Product GetProductById(int id)
        {
            return _context.Product.FirstOrDefault(p => p.ProductId == id);
        }

        public IEnumerable<Product> GetProductByMicrophone(bool mic)
        {
            return _context.Product.Where(p => p.Microphone == mic);
        }

        public IEnumerable<Product> GetProductByModelNumber(string modelNumber)
        {
            return _context.Product.Where(p => p.ModelNumber.Contains(modelNumber));
        }

        public IEnumerable<Product> SearchForProduct(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductByWebcam(bool webcam)
        {
            return _context.Product.Where(p => p.Webcam == webcam);
        }

        public IEnumerable<Product> GetProductByWeight(int weight)
        {
            return _context.Product.Where(p => p.Weight <= weight);
        }
    }
}
