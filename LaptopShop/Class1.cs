using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop
{
    class Class1
    {

        lc.Colors.Add(new Color() { ColorName = "Rose Gold" });
            lc.Colors.Add(new Color() { ColorName = "White" });
            lc.Colors.Add(new Color() { ColorName = "Gray" });
            lc.Colors.Add(new Color() { ColorName = "Green" });
            lc.Colors.Add(new Color() { ColorName = "Blue" });
            lc.Colors.Add(new Color() { ColorName = "Red" });
            lc.Colors.Add(new Color() { ColorName = "Silver" });
            lc.Colors.Add(new Color() { ColorName = "Yellow" });

            //intel 3, AMD 4
            lc.Cpu.Add(new CPU() { Generation = 10, ModelNumber = "i9-10900KF", Ghz = 3.7f, BrandId = 3});
            lc.Cpu.Add(new CPU() { Generation = 9, ModelNumber = "i7-9700KF", Ghz = 3.6f, BrandId = 3});
            lc.Cpu.Add(new CPU() { Generation = 11, ModelNumber = "i9-11700k", Ghz = 3.6f, BrandId = 3});
            lc.Cpu.Add(new CPU() { Generation = 10, ModelNumber = "i7-10700k", Ghz = 3.8f, BrandId = 3});
            lc.Cpu.Add(new CPU() { Generation = 11, ModelNumber = "i5-11600kf", Ghz = 2.8f, BrandId = 3});
            lc.Cpu.Add(new CPU() { Generation = 4, ModelNumber = "Ryzen 9 5900X", Ghz = 3.7f, BrandId = 4});
            lc.Cpu.Add(new CPU() { Generation = 4, ModelNumber = "Ryzen 7 5800X", Ghz = 3.8f, BrandId = 4});
            lc.Cpu.Add(new CPU() { Generation = 4, ModelNumber = "Ryzen 9 5950X", Ghz = 3.4f, BrandId = 4});
            lc.Cpu.Add(new CPU() { Generation = 4, ModelNumber = "Ryzen 3 5300G", Ghz = 4.2f, BrandId = 4});
            lc.Cpu.Add(new CPU() { Generation = 4, ModelNumber = "Ryzen 5 5600X", Ghz = 3.7f, BrandId = 4});

            lc.Customer.Add(new Customer() { FirstName = "Cathrine", LastName = "Laursen", PhoneNumber = "79645312", Email = "cathrinelaursen1234@testmail.com" });
            lc.Customer.Add(new Customer() { FirstName = "Mia", LastName = "Pedersen", PhoneNumber = "87456156", Email = "miapedersen1234@testmail.com" });
            lc.Customer.Add(new Customer() { FirstName = "Ingelise", LastName = "Rasmusen", PhoneNumber = "89653435", Email = "ingeliserasmusen1234@testmail.com" });
            lc.Customer.Add(new Customer() { FirstName = "Camilla", LastName = "Jensen", PhoneNumber = "23456065", Email = "camillajensen1234@testmail.com" });
            lc.Customer.Add(new Customer() { FirstName = "Mette", LastName = "Thomsen", PhoneNumber = "60205655", Email = "mettethomsen1234@testmail.com" });
            lc.Customer.Add(new Customer() { FirstName = "Peter", LastName = "Jensen", PhoneNumber = "51840682", Email = "peterjensen1234@testmail.com" });
            lc.Customer.Add(new Customer() { FirstName = "Torben", LastName = "Pedersen", PhoneNumber = "35489205", Email = "torbenpedersen1234@testmail.com" });
            lc.Customer.Add(new Customer() { FirstName = "Kristian", LastName = "Laursen", PhoneNumber = "33024582", Email = "kristianlaursen1234@testmail.com" });
            lc.Customer.Add(new Customer() { FirstName = "Morten", LastName = "Nielsen", PhoneNumber = "52001576", Email = "mortennielsen1234@testmail.com" });
            lc.Customer.Add(new Customer() { FirstName = "Bo", LastName = "Nielsen", PhoneNumber = "57605685", Email = "bonielsen1234@testmail.com" });
            lc.Customer.Add(new Customer() { FirstName = "Mikkel", LastName = "Laursen", PhoneNumber = "20158962", Email = "mikkellaursen1234@testmail.com" });

            lc.Gpu.Add(new GPU() { Description = "NVIDIA GeForce RTX 3090 Mobile", BrandId = 3, Vram = 16});
            lc.Gpu.Add(new GPU() { Description = "NVIDIA GeForce RTX 3080 Ti", BrandId = 3, Vram = 12});
            lc.Gpu.Add(new GPU() { Description = "NVIDIA GeForce RTX 3080", BrandId = 3, Vram = 10});
            lc.Gpu.Add(new GPU() { Description = "NVIDIA GeForce RTX 2080 Ti", BrandId = 3, Vram = 11});
            lc.Gpu.Add(new GPU() { Description = "NVIDIA GeForce RTX 3090", BrandId = 3, Vram = 24});
            lc.Gpu.Add(new GPU() { Description = "Radeon RX 6900XT", BrandId = 4, Vram = 16});
            lc.Gpu.Add(new GPU() { Description = "Radeon RX 6800XT", BrandId = 4, Vram = 16});
            lc.Gpu.Add(new GPU() { Description = "Radeon RX 5700XT", BrandId = 4, Vram = 8});
            lc.Gpu.Add(new GPU() { Description = "Radeon RT 6700XT", BrandId = 4, Vram = 12});
            lc.Gpu.Add(new GPU() { Description = "Radeon RT 6800XT", BrandId = 4, Vram = 16});

            lc.Keyboard.Add(new Keyboard() { Language = "US", Layout = "qwerty", Numpad = true, Backlight = true});
            lc.Keyboard.Add(new Keyboard() { Language = "French", Layout = "azerty", Numpad = true, Backlight = true});
            lc.Keyboard.Add(new Keyboard() { Language = "Italian", Layout = "qzerty", Numpad = true, Backlight = true});
            lc.Keyboard.Add(new Keyboard() { Language = "German", Layout = "qwerty", Numpad = true, Backlight = true});
            lc.Keyboard.Add(new Keyboard() { Language = "Spanish", Layout = "qwerty", Numpad = true, Backlight = true});
            lc.Keyboard.Add(new Keyboard() { Language = "Russian", Layout = "qwerty", Numpad = true, Backlight = true});
            lc.Keyboard.Add(new Keyboard() { Language = "Bulgarian", Layout = "qwertz", Numpad = true, Backlight = true});
            lc.Keyboard.Add(new Keyboard() { Language = "Nordic", Layout = "qwerty", Numpad = true, Backlight = true});
            lc.Keyboard.Add(new Keyboard() { Language = "Chinese", Layout = "qwerty", Numpad = true, Backlight = true});
            lc.Keyboard.Add(new Keyboard() { Language = "Hangul", Layout = "Dubeolsik", Numpad = true, Backlight = true});
            lc.Keyboard.Add(new Keyboard() { Language = "Japanese", Layout = "qwerty", Numpad = true, Backlight = true});

            lc.Order.Add(new Order() { AddressId = 1, CustomerId = 1});
            lc.Order.Add(new Order() { AddressId = 2, CustomerId = 2});
            lc.Order.Add(new Order() { AddressId = 3, CustomerId = 3});
            lc.Order.Add(new Order() { AddressId = 4, CustomerId = 4});
            lc.Order.Add(new Order() { AddressId = 5, CustomerId = 5});
            lc.Order.Add(new Order() { AddressId = 6, CustomerId = 6});
            lc.Order.Add(new Order() { AddressId = 7, CustomerId = 1});
            lc.Order.Add(new Order() { AddressId = 8, CustomerId = 7});
            lc.Order.Add(new Order() { AddressId = 1, CustomerId = 8});
            lc.Order.Add(new Order() { AddressId = 9, CustomerId = 1});
            lc.Order.Add(new Order() { AddressId = 1, CustomerId = 1});
            lc.Order.Add(new Order() { AddressId = 2, CustomerId = 2});
            lc.Order.Add(new Order() { AddressId = 3, CustomerId = 3});
            lc.Order.Add(new Order() { AddressId = 4, CustomerId = 4});
            lc.Order.Add(new Order() { AddressId = 5, CustomerId = 5});
            lc.Order.Add(new Order() { AddressId = 6, CustomerId = 6});
            lc.Order.Add(new Order() { AddressId = 7, CustomerId = 7});
            lc.Order.Add(new Order() { AddressId = 8, CustomerId = 8});
            lc.Order.Add(new Order() { AddressId = 9, CustomerId = 9});
    }
}
