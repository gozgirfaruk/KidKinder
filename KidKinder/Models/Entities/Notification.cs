using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinder.Models.Entities
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public string Title { get; set; }
        public string  ImageUrl { get; set; }
        public string  Description { get; set; }
        public DateTime  NotificationsDate { get; set; }
}
}