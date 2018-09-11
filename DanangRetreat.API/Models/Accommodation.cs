using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DanangRetreat.API.Models
{
    public class Accommodation
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public int MaximumGuestAllowed { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public string Introduction { get; set; }
        public string YourSpace { get; set; }
        public string GuestAccess { get; set; }
        public string HouseRule { get; set; }
        public int NumberOfBathrooms { get; set; }        
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<AccommodationRoom> Rooms { get; set; }
        public string GoogleMapLocation { get; set; }        
    }
}