using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Models
{
    public class Storage
    {
        public int StorageId { get; set; }
        public int Capacity { get; set; }
        public string Type { get; set; }
        public int Brand { get; set; }
        public int ReadSpeed { get; set; }
        public int WriteSpeed { get; set; }
        public string ModelNumber { get; set; }

    }
}
