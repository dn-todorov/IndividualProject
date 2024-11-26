namespace IndividualProject.Application.Dtos
{
    public class TrackDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TeamName { get; set; }
        public DateOnly OccupationDate { get; set; }
        public string OfficeRoom { get; set; }
        public string ParkingSpot { get; set; }
        public TimeOnly ParkingArrivalTime { get; set; }
        public TimeOnly ParkingDepartureTIme { get; set; }
    }
}
