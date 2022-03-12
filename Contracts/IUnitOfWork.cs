using Domain.Entities;

namespace Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Hotel> Hotels { get; }
        IBaseRepository<Room> Rooms { get; }
        IBaseRepository<Booking> Bookings { get; }
        IBaseRepository<Facility> Facilities { get; }
        IBaseRepository<HotelFacility> HotelFacilities { get; }
        IBaseRepository<Review> Reviews { get; }
        Task Save();
    }
}
