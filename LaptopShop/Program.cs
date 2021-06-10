using LaptopShop.Repositories;
using LaptopShop.Data;
using System;

namespace LaptopShop
{

    class Program
    {
        
        static void Main(string[] args)
        {

            ColorRepo cr = new ColorRepo(new LaptopContext());

            Console.WriteLine(cr.GetColorById(1).ColorName);

        //    string connection = "Server=DESKTOP-UKDEA0P\\SQLEXPRESS; Database=LaptopShop; Trusted_Connection=True;";
        //    SqlConnection conn = new SqlConnection(connection);
        //
        //    using(conn)
        //    {
        //        SqlCommand command = new SqlCommand("select * from Colors", conn);
        //        command.Connection.Open();
        //        
        //        using(SqlDataReader reader = command.ExecuteReader())
        //        {
        //            while(reader.Read())
        //            {
        //                Console.WriteLine(reader.GetString(1));
        //            }
        //        }
        //
        //        command.Connection.Close();
        //    }
        //
        //    Console.ReadLine();
        }
    }
}
