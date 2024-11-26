using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndividualProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changedrelationshipofcar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Track_Car_CarID",
                table: "Track");

            migrationBuilder.DropIndex(
                name: "IX_Track_CarID",
                table: "Track");

            migrationBuilder.DropColumn(
                name: "CarID",
                table: "Track");

            migrationBuilder.AddColumn<int>(
                name: "CarID",
                table: "Employee",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1,
                column: "CarID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2,
                column: "CarID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 3,
                column: "CarID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 4,
                column: "CarID",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 5,
                column: "CarID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 6,
                column: "CarID",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 7,
                column: "CarID",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 8,
                column: "CarID",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 9,
                column: "CarID",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 10,
                column: "CarID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 11,
                column: "CarID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 12,
                column: "CarID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 13,
                column: "CarID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(429242669827), new TimeSpan(717242670562) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(429242671549), new TimeSpan(717242671551) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(429242671556), new TimeSpan(717242671558) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(429242671562), new TimeSpan(717242671563) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(429242671567), new TimeSpan(717242671569) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(429242671579), new TimeSpan(717242671580) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(429242671573), new TimeSpan(717242671575) });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CarID",
                table: "Employee",
                column: "CarID",
                unique: true,
                filter: "[CarID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Car_CarID",
                table: "Employee",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Car_CarID",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_CarID",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CarID",
                table: "Employee");

            migrationBuilder.AddColumn<int>(
                name: "CarID",
                table: "Track",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CarID", "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { 4, new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(624838568468), new TimeSpan(48838569153) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CarID", "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { 6, new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(624838570408), new TimeSpan(48838570410) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CarID", "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { 7, new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(624838570417), new TimeSpan(48838570418) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CarID", "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { 4, new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(624838570423), new TimeSpan(48838570425) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CarID", "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { 6, new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(624838570430), new TimeSpan(48838570432) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CarID", "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { 8, new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(624838570442), new TimeSpan(48838570444) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CarID", "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { null, new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(624838570436), new TimeSpan(48838570438) });

            migrationBuilder.CreateIndex(
                name: "IX_Track_CarID",
                table: "Track",
                column: "CarID");

            migrationBuilder.AddForeignKey(
                name: "FK_Track_Car_CarID",
                table: "Track",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "Id");
        }
    }
}
