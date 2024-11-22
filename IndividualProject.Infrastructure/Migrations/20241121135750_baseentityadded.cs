using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndividualProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class baseentityadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TrackID",
                table: "Track",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TeamID",
                table: "Team",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ParkingSpotID",
                table: "ParkingSpot",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OfficeRoomID",
                table: "OfficeRoom",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "Employee",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CarID",
                table: "Car",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Track",
                newName: "TrackID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Team",
                newName: "TeamID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ParkingSpot",
                newName: "ParkingSpotID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OfficeRoom",
                newName: "OfficeRoomID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employee",
                newName: "EmployeeID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Car",
                newName: "CarID");
        }
    }
}
