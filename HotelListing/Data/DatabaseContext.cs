using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Hotel> Hotels { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    ID = 1,
                    Name = "South Africa",
                    CountryCode = "ZAF"

                },
                new Country
                {
                    ID = 2,
                    Name = "Mozambique",
                    CountryCode = "MOZ"

                },
                new Country
                {
                    ID = 3,
                    Name = "Kenya",
                    CountryCode = "KEN"

                }
                );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    ID = 1,
                    Name = "Mahali Mzuri",
                    Address = "Motorogi Conservancy Masai Mara, Kenya",
                    Rating = 4.8,
                    FKCountryID = 3

                },
                new Hotel
                {
                    ID = 2,
                    Name = "The Houghton Hotel",
                    Address = "Lloys Ellis Ave, Houghton Estate, Johannesburg, 2198",
                    Rating = 4.7,
                    FKCountryID = 1

                },
                new Hotel
                {
                    ID = 3,
                    Name = "Polana Serena Hotel",
                    Address = "1380 Av. Julius Nyerere, Maputo, Mozambique",
                    Rating = 4.6,
                    FKCountryID = 2

                }
                );

        }



    }
}
