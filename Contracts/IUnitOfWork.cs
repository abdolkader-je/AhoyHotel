using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{

    public interface IUnitOfWork : IDisposable
    {

        IBaseRepository<Hotel> Hotels { get; }
        IBaseRepository<Room> Rooms { get; }
        IBaseRepository<Booking> Bookings { get; }
        //IBaseRepository<Facility> Facilities { get; }
        //IBaseRepository<HotelFacility> HotelFacilities { get; }
        //IBaseRepository<HotelImage> HotelImages { get; }
        //IBaseRepository<Review> Reviews { get; }
        Task Save();
    }
}
