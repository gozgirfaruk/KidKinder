﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinder.Models.Entities
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public  string NameSurname { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}