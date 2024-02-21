using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinder.Models.Entities
{
    public class SendMess
    {
        public int SendMessID { get; set; }
        public string MessHeader { get; set; }
        public string Message { get; set; }
        public int ContactID { get; set; }
    }
}