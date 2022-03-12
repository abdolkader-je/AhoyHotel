using Entities.DataTransferObjects.Commons;

namespace Entities.DataTransferObjects.Hotel
{
    public class HotelDetailsResponseDto: BaseResponse
    {
        public HotelDetailsDto Data { get; set; }
    }
}
