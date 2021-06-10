using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop.Data;
using LaptopShop.Model;
using System.Linq;

namespace LaptopShop.Repositories
{
    class ProductRepo : IProduct
    {
        private readonly LaptopContext _context;

        public ProductRepo(LaptopContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetProductByFingerprintScanner(bool fingerprintScanner)
        {
            return _context.Products.Where(p => p.FingerprintScanner == fingerprintScanner);
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.ProductId == id);
        }

        public IEnumerable<Product> GetProductByMicrophone(bool mic)
        {
            return _context.Products.Where(p => p.Microphone == mic);
        }

        public IEnumerable<Product> GetProductByModelNumber(string modelNumber)
        {
            return _context.Products.Where(p => p.ModelNumber.Contains(modelNumber));
        }

        public IEnumerable<Product> SearchForProduct(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductByWebcam(bool webcam)
        {
            return _context.Products.Where(p => p.Webcam == webcam);
        }

        public IEnumerable<Product> GetProductByWeight(int weight)
        {
            return _context.Products.Where(p => p.Weight <= weight);
        }
    }
}
