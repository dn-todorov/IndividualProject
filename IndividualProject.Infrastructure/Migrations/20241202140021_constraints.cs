using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndividualProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class constraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TeamName",
                table: "Team",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SpotName",
                table: "ParkingSpot",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RoomName",
                table: "OfficeRoom",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employee",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employee",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RegistrationPlate",
                table: "Car",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CarBrand",
                table: "Car",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(576209840189), new TimeSpan(209840777) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(576209841604), new TimeSpan(209841606) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(576209841611), new TimeSpan(209841612) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(576209841616), new TimeSpan(209841617) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(576209841622), new TimeSpan(209841623) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(576209841631), new TimeSpan(209841633) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(576209841627), new TimeSpan(209841628) });

            migrationBuilder.CreateIndex(
                name: "IX_Team_TeamName",
                table: "Team",
                column: "TeamName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Car_RegistrationPlate",
                table: "Car",
                column: "RegistrationPlate",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Team_TeamName",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Car_RegistrationPlate",
                table: "Car");

            migrationBuilder.AlterColumn<string>(
                name: "TeamName",
                table: "Team",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "SpotName",
                table: "ParkingSpot",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "RoomName",
                table: "OfficeRoom",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "RegistrationPlate",
                table: "Car",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "CarBrand",
                table: "Car",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(562743259856), new TimeSpan(850743260522) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(562743261447), new TimeSpan(850743261449) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(562743261455), new TimeSpan(850743261456) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(562743261461), new TimeSpan(850743261462) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(562743261466), new TimeSpan(850743261468) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(562743261478), new TimeSpan(850743261479) });

            migrationBuilder.UpdateData(
                table: "Track",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "OccupationDate", "ParkingArrivalTime", "ParkingDepartureTime" },
                values: new object[] { new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(562743261472), new TimeSpan(850743261473) });
        }
    }
}
