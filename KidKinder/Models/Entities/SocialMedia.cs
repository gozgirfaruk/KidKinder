using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinder.Models.Entities
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }
        public string  Name { get; set; }
        public string IconUrl { get; set; }
        public string  AddressUrl { get; set; }

    }
}