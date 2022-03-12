using AhoyHotelApi;
using AhoyHotelApi.Controllers;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace UnitsOfTest.Booking
{
    public class BookingTest : IClassFixture<>
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
        public void CreateBookig()
        {
            BookingController hotelController = new BookingController(MockContext.Object, _mapper);

        }

    }

}
