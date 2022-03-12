using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;
public class HotelFacility : BaseEntity
{
    public int FacilityId { get; set; }
    public virtual Facility? Facility { get; set; }
    [ForeignKey(nameof(Hotel))]
    public int HotelId { get; set; }
    public virtual Hotel? Hotel { get; set; }
}
