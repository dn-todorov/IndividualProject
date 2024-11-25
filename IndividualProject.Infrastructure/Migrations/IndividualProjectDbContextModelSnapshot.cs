﻿// <auto-generated />
using System;
using IndividualProject.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IndividualProject.Infrastructure.Migrations
{
    [DbContext(typeof(IndividualProjectDbContext))]
    partial class IndividualProjectDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IndividualProject.Domain.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CarBrand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationPlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Car", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarBrand = "Mercedes",
                            RegistrationPlate = "СВ3728КА"
                        },
                        new
                        {
                            Id = 2,
                            CarBrand = "Kia",
                            RegistrationPlate = "Х7728МА"
                        },
                        new
                        {
                            Id = 3,
                            CarBrand = "Honda",
                            RegistrationPlate = "СТ3729ТТ"
                        },
                        new
                        {
                            Id = 4,
                            CarBrand = "BMW",
                            RegistrationPlate = "ЕА2718ХН"
                        },
                        new
                        {
                            Id = 5,
                            CarBrand = "Volkswagen",
                            RegistrationPlate = "СС2819КК"
                        },
                        new
                        {
                            Id = 6,
                            CarBrand = "Volkswagen",
                            RegistrationPlate = "А2171ВА"
                        },
                        new
                        {
                            Id = 7,
                            CarBrand = "Porsche",
                            RegistrationPlate = "ТХ1729СА"
                        },
                        new
                        {
                            Id = 8,
                            CarBrand = "BMW",
                            RegistrationPlate = "РВ4568СС"
                        },
                        new
                        {
                            Id = 9,
                            CarBrand = "Mazda",
                            RegistrationPlate = "В4568ТХ"
                        });
                });

            modelBuilder.Entity("IndividualProject.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamID");

                    b.ToTable("Employee", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Петър",
                            LastName = "Петров",
                            TeamID = 1
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Георги",
                            LastName = "Георгиев",
                            TeamID = 2
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Димитър",
                            LastName = "Димитров",
                            TeamID = 3
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Иван",
                            LastName = "Иванов",
                            TeamID = 4
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Михаела",
                            LastName = "Милева",
                            TeamID = 5
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Диан",
                            LastName = "Дичев",
                            TeamID = 6
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "Пенчо",
                            LastName = "Пенчев",
                            TeamID = 7
                        },
                        new
                        {
                            Id = 8,
                            FirstName = "Даниела",
                            LastName = "Димитрова",
                            TeamID = 8
                        },
                        new
                        {
                            Id = 9,
                            FirstName = "Николай",
                            LastName = "Калайджиев",
                            TeamID = 1
                        },
                        new
                        {
                            Id = 10,
                            FirstName = "Иво",
                            LastName = "Иванов",
                            TeamID = 7
                        },
                        new
                        {
                            Id = 11,
                            FirstName = "Елена",
                            LastName = "Парнарева",
                            TeamID = 3
                        },
                        new
                        {
                            Id = 12,
                            FirstName = "Деница",
                            LastName = "Георгиева",
                            TeamID = 5
                        },
                        new
                        {
                            Id = 13,
                            FirstName = "Ясен",
                            LastName = "Николов",
                            TeamID = 4
                        });
                });

            modelBuilder.Entity("IndividualProject.Domain.Entities.OfficeRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OfficeRoom", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 2,
                            RoomName = "Room 403"
                        },
                        new
                        {
                            Id = 1,
                            RoomName = "Room 404"
                        });
                });

            modelBuilder.Entity("IndividualProject.Domain.Entities.ParkingSpot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("SpotName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ParkingSpot", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SpotName = "Parking spot 1"
                        },
                        new
                        {
                            Id = 2,
                            SpotName = "Parking spot 2"
                        },
                        new
                        {
                            Id = 3,
                            SpotName = "Parking spot 3"
                        },
                        new
                        {
                            Id = 4,
                            SpotName = "Parking spot 4"
                        });
                });

            modelBuilder.Entity("IndividualProject.Domain.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Team", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TeamName = "BA"
                        },
                        new
                        {
                            Id = 2,
                            TeamName = "HR"
                        },
                        new
                        {
                            Id = 3,
                            TeamName = "Sys Admin"
                        },
                        new
                        {
                            Id = 4,
                            TeamName = "DevOps"
                        },
                        new
                        {
                            Id = 5,
                            TeamName = "Java"
                        },
                        new
                        {
                            Id = 7,
                            TeamName = "AM"
                        },
                        new
                        {
                            Id = 6,
                            TeamName = ".NET"
                        },
                        new
                        {
                            Id = 8,
                            TeamName = "FO"
                        });
                });

            modelBuilder.Entity("IndividualProject.Domain.Entities.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CarID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OccupationDate")
                        .HasColumnType("date");

                    b.Property<int>("OfficeRoomID")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("ParkingArrivalTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan?>("ParkingDepartureTime")
                        .HasColumnType("time");

                    b.Property<int?>("ParkingSpotID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("OfficeRoomID");

                    b.HasIndex("ParkingSpotID");

                    b.ToTable("Track", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarID = 4,
                            EmployeeID = 3,
                            OccupationDate = new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OfficeRoomID = 2,
                            ParkingArrivalTime = new TimeSpan(624838568468),
                            ParkingDepartureTime = new TimeSpan(48838569153),
                            ParkingSpotID = 2
                        },
                        new
                        {
                            Id = 2,
                            CarID = 6,
                            EmployeeID = 6,
                            Note = "Тест тест тест",
                            OccupationDate = new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OfficeRoomID = 1,
                            ParkingArrivalTime = new TimeSpan(624838570408),
                            ParkingDepartureTime = new TimeSpan(48838570410),
                            ParkingSpotID = 4
                        },
                        new
                        {
                            Id = 3,
                            CarID = 7,
                            EmployeeID = 5,
                            Note = "Lorem ipsum",
                            OccupationDate = new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OfficeRoomID = 1,
                            ParkingArrivalTime = new TimeSpan(624838570417),
                            ParkingDepartureTime = new TimeSpan(48838570418),
                            ParkingSpotID = 1
                        },
                        new
                        {
                            Id = 4,
                            CarID = 4,
                            EmployeeID = 2,
                            Note = "Напиши бележка тук",
                            OccupationDate = new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OfficeRoomID = 2,
                            ParkingArrivalTime = new TimeSpan(624838570423),
                            ParkingDepartureTime = new TimeSpan(48838570425),
                            ParkingSpotID = 3
                        },
                        new
                        {
                            Id = 5,
                            CarID = 6,
                            EmployeeID = 4,
                            OccupationDate = new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OfficeRoomID = 2,
                            ParkingArrivalTime = new TimeSpan(624838570430),
                            ParkingDepartureTime = new TimeSpan(48838570432),
                            ParkingSpotID = 2
                        },
                        new
                        {
                            Id = 7,
                            EmployeeID = 2,
                            OccupationDate = new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OfficeRoomID = 1,
                            ParkingArrivalTime = new TimeSpan(624838570436),
                            ParkingDepartureTime = new TimeSpan(48838570438),
                            ParkingSpotID = 2
                        },
                        new
                        {
                            Id = 6,
                            CarID = 8,
                            EmployeeID = 6,
                            Note = "Please leave a note",
                            OccupationDate = new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OfficeRoomID = 1,
                            ParkingArrivalTime = new TimeSpan(624838570442),
                            ParkingDepartureTime = new TimeSpan(48838570444),
                            ParkingSpotID = 4
                        });
                });

            modelBuilder.Entity("IndividualProject.Domain.Entities.Employee", b =>
                {
                    b.HasOne("IndividualProject.Domain.Entities.Team", "Team")
                        .WithMany("Employees")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("IndividualProject.Domain.Entities.Track", b =>
                {
                    b.HasOne("IndividualProject.Domain.Entities.Car", "Car")
                        .WithMany("Tracks")
                        .HasForeignKey("CarID");

                    b.HasOne("IndividualProject.Domain.Entities.Employee", "Employee")
                        .WithMany("Tracks")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IndividualProject.Domain.Entities.OfficeRoom", "OfficeRoom")
                        .WithMany("Tracks")
                        .HasForeignKey("OfficeRoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IndividualProject.Domain.Entities.ParkingSpot", "ParkingSpot")
                        .WithMany("Tracks")
                        .HasForeignKey("ParkingSpotID");

                    b.Navigation("Car");

                    b.Navigation("Employee");

                    b.Navigation("OfficeRoom");

                    b.Navigation("ParkingSpot");
                });

            modelBuilder.Entity("IndividualProject.Domain.Entities.Car", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("IndividualProject.Domain.Entities.Employee", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("IndividualProject.Domain.Entities.OfficeRoom", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("IndividualProject.Domain.Entities.ParkingSpot", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("IndividualProject.Domain.Entities.Team", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
