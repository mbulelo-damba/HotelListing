using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 60, ErrorMessage = "Country Name is too long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Country Code is too long")]
        public string CountryCode { get; set; }
    }

    public class CountryDTO : CreateCountryDTO
    {
        public int ID { get; set; }

        public virtual IList<HotelDTO> Hotels { get; set; }

    }


}
