using LaptopShop_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Data
{
    public class LaptopContext : DbContext
    {

        public LaptopContext(DbContextOptions<LaptopContext> options) : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Battery> Batteries { get; set; }
        public DbSet<Bluetooth> Bluetooth { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Charger> Chargers { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<Keyboard> Keyboards { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Orderline> Orderlines { get; set; }
        public DbSet<PortConnection> PortConnections { get; set; }
        public DbSet<Port> Ports { get; set; }
        public DbSet<PostalCode> PostalCodes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<RAM> RAM { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Wifi> Wifi { get; set; }

    }
}
