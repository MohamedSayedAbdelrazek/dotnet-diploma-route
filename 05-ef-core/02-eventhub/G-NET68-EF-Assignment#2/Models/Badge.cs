using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_2.Models
{
    internal class Badge
    {
        public int Id { get; set; }
        public string BadgeNumber { get; set; } = string.Empty;
        public DateTime IssuedDate { get; set; }
        public BadgeTier Tier { get; set; }
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }
    }
}
