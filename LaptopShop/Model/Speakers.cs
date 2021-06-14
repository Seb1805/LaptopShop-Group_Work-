using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LaptopShop.Model
{
    class Speakers
    {
        [Key]
        public int SpeakerId { get; set; }
        public string Description { get; set; }
    }
}
