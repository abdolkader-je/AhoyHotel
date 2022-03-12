using Entities.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfTest.Booking
{
    public class BookingData
    {
        public static AddBookingDto MockAddBookingRequest() => new()
        {
            CheckIn = DateTime.Now,
            CheckOut = DateTime.Now.AddDays(30),
            UserId = "",
            Price="10000",
            RoomType= Entities.Enums.RoomEnums.RoomType.Single,
        };
    }
}
