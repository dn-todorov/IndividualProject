using IndividualProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IndividualProject.Infrastructure.Data
{
    public class IndividualProjectDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<OfficeRoom> OfficeRooms { get; set; }
        public DbSet<ParkingSpot> ParkingSpots { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Track> Tracks { get; set; }

        public IndividualProjectDbContext(DbContextOptions<IndividualProjectDbContext> options) : base(options)
        {

        }
    }
}
