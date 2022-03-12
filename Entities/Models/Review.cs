using static Entities.Enums.ReviewEnums;

namespace Domain.Entities;
public class Review : BaseEntity
{
    public string? ReviewerName { get; set; }
    public string? ReviewerEmail { get; set; }
    public string? Description { get; set; }
    public RatingScale RatingScale { get; set; }
    public int HotelId { get; set; }
    public virtual Hotel? Hotel { get; set; }
}
