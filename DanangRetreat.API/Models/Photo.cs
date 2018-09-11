using System;

namespace DanangRetreat.API.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public bool IsMain { get; set; }
        public string PhotoUrl { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime CreatedDate { get; set; }    
        public int AccommodationId { get; set; }
        public Accommodation Accommodation { get; set; }    
    }
}