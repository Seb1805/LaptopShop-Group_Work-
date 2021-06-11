using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopShop.Repositories
{
    interface ISpeakerRepo
    {
        public Speakers GetSpeakerById(int id);
        public IEnumerable<Speakers> GetSpeakerByDescription(string desc);
    }
}
