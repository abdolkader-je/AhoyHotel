using AutoMapper;
using Contracts;
using Domain.Entities;
using Entities.DataTransferObjects;
using Entities.DataTransferObjects.Commons;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AhoyHotelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;
        private readonly ClaimsPrincipal _claimsPrincipal;
        public readonly string _userId;

        public BookingController(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
            _claimsPrincipal = httpContextAccessor.HttpContext.User;
            Claim userClaim = _claimsPrincipal.Claims.FirstOrDefault(c => c.Type == "userId");
            _userId = userClaim.Value;
        }

        [Authorize]
        [HttpPost]
        [Route(ApiRoute.BookingRoutes.AddBooking)]
        public async Task<IActionResult> CreateBooking([FromBody] AddBookingDto addBookingDto)
        {
            Booking booking = mapper.Map<AddBookingDto, Booking>(addBookingDto);
            booking.UserId = _userId;
            await _unitOfWork.Bookings.AddAsync(booking);
            await _unitOfWork.Save();
            BaseResponse response= new() { ResponseMessage = "booking added successfully", StatusCode = 200 };
            return Ok(response);
        }

    }
}
