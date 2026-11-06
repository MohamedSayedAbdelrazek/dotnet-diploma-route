using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_2.Models
{
    internal class OrganizerProfile
    {
        public int Id { get; set; }
        public string? Biography { get; set; }
        public string? CompanyWebsite {get;set;}
        public string? LogoUrl { get; set; }
        public Organizer Organizer { get; set; } = null!;
        public int OrganizerId { get; set; }

    }
}
