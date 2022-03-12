using static Entities.Enums.RoomEnums;

namespace Domain.Entities;
public class Room : BaseEntity
{
    public Room() => IsBooked = false;
    public bool IsBooked { get; set; }
    public int RoomNumber { get; set; }
    public RoomType RoomType { get; set; }
    public int HotelId { get; set; }
    public virtual Hotel Hotel { get; set; }
}
