using Entities.DataTransferObjects;

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
            NumberOfRooms=0,
            RatingScale = null,
            Reviews=   null,
            Rooms = null,
        };
    }
}
