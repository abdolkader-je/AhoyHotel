using Contracts;
using Domain.Entities;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;

        private IBaseRepository<Hotel> _hotels;
        private IBaseRepository<Room> _rooms;
        private IBaseRepository<Booking> _bookings;
        //private IBaseRepository<Booking> _bookings;
        //private IBaseRepository<Booking> _bookings;
        //private IBaseRepository<Booking> _bookings;
        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }
        public IBaseRepository<Hotel> Hotels => _hotels ??= new BaseRepository<Hotel>(_context);
        public IBaseRepository<Room> Rooms => _rooms ??= new BaseRepository<Room>(_context);
        public IBaseRepository<Booking> Bookings => _bookings ??= new BaseRepository<Booking>(_context);
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
