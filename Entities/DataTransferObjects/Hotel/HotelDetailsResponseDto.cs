using Entities.DataTransferObjects.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects.Hotel
{
    public class HotelDetailsResponseDto: BaseResponse
    {
        public HotelDetailsDto Data { get; set; }
    }
}
