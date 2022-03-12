using Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;
using static Entities.Enums.RoomEnums;

namespace Domain.Entities;
public class Booking : BaseEntity
{
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public bool IsConfirmed { get; set; }
    public decimal Price { get; set; }
    [ForeignKey(nameof(ApplicationUser))]
    public string UserId { get; set; }
    [ForeignKey(nameof(Room))]

    public int RoomId { get; set; }
    public RoomType RoomType { get; set; }
    public virtual Room Room { get; set; }
    public virtual ApplicationUser ApplicationUser { get; set; }

}
