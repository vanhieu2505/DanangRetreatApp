namespace DanangRetreat.API.Models
{
    public class RoomBed
    {
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int BedId { get; set; }
        public Bed Bed { get; set; }
    }
}