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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable(nameof(Team));

                entity.Property(e => e.TeamName).IsRequired();

                entity.HasData(
                    new Team { Id = 1, TeamName = "BA" },
                    new Team { Id = 2, TeamName = "HR" },
                    new Team { Id = 3, TeamName = "Sys Admin" },
                    new Team { Id = 4, TeamName = "DevOps" },
                    new Team { Id = 5, TeamName = "Java" },
                    new Team { Id = 7, TeamName = "AM" },
                    new Team { Id = 6, TeamName = ".NET" },
                    new Team { Id = 8, TeamName = "FO" }
                );
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable(nameof(Car));

                entity.Property(e => e.CarBrand).IsRequired();
                entity.Property(e => e.RegistrationPlate).IsRequired();

                entity.HasData(
                    new Car { Id = 1, CarBrand = "Mercedes", RegistrationPlate = "СВ3728КА" },
                    new Car { Id = 2, CarBrand = "Kia", RegistrationPlate = "Х7728МА" },
                    new Car { Id = 3, CarBrand = "Honda", RegistrationPlate = "СТ3729ТТ" },
                    new Car { Id = 4, CarBrand = "BMW", RegistrationPlate = "ЕА2718ХН" },
                    new Car { Id = 5, CarBrand = "Volkswagen", RegistrationPlate = "СС2819КК" },
                    new Car { Id = 6, CarBrand = "Volkswagen", RegistrationPlate = "А2171ВА" },
                    new Car { Id = 7, CarBrand = "Porsche", RegistrationPlate = "ТХ1729СА" },
                    new Car { Id = 8, CarBrand = "BMW", RegistrationPlate = "РВ4568СС" },
                    new Car { Id = 9, CarBrand = "Mazda", RegistrationPlate = "В4568ТХ" }
                    );
            });

            modelBuilder.Entity<OfficeRoom>(entity =>
            {
                entity.ToTable(nameof(OfficeRoom));

                entity.Property(e => e.RoomName).IsRequired();

                entity.HasData(
                    new OfficeRoom { Id = 2, RoomName = "Room 403" },
                    new OfficeRoom { Id = 1, RoomName = "Room 404" }
                    );
            });

            modelBuilder.Entity<ParkingSpot>(entity =>
            {
                entity.ToTable(nameof(ParkingSpot));

                entity.Property(e => e.SpotName).IsRequired();

                entity.HasData(
                    new ParkingSpot { Id = 1, SpotName = "Parking spot 1" },
                    new ParkingSpot { Id = 2, SpotName = "Parking spot 2" },
                    new ParkingSpot { Id = 3, SpotName = "Parking spot 3" },
                    new ParkingSpot { Id = 4, SpotName = "Parking spot 4" }
                    );
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable(nameof(Employee));

                entity.Property(e => e.FirstName).IsRequired();
                entity.Property(e => e.LastName).IsRequired();
                entity.Property(e => e.TeamID).IsRequired();

                entity.HasData(
                    new Employee { Id = 1, FirstName = "Петър", LastName = "Петров", TeamID = 1, CarID = 1 },
                    new Employee { Id = 2, FirstName = "Георги", LastName = "Георгиев", TeamID = 2, CarID = 2 },
                    new Employee { Id = 3, FirstName = "Димитър", LastName = "Димитров", TeamID = 3, CarID = 3 },
                    new Employee { Id = 4, FirstName = "Иван", LastName = "Иванов", TeamID = 4, CarID = 4 },
                    new Employee { Id = 5, FirstName = "Михаела", LastName = "Милева", TeamID = 5, CarID = 5 },
                    new Employee { Id = 6, FirstName = "Диан", LastName = "Дичев", TeamID = 6, CarID = 6 },
                    new Employee { Id = 7, FirstName = "Пенчо", LastName = "Пенчев", TeamID = 7, CarID = 7 },
                    new Employee { Id = 8, FirstName = "Даниела", LastName = "Димитрова", TeamID = 8, CarID = 8 },
                    new Employee { Id = 9, FirstName = "Николай", LastName = "Калайджиев", TeamID = 1, CarID = 9 },
                    new Employee { Id = 10, FirstName = "Иво", LastName = "Иванов", TeamID = 7, CarID = null },
                    new Employee { Id = 11, FirstName = "Елена", LastName = "Парнарева", TeamID = 3, CarID = null },
                    new Employee { Id = 12, FirstName = "Деница", LastName = "Георгиева", TeamID = 5, CarID = null },
                    new Employee { Id = 13, FirstName = "Ясен", LastName = "Николов", TeamID = 4, CarID = null }
                    );
            });

            modelBuilder.Entity<Track>(entity =>
            {
                entity.ToTable(nameof(Track));

                entity.Property(e => e.OccupationDate).IsRequired();

                //TODO
                //These two might be wrong to exist. Not all employees might go with cars.
                //entity.Property(e => e.ParkingArrivalTime).IsRequired();
                //entity.Property(e => e.ParkingDepartureTime).IsRequired();

                entity.Property(e => e.EmployeeID).IsRequired();

                entity.Property(e => e.OfficeRoomID).IsRequired();

                entity.HasData(
                    new Track
                    {
                        Id = 1,
                        OccupationDate = DateOnly.FromDateTime(DateTime.Now),
                        ParkingArrivalTime = TimeOnly.FromDateTime(DateTime.Now),
                        ParkingDepartureTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(8)),
                        Note = null,
                        EmployeeID = 3,
                        OfficeRoomID = 2,
                        ParkingSpotID = 2
                    },
                    new Track
                    {
                        Id = 2,
                        OccupationDate = DateOnly.FromDateTime(DateTime.Now),
                        ParkingArrivalTime = TimeOnly.FromDateTime(DateTime.Now),
                        ParkingDepartureTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(8)),
                        Note = "Тест тест тест",
                        EmployeeID = 6,
                        OfficeRoomID = 1,
                        ParkingSpotID = 4
                    },
                    new Track
                    {
                        Id = 3,
                        OccupationDate = DateOnly.FromDateTime(DateTime.Now),
                        ParkingArrivalTime = TimeOnly.FromDateTime(DateTime.Now),
                        ParkingDepartureTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(8)),
                        Note = "Lorem ipsum",
                        EmployeeID = 5,
                        OfficeRoomID = 1,
                        ParkingSpotID = 1
                    },
                    new Track
                    {
                        Id = 4,
                        OccupationDate = DateOnly.FromDateTime(DateTime.Now),
                        ParkingArrivalTime = TimeOnly.FromDateTime(DateTime.Now),
                        ParkingDepartureTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(8)),
                        Note = "Напиши бележка тук",
                        EmployeeID = 2,
                        OfficeRoomID = 2,
                        ParkingSpotID = 3
                    },
                    new Track
                    {
                        Id = 5,
                        OccupationDate = DateOnly.FromDateTime(DateTime.Now),
                        ParkingArrivalTime = TimeOnly.FromDateTime(DateTime.Now),
                        ParkingDepartureTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(8)),
                        Note = null,
                        EmployeeID = 4,
                        OfficeRoomID = 2,
                        ParkingSpotID = 2
                    },
                    new Track
                    {
                        Id = 7,
                        OccupationDate = DateOnly.FromDateTime(DateTime.Now),
                        ParkingArrivalTime = TimeOnly.FromDateTime(DateTime.Now),
                        ParkingDepartureTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(8)),
                        Note = null,
                        EmployeeID = 2,
                        OfficeRoomID = 1,
                        ParkingSpotID = 2
                    },
                    new Track
                    {
                        Id = 6,
                        OccupationDate = DateOnly.FromDateTime(DateTime.Now),
                        ParkingArrivalTime = TimeOnly.FromDateTime(DateTime.Now),
                        ParkingDepartureTime = TimeOnly.FromDateTime(DateTime.Now.AddHours(8)),
                        Note = "Please leave a note",
                        EmployeeID = 6,
                        OfficeRoomID = 1,
                        ParkingSpotID = 4
                    }
                    );
            });
        }
    }
}
