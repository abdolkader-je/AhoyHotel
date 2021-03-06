using Entities.Models;
using System.ComponentModel.DataAnnotations;
namespace Domain.Entities;
public class Hotel : BaseEntity
{
    public Hotel()
    {
        HotelFacilities = new List<HotelFacility>();
        HotelImages = new List<HotelImage>();
        Rooms = new List<Room>();
        Reviews = new List<Review>();
    }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Contact { get; set; }
    public string Address { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
    public virtual List<HotelFacility> HotelFacilities { get; set; }
    public virtual List<HotelImage> HotelImages { get; set; }
    public virtual List<Room> Rooms { get; set; }
    public virtual List<Review> Reviews { get; set; }
}
