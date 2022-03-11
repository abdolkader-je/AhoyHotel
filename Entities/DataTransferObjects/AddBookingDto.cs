using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.Enums.RoomEnums;

namespace Entities.DataTransferObjects
{
    public class AddBookingDto
    {
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Price { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public RoomType RoomType { get; set; }

    }
}
