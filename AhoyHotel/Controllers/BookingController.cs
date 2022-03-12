using AutoMapper;
using Contracts;
using Domain.Entities;
using Entities.DataTransferObjects;
using Entities.DataTransferObjects.Commons;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AhoyHotelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;

        public BookingController(IUnitOfWork unitOfWork, 
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        //[Authorize(Roles = "User")]
        [HttpPost]
        [Route(ApiRoute.BookingRoutes.AddBooking)]
        public async Task<IActionResult> CreateBooking([FromBody] AddBookingDto BookingDTO)
        {
            Booking Booking = mapper.Map<AddBookingDto, Booking>(BookingDTO);
            await _unitOfWork.Bookings.Insert(Booking);
            await _unitOfWork.Save();
            BaseResponse response= new() { ResponseMessage = "booking added successfully", StatusCode = 200 };
            return Ok(response);
        }

    }
}
