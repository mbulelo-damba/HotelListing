using System.Collections.Generic;

namespace HotelListing.Data
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }

        public virtual IList<Hotel> Hotels { get; set; }
    }
}
