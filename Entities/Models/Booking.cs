using Entities.Models;
using System.ComponentModel.DataAnnotations.Schema;
using static Entities.Enums.RoomEnums;

namespace Domain.Entities;
public class Booking : BaseEntity
{
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public bool IsConfirmed { get; set; }
    public double ActualPrice { get; set; }
    public double Discount { get; set; }
    public double PaidAmount { get; set; }
    [ForeignKey(nameof(ApplicationUser))]

    public string UserId { get; set; }
    public string UserName { get; set; }
    [ForeignKey(nameof(Room))]

    public int RoomId { get; set; }
    public RoomType RoomType { get; set; }
    public Room Room { get; set; }
    //public virtual ApplicationUser ApplicationUser { get; set; }

}
