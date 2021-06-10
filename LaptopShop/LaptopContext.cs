using LaptopShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace LaptopShop
{
    class LaptopContext : DbContext
    {
        
        string connection = "Server=LAPTOP-8MJF91CL\\SQLEXPRESS;Database=LaptopShop;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-8MJF91CL\\SQLEXPRESS;Database=LaptopShop;Trusted_Connection=True;");
        }

        public DbSet<Address> addresses { get; set; }
        public DbSet<Battery> battery { get; set; }
        public DbSet<Bluetooth> bluetooth { get; set; }
        public DbSet<Brand> brand { get; set; }
        public DbSet<Charger> charger { get; set; }
        public DbSet<Color> colors { get; set; }
        public DbSet<CPU> cpu { get; set; }
        public DbSet<Customer> customer { get; set; }
        public DbSet<GPU> gpu { get; set; }
        public DbSet<Keyboard> keyboard { get; set; }
        public DbSet<Order> order { get; set; }
        public DbSet<Orderline> orderLine { get; set; }
        public DbSet<PortConnection> portConnection { get; set; }
        // public DbSet<Ports> port { get; set; }
        public DbSet<PostalCode> postalCode { get; set; }
        public DbSet<Product> product { get; set; }
        public DbSet<Ram> ram { get; set; }
        public DbSet<Screen> screen { get; set; }
        public DbSet<Speakers> speakers { get; set; }
        public DbSet<Storage> storage { get; set; }
        public DbSet<Wifi> wifi { get; set; }


    }
    
}
