using AutoMapper;
using Domain.Entities;
using Entities.DataTransferObjects;
using Entities.DataTransferObjects.Hotel;

namespace AhoyHotelApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Booking, AddBookingDto>();
            CreateMap<AddBookingDto, Booking>()
           .ForMember(d => d.UserId, opt => opt.MapFrom(r => r.UserId));
;


            CreateMap<Hotel, HotelDetailsDto>().ReverseMap();
            CreateMap<Hotel, HotelDto>().ReverseMap();
        }
    }
}
