using G_NET68_EF_Assignment_2.Configurations;
using G_NET68_EF_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET68_EF_Assignment_2.Contexts
{
    internal class EventHubDbContext : DbContext
    {
        public DbSet<Organizer> Organizers { get; set; } = null!;
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; } = null!;
        public DbSet<Event> Events { get; set; } = null!;
        public DbSet<Attendee> Attendees { get; set; } = null!;
        public DbSet<Badge> Badges { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=EventHub;Trusted_Connection=True; TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            {
                modelBuilder.ApplyConfiguration(new OrganizerProfileConfiguration());
                modelBuilder.ApplyConfiguration(new BadgeConfiguration());

                modelBuilder.Entity<Event>(builder =>
                {
                    builder.ToTable("Events");

                    builder.HasKey(e => e.Id);

                    builder.Property(e => e.Title)
                           .IsRequired();

                    builder.Property(e => e.Description)
                           .IsRequired();

                    builder.HasOne(e => e.Organizer)
                    .WithMany(o => o.Events)
                    .HasForeignKey(e => e.OrganizerId)
                    .IsRequired();
                });
            }
        }
    }
}
