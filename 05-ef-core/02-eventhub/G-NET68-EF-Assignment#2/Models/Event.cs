using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_2.Models
{
    internal class Event
    {
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaximumAttendees { get; set; }
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; } = null!;
    }
}
