using IndividualProject.Common.Helpers;
using IndividualProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IndividualProject.Infrastructure.Data
{
    public class IndividualProjectDbContext : DbContext
    {
        //check the comments, add database validation to some fields(eg. Registration Plates)
        public IndividualProjectDbContext(DbContextOptions<IndividualProjectDbContext> options) : base(options)
        { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<OfficeRoom> OfficeRooms { get; set; }
        public DbSet<ParkingSpot> ParkingSpots { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Track> Tracks { get; set; }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            base.ConfigureConventions(builder);

            builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter, DateOnlyComparer>()
                .HaveColumnType("date");

            builder.Properties<TimeOnly>()
                .HaveConversion<TimeOnlyConverter, TimeOnlyComparer>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable(nameof(Team));

                entity.HasKey(e => e.TeamID);

                //entity.Property(e => e.TeamName).IsRequired();
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable(nameof(Car));

                entity.HasKey(e => e.CarID);

                //entity.Property(e => e.CarBrand).IsRequired();
            });

            modelBuilder.Entity<OfficeRoom>(entity =>
            {
                entity.ToTable(nameof(OfficeRoom));

                entity.HasKey(e => e.OfficeRoomID);

                //entity.Property(e => e.RoomName).IsRequired();
            });

            modelBuilder.Entity<ParkingSpot>(entity =>
            {
                entity.ToTable(nameof(ParkingSpot));

                entity.HasKey(e => e.ParkingSpotID);

                //entity.Property(e => e.SpotName).IsRequired();
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable(nameof(Employee));

                entity.HasKey(e => e.EmployeeID);

                //entity.Property(e => e.FirstName).IsRequired();
                //entity.Property(e => e.LastName).IsRequired();
                //entity.Property(e => e.Team).IsRequired();
            });

            modelBuilder.Entity<Track>(entity =>
            {
                entity.ToTable(nameof(Track));

                entity.HasKey(e => e.TrackID);

                //entity.Property(e => e.OccupationDate).IsRequired();

                //These two might be wrong to exist. Not all employees might go with cars.
                //entity.Property(e => e.ParkingArrivalTime).IsRequired();
                //entity.Property(e => e.ParkingDepartureTime).IsRequired();

                //entity.Property(e => e.Employee).IsRequired();

                //entity.Property(e => e.OfficeRooms).IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
