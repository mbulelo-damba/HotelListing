using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.Data
{
    public class Hotel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }


        [ForeignKey(nameof(Country))]
        public int FKCountryID { get; set; }
        public Country Country { get; set; }

    }
}
