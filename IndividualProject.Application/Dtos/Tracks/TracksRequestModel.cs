namespace IndividualProject.Application.Dtos.Tracks
{
    public class TracksRequestModel
    {
        public DateOnly OccupationDate { get; set; }
        public TimeOnly? ParkingArrivalTime { get; set; }
        public TimeOnly? ParkingDepartureTime { get; set; }
        public string Text { get; set; }
        public int OfficeRoomID { get; set; }
        public int EmployeeID { get; set; }
        public int? ParkingSpotID { get; set; }
    }
}
