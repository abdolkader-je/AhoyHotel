using AutoMapper;
using Domain.Entities;
using Entities.DataTransferObjects;

namespace Configurations
{
  
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Booking, AddBookingDto>();
            CreateMap<AddBookingDto, Booking>();


            CreateMap<Hotel, HotelDTO>().ReverseMap();
            CreateMap<Hotel, CreateHotelDTO>().ReverseMap();
        }
    }
}