using AhoyHotelApi;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Moq;
using System;
using System.Security.Claims;
using Xunit;

namespace UnitsOfTest.Booking
{
    public class BookingTest 
    {
        private static IMapper _mapper;
        private readonly Mock<IUnitOfWork> MockContext;

        public BookingTest()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new MappingProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }
            MockContext = new Mock<IUnitOfWork>();
        }

        [Fact]
        public void CreateABookig()
        {
           // BookingController hotelController = new BookingController(MockContext.Object, _mapper );
           // var result = hotelController.CreateBooking(MockAddBookingRequest());
          //  Assert.IsType<IActionResult<HotelDetailsResponseDto>>(result);
        }
        private AddBookingDto MockAddBookingRequest() => new()
        {
            CheckIn = DateTime.Now,
            CheckOut = DateTime.Now.AddDays(30),
            UserId = "",
            Price = "10000",
            RoomType = Entities.Enums.RoomEnums.RoomType.Single,
        };

    }

}
