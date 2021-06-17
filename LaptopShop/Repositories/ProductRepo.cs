using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop.Data;
using LaptopShop.Model;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

        public IEnumerable<Product> SearchForProduct(List<int> CPUs)
        {

            string query = "Select * From Product WHERE ";

            for(int i = 0; i < CPUs.Count; i++)
            {
                query += $"CPUId = {CPUs.ElementAt(i)}";
                if (i != CPUs.Count - 1)
                    query += "OR ";
            }

            return _context.Product.FromSqlRaw(query).ToList();

            //List<Product> list = _context.Product.ToList();
            //foreach(var prod in list)
            //{
            //    foreach(var c in CPUs) 
            //    {
            //        if (prod.CPUId != c)
            //        {
            //            list.Remove(prod);
            //        }
            //    }
            //}
            //items.ToList().ForEach(i => i.DoStuff());
            //return _context.Product
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
