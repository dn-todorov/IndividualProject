using IndividualProject.Application.Dtos.Employees;
using IndividualProject.Application.Dtos.ParkingSpots;
using IndividualProject.Application.Dtos.Rooms;

namespace IndividualProject.Application.Dtos.Tracks
{
    public class TracksResponseModel
    {
        public int Id { get; set; }
        public DateOnly OccupationDate { get; set; }
        public TimeOnly? ParkingArrivalTime { get; set; }
        public TimeOnly? ParkingDepartureTime { get; set; }
        public RoomResponseModel Room { get; set; }
        public EmployeeResponseModel Employee { get; set; }
        public ParkingSpotResponseModel ParkingSpot { get; set; }
    }
}
