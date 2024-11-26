using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndividualProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class databaseconstraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new TimeSpan(562743259856), new TimeSpan(850743260522) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new TimeSpan(562743261447), new TimeSpan(850743261449) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new TimeSpan(562743261455), new TimeSpan(850743261456) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new TimeSpan(562743261461), new TimeSpan(850743261462) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new TimeSpan(562743261466), new TimeSpan(850743261468) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new TimeSpan(562743261478), new TimeSpan(850743261479) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new TimeSpan(562743261472), new TimeSpan(850743261473) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new TimeSpan(429242669827), new TimeSpan(717242670562) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new TimeSpan(429242671549), new TimeSpan(717242671551) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new TimeSpan(429242671556), new TimeSpan(717242671558) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new TimeSpan(429242671562), new TimeSpan(717242671563) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new TimeSpan(429242671567), new TimeSpan(717242671569) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new TimeSpan(429242671579), new TimeSpan(717242671580) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new TimeSpan(429242671573), new TimeSpan(717242671575) });
        }
    }
}
