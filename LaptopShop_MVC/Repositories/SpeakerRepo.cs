using LaptopShop_MVC.Data;
using LaptopShop_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaptopShop_MVC.Repositories
{
    class SpeakerRepo : ISpeakerRepo
    {
        private readonly LaptopContext _context;

        public SpeakerRepo(LaptopContext context)
        {
            _context = context;
        }
        public IEnumerable<Speaker> GetSpeakerByDescription(string description)
        {
            return _context.Speakers.Where(s => s.Description == description);
        }

        public Speaker GetSpeakerById(int id)
        {
            return _context.Speakers.FirstOrDefault(s => s.SpeakerId == id);
        }
    }
}
