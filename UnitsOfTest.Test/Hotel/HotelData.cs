using Entities.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfTest.Hotel
{
    public class HotelData
    {
        public static HotelDetailsDto MockHotelDetailsDto() => new()
        {
            Name = "Ahoy",
            Address = "Dubai",
            Contact= "97555555555",
            Description = "New",
            Email= "Ahoy@hotel.com",
            HotelFacilities=null,
            HotelImages=null,   
            Location =null,


        };
    }
}
