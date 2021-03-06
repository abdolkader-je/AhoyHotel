using Domain.Entities;
using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Entities
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public async Task<int> SaveChangesAsync()
        {
            UpdateLastModified();
            return await base.SaveChangesAsync();
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelFacility> HotelFacilities { get; set; }
        public DbSet<HotelImage> HotelImages { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Room> Rooms { get; set; }
        private void UpdateLastModified()
        {
            var LastModified = "LastModified";
            ChangeTracker.DetectChanges();
            var modified = ChangeTracker.Entries().Where(x => x.State == EntityState.Modified);
            foreach (EntityEntry entity in modified)
            {
                foreach (PropertyEntry prop in entity.Properties)
                {
                    if (prop.Metadata.Name == LastModified)
                    {
                        entity.CurrentValues[LastModified] = DateTime.Now;
                    }
                }
            }
        }
    }
}
