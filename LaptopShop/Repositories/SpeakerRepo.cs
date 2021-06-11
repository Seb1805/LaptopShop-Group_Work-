using LaptopShop.Data;
using LaptopShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaptopShop.Repositories
{
    class SpeakerRepo : ISpeakerRepo
    {
        private readonly LaptopContext _context;

        public SpeakerRepo(LaptopContext context)
        {
            _context = context;
        }
        public IEnumerable<Speakers> GetSpeakerByDescription(string description)
        {
            return _context.Speakers.Where(s => s.Description == description);
        }

        public Speakers GetSpeakerById(int id)
        {
            return _context.Speakers.FirstOrDefault(s => s.SpeakersId == id);
        }
    }
}
