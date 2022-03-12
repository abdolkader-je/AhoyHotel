using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.DataTransferObjects.Commons;
using Entities.DataTransferObjects.Hotel;
using Microsoft.AspNetCore.Mvc;

namespace AhoyHotelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public HotelController(IUnitOfWork unitOfWork, 
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        [HttpGet]
        [Route(ApiRoute.HotelRoutes.GetAllHotels)]
        public async Task<IActionResult> GetHotels([FromQuery] RequestParams requestParams)
        {
            var hotels = await _unitOfWork.Hotels.GetPagedList(requestParams);
            var results = _mapper.Map<IList<HotelDto>>(hotels);
            HotelListResponseDto hotelListResponseDto = new()
            {
                Data = results,
                ResponseMessage = "Requested Successfully",
                StatusCode = 200
            };

            return Ok(hotelListResponseDto);
        }

        [HttpGet]
        [Route(ApiRoute.HotelRoutes.GetHotelDetails)]
        public async Task<IActionResult> GetHotelDetails(string hotelName)
        {
            var hotel = await _unitOfWork.Hotels.Get(q => q.Name == hotelName);
            var result = _mapper.Map<HotelDetailsDto>(hotel);
            HotelDetailsResponseDto hotelResponseDetailsDto = new()
            {
                Data = result,
                ResponseMessage= "Requested Successfully",
                StatusCode=200
            };
            return Ok(hotelResponseDetailsDto);
        }

        [HttpGet]
        [Route(ApiRoute.HotelRoutes.SearchHotels)]
        public async Task<IActionResult> SearchHotels(string searchTerm)
        {
            var hotels = await _unitOfWork.Hotels.GetAll(q => q.Name.Contains(searchTerm));
            var results = _mapper.Map<IList<HotelDto>>(hotels);
            HotelListResponseDto hotelListResponseDto = new()
            {
                Data = results,
                ResponseMessage = "Requested Successfully",
                StatusCode = 200
            };
            return Ok(hotelListResponseDto);
        }      
    }
}
