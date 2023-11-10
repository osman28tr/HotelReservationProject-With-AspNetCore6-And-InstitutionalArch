using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.EntityLayer.Concrete
{
    public class Staff:BaseEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public ICollection<SocialMedia> SocialMedias { get; set; }
    }
}
