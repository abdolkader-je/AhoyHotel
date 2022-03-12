using AhoyHotelApi;
using AhoyHotelApi.Controllers;
using AutoMapper;
using Contracts;
using Moq;
using Xunit;

public class HotelsTest
{

    private static IMapper _mapper;
    private static Mock<IUnitOfWork> _hotelMock;
    public HotelsTest()
    {
        if (_mapper == null)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            _mapper = mapper;
        }
        
    }
    [Fact]
    public void AddHotel()
    {
        HotelController hotelController = new HotelController(_hotelMock.Object, _mapper);
        var result = hotelController.GetHotelDetailsById(1);
        //Assert.IsType<IActionResult<HotelDetailsResponseDto>>(result);
    }
   
}
