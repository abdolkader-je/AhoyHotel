using Domain.Entities;
using Entities.DataTransferObjects.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{

    public class HotelDetailsDto
    {
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

        public int? NumberOfRooms { get; set; }
        public int? RatingScale { get; set; }
    }
}
