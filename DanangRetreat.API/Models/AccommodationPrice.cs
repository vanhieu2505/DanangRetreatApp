namespace DanangRetreat.API.Models
{
    public class AccommodationPrice
    {
        public int Id { get; set; }
        public int AccommodationId { get; set; }
        public Accommodation Accommodation { get; set; }
        public int NumberOfGuests { get; set; }
        public decimal Price { get; set; }
    }
}