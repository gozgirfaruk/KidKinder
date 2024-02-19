using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinder.Models.Entities
{
    public class Student
    {
        public int StudentID { get; set; }
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public DateTime  BirthDay { get; set; }
        public int ParentID { get; set; }
        public bool Status { get; set; }

    }
}