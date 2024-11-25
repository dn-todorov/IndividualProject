using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndividualProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class dataseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Track_Car_CarID",
                table: "Track");

            migrationBuilder.DropForeignKey(
                name: "FK_Track_ParkingSpot_ParkingSpotID",
                table: "Track");

            migrationBuilder.AlterColumn<int>(
                name: "ParkingSpotID",
                table: "Track",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "ParkingDepartureTime",
                table: "Track",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "ParkingArrivalTime",
                table: "Track",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Track",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CarID",
                table: "Track",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "Id", "CarBrand", "RegistrationPlate" },
                values: new object[,]
                {
                    { 1, "Mercedes", "СВ3728КА" },
                    { 2, "Kia", "Х7728МА" },
                    { 3, "Honda", "СТ3729ТТ" },
                    { 4, "BMW", "ЕА2718ХН" },
                    { 5, "Volkswagen", "СС2819КК" },
                    { 6, "Volkswagen", "А2171ВА" },
                    { 7, "Porsche", "ТХ1729СА" },
                    { 8, "BMW", "РВ4568СС" },
                    { 9, "Mazda", "В4568ТХ" }
                });

            migrationBuilder.InsertData(
                table: "OfficeRoom",
                columns: new[] { "Id", "RoomName" },
                values: new object[,]
                {
                    { 1, "Room 404" },
                    { 2, "Room 403" }
                });

            migrationBuilder.InsertData(
                table: "ParkingSpot",
                columns: new[] { "Id", "SpotName" },
                values: new object[,]
                {
                    { 1, "Parking spot 1" },
                    { 2, "Parking spot 2" },
                    { 3, "Parking spot 3" },
                    { 4, "Parking spot 4" }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "TeamName" },
                values: new object[,]
                {
                    { 1, "BA" },
                    { 2, "HR" },
                    { 3, "Sys Admin" },
                    { 4, "DevOps" },
                    { 5, "Java" },
                    { 6, ".NET" },
                    { 7, "AM" },
                    { 8, "FO" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "FirstName", "LastName", "TeamID" },
                values: new object[,]
                {
                    { 1, "Петър", "Петров", 1 },
                    { 2, "Георги", "Георгиев", 2 },
                    { 3, "Димитър", "Димитров", 3 },
                    { 4, "Иван", "Иванов", 4 },
                    { 5, "Михаела", "Милева", 5 },
                    { 6, "Диан", "Дичев", 6 },
                    { 7, "Пенчо", "Пенчев", 7 },
                    { 8, "Даниела", "Димитрова", 8 },
                    { 9, "Николай", "Калайджиев", 1 },
                    { 10, "Иво", "Иванов", 7 },
                    { 11, "Елена", "Парнарева", 3 },
                    { 12, "Деница", "Георгиева", 5 },
                    { 13, "Ясен", "Николов", 4 }
                });

            migrationBuilder.InsertData(
                table: "Track",
                columns: new[] { "Id", "CarID", "EmployeeID", "Note", "OccupationDate", "OfficeRoomID", "ParkingArrivalTime", "ParkingDepartureTime", "ParkingSpotID" },
                values: new object[,]
                {
                    { 1, 4, 3, null, new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new TimeSpan(624838568468), new TimeSpan(48838569153), 2 },
                    { 2, 6, 6, "Тест тест тест", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeSpan(624838570408), new TimeSpan(48838570410), 4 },
                    { 3, 7, 5, "Lorem ipsum", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeSpan(624838570417), new TimeSpan(48838570418), 1 },
                    { 4, 4, 2, "Напиши бележка тук", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new TimeSpan(624838570423), new TimeSpan(48838570425), 3 },
                    { 5, 6, 4, null, new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new TimeSpan(624838570430), new TimeSpan(48838570432), 2 },
                    { 6, 8, 6, "Please leave a note", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeSpan(624838570442), new TimeSpan(48838570444), 4 },
                    { 7, null, 2, null, new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeSpan(624838570436), new TimeSpan(48838570438), 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Track_Car_CarID",
                table: "Track",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Track_ParkingSpot_ParkingSpotID",
                table: "Track",
                column: "ParkingSpotID",
                principalTable: "ParkingSpot",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Track_Car_CarID",
                table: "Track");

            migrationBuilder.DropForeignKey(
                name: "FK_Track_ParkingSpot_ParkingSpotID",
                table: "Track");

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OfficeRoom",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OfficeRoom",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ParkingSpot",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ParkingSpot",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ParkingSpot",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ParkingSpot",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<int>(
                name: "ParkingSpotID",
                table: "Track",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "ParkingDepartureTime",
                table: "Track",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(TimeSpan),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "ParkingArrivalTime",
                table: "Track",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(TimeSpan),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "Track",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarID",
                table: "Track",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Track_Car_CarID",
                table: "Track",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Track_ParkingSpot_ParkingSpotID",
                table: "Track",
                column: "ParkingSpotID",
                principalTable: "ParkingSpot",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
