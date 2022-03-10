using Domain.Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IDatabaseContext
    {
        DbSet<ApplicationUser> ApplicationUsers { get; set; }
        DbSet<Booking> Bookings { get; set; }
        DbSet<Facility> Facilities { get; set; }
        DbSet<Hotel> Hotels { get; set; }
        DbSet<HotelFacility> HotelFacilities { get; set; }
        DbSet<HotelImage> HotelImages { get; set; }
        DbSet<Review> Reviews { get; set; }
        DbSet<Room> Rooms { get; set; }
        Task<int> SaveChangesAsync();
    }

}
