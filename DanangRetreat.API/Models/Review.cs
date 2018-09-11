using System;

namespace DanangRetreat.API.Models
{
    public class Review
    {
        public int Id { get; set; }
        public short Star { get; set; }
        public string Content { get; set; }
        public int AccommodationId { get; set; }
        public Accommodation Accommodation { get; set; }
        public int ReviewTypeId { get; set; }
        public ReviewType ReviewType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}