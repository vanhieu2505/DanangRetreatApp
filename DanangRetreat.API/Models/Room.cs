using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DanangRetreat.API.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Type { get; set; }        
        public ICollection<AccommodationRoom> Accommodations { get; set; }
        public ICollection<RoomBed> Beds { get; set; }
    }
}