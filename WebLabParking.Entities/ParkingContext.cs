using Microsoft.EntityFrameworkCore;

namespace WebLabParking.Entities
{
    public class ParkingContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientCars> ClientCars { get; set; }
        public DbSet<Parking> Parkings { get; set; }
        public DbSet<ParkingPlace> ParkingPlaces { get; set; }
        public DbSet<ParkingTicket> ParkingTickets { get; set; }

        public ParkingContext(DbContextOptions<ParkingContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}