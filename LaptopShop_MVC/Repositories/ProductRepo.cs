using System;
using System.Collections.Generic;
using System.Text;
using LaptopShop_MVC.Data;
using LaptopShop_MVC.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LaptopShop_MVC.Repositories
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

        public IEnumerable<Product> SearchForProduct(List<int> CPUs, List<int> GPUs, List<int> RAM,
            List<int> colors, List<int> brands, List<int> storages, List<int> batteries, List<int> screens,
            List<int> speakers, List<int> wifi, List<int> bluetooth, List<int> keyboards, int weight,
            int fingerprint, int microphone, int webcam, string model, int priceLow, int priceHigh)
        {

            string query = "Select * From Product WHERE (";

            query += SearchProductByElement(query, CPUs, "CPUId");
            query += SearchProductByElement(query, GPUs, "GPUId");
            query += SearchProductByElement(query, RAM, "RAMId");
            query += SearchProductByElement(query, colors, "ColorId");
            query += SearchProductByElement(query, brands, "BrandId");
            query += SearchProductByElement(query, storages, "StorageId");
            query += SearchProductByElement(query, batteries, "BatteryId");
            query += SearchProductByElement(query, screens, "ScreenId");
            query += SearchProductByElement(query, speakers, "SpeakerId");
            query += SearchProductByElement(query, wifi, "WiFiId");
            query += SearchProductByElement(query, bluetooth, "BluetoothId");
            query += SearchProductByElement(query, keyboards, "KeyboardId");

            if (weight > 0)
            {
                query += CheckForParanthese(query);
                query += $" Weight <= {weight})";
            }

            if (fingerprint < 2 && fingerprint >= 0)
            {
                query += CheckForParanthese(query);
                query += $" FingerprintScanner = {fingerprint})";
            }

            if (microphone < 2 && microphone >= 0)
            {
                query += CheckForParanthese(query);
                query += $" Microphone = {microphone})";
            }

            if (webcam < 2 && webcam >= 0)
            {
                query += CheckForParanthese(query);
                query += $" Webcam = {webcam})";
            }

            if (model != "")
            {
                query += CheckForParanthese(query);
                query += $" ModelNumber = '{model}')";
            }

            if (priceLow < priceHigh)
            {
                query += CheckForParanthese(query);
                query += $" Price BETWEEN {priceLow} AND {priceHigh})";
            }
            /*
            for (int i = 0; i < CPUs.Count; i++)
            {
                query += $"CPUId = {CPUs.ElementAt(i)}";
                if (i != CPUs.Count - 1)
                    query += " OR ";
                else
                    query += ")";
            }
            query += CheckForParanthese(query);
            for (int i = 0; i < GPUs.Count; i++)
            {
                query += $"GPUId = {GPUs.ElementAt(i)}";
                if (i != GPUs.Count - 1)
                    query += " OR ";
                else
                    query += ")";
            }
            */
            Console.WriteLine(query);



            return _context.Products.FromSqlRaw(query).ToList();

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
        }

        private string SearchProductByElement(string query, List<int> list, string columnName)
        {
            string returnString = "";

            if (list.Count > 0)
            {
                    returnString += CheckForParanthese(query);

                    for (int i = 0; i < list.Count; i++)
                {
                    returnString += $"{columnName} = {list.ElementAt(i)}";
                    if (i != list.Count - 1)
                        returnString += " OR ";
                    else
                        returnString += ")";
                }
            }
            return returnString;
        }

        private string CheckForParanthese(string query)
        {
            if(query.ElementAt(query.Length -1) == ')')
            {
                return " AND (";
            }
            else
            {
                return "";
            }
        }

        public IEnumerable<Product> GetProductByWebcam(bool webcam)
        {
            return _context.Products.Where(p => p.Webcam == webcam);
        }

        public IEnumerable<Product> GetProductByWeight(int weight)
        {
            return _context.Products.Where(p => p.Weight <= weight);
        }

        public IEnumerable<Product> SearchForProduct(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
