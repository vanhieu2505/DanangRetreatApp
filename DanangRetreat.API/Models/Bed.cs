using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DanangRetreat.API.Models
{
    public class Bed
    {
        public int Id { get; set; }
        public string Type { get; set; }           
        public ICollection<RoomBed> Rooms { get; set; }        
    }
}