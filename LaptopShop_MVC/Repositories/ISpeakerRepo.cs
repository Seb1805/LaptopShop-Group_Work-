using LaptopShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop_MVC.Repositories
{
    interface ISpeakerRepo
    {
        public Speaker GetSpeakerById(int id);
        public IEnumerable<Speaker> GetSpeakerByDescription(string desc);
    }
}
