using Contracts;
using Domain.Entities;
using Entities;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IBaseRepository<Hotel> _hotels;
        private IBaseRepository<Room> _rooms;
        private IBaseRepository<Booking> _bookings;
        private IBaseRepository<Facility> _facilities;
        private IBaseRepository<HotelFacility> _hotelFacilities;
        private IBaseRepository<Review> _reviews;
        public UnitOfWork(DatabaseContext context) => _context = context;
        public IBaseRepository<Hotel> Hotels => _hotels ??= new BaseRepository<Hotel>(_context);
        public IBaseRepository<Room> Rooms => _rooms ??= new BaseRepository<Room>(_context);
        public IBaseRepository<Booking> Bookings => _bookings ??= new BaseRepository<Booking>(_context);
        public IBaseRepository<Facility> Facilities => _facilities ??= new BaseRepository<Facility>(_context);
        public IBaseRepository<HotelFacility> HotelFacilities => _hotelFacilities ??= new BaseRepository<HotelFacility>(_context);
        public IBaseRepository<Review> Reviews => _reviews ??= new BaseRepository<Review>(_context);
        public async Task Save() => await _context.SaveChangesAsync();
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
