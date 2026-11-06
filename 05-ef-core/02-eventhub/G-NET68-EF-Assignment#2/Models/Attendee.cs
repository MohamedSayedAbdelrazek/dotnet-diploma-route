using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_2.Models
{
    internal class Attendee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string FullName { get; set; } = String.Empty;

        [Required]
        [MaxLength(200)]
        public string Email { get; set; } = String.Empty;

        [Required]
        [MaxLength(150)]
        public string Street { get; set; } = String.Empty;

        [Required]
        [MaxLength(100)]
        public string City { get; set; } = String.Empty;

        [Required]
        [MaxLength(100)]
        public string Country { get; set; } = String.Empty;

        [Required]
        [MaxLength(20)]
        [Column("ZipCode")]
        public string PostalCode { get; set; } = String.Empty;

        [NotMapped]
        public string FullAddress => $"{Street}, {City}, {Country}, {PostalCode}";

        public Badge? Badge { get; set; }


    }
}
