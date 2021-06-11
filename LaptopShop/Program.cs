using LaptopShop.Data;
using System;

namespace LaptopShop
{
    class Program
    {
        string connection = "Server=DESKTOP-UKDEA0P\\SQLEXPRESS; Database=LaptopShop; Trusted_Connection=True;";

        static void Main(string[] args)
        {
            LaptopContext laptopContext = new LaptopContext();
            ColorRepo color = new ColorRepo(laptopContext);

            Console.WriteLine(color.GetColorById(1).ColorName);
            Console.ReadLine();
    }
}
