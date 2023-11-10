using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.EntityLayer.Concrete
{
    public class Room
    {
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public byte BedCount { get; set; }
        public byte BathCount { get; set; }
        public bool Wifi { get; set; }
        public string Description { get; set; }
    }
}
