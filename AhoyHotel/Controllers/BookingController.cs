using AutoMapper;
using Contracts;
using Domain.Entities;
using Entities.DataTransferObjects;
using InsurAggrigator.API.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AhoyHotelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<BookingController> _logger;
        private readonly IMapper _mapper;

        public BookingController(IUnitOfWork unitOfWork, ILogger<BookingController> logger,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            this._mapper = mapper;
        }

        //[Authorize(Roles = "User")]
        [HttpPost]
        [Route(ApiRoute.BookingRoute.AddBooking)]
        public async Task<IActionResult> CreateBooking([FromBody] AddBookingDto BookingDTO)
        {


            var Booking = _mapper.Map<AddBookingDto, Booking>(BookingDTO);
            await _unitOfWork.Bookings.Insert(Booking);
            await _unitOfWork.Save();

            return CreatedAtRoute("CreateBooking", new { id = Booking.Id }, Booking);
        }

    }
}
