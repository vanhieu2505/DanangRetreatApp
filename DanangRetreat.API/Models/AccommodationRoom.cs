namespace DanangRetreat.API.Models
{
    public class AccommodationRoom
    {
        public int AccommodationId { get; set; }
        public Accommodation Accommodation { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}