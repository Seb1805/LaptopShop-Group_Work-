using LaptopShop.Data;
using LaptopShop.Repositories;
using System;

namespace LaptopShop
{
    
    class Program
    {

        static void Main(string[] args)
        {
            ColorRepo cr = new ColorRepo(new LaptopContext());

            Console.WriteLine(cr.GetColorById(1).ColorName);

            //string connection = "Server=UIT-PC1EB2Y7; Database=LaptopShop; Trusted_Connection=True;";
            //SqlConnection conn = new SqlConnection(connection);

            //using (conn)
            //{
            //    SqlCommand command = new SqlCommand("Select * from Colors", conn);
            //    command.Connection.Open();

            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        while(reader.Read())
            //        {
            //            Console.WriteLine(reader.GetString(1));
            //        }
            //    }

            //    command.Connection.Close();
            //}

            Console.ReadLine();
        }
    }
}
