using System.Collections.Generic;

namespace DanangRetreat.API.Models
{
    public class ReviewType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}