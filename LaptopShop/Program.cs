using LaptopShop.Data;
using System;
using System.Data.SqlClient;

namespace LaptopShop
{
    class Program
    {
        static void Main(string[] args)
        {
            LaptopContext lc = new LaptopContext();
            ColorRepo cr = new ColorRepo(lc);

            Console.WriteLine(cr.GetColorById(1).ColorName);
            
        }
    }
}
