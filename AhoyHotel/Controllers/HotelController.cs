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
        [Route(ApiRoute.HotelRoutes.GetHotelDetailsById)]
        public async Task<IActionResult> GetHotelDetailsById(int hotelId)
        {
            var hotel = await _unitOfWork.Hotels.Get(q => q.Id == hotelId);
            var result = _mapper.Map<HotelDetailsDto>(hotel);
            HotelDetailsResponseDto hotelResponseDetailsDto = new()
            {
                Data = result,
                ResponseMessage = "Requeste Completed Successfully",
                StatusCode = 200
            };
            return Ok(hotelResponseDetailsDto);
        }

        [HttpGet]
        [Route(ApiRoute.HotelRoutes.GetAllHotels)]
        public async Task<IActionResult> GetAllHotels([FromQuery] RequestParams requestParams)
        {
            var hotels = await _unitOfWork.Hotels.GetPagedList(requestParams);
            var results = _mapper.Map<IList<HotelDto>>(hotels);
            HotelListResponseDto hotelListResponseDto = new()
            {
                Data = results,
                ResponseMessage = "Requeste Completed Successfully",
                StatusCode = 200
            };

            return Ok(hotelListResponseDto);
        }


        [HttpGet]
        [Route(ApiRoute.HotelRoutes.SearchInHotels)]
        public async Task<IActionResult> SearchInHotels(string searchTerm)
        {
            var hotels = await _unitOfWork.Hotels.GetAll(q => q.Name.Contains(searchTerm));
            var results = _mapper.Map<IList<HotelDto>>(hotels);
            HotelListResponseDto hotelListResponseDto = new()
            {
                Data = results,
                ResponseMessage = "Requeste Completed Successfully",
                StatusCode = 200
            };
            return Ok(hotelListResponseDto);
        }      
    }
}
