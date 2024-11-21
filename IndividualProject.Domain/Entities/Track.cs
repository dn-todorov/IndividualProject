namespace IndividualProject.Domain.Entities
{
    public class Track
    {
        public int TrackID { get; set; }
        public DateOnly OccupationDate { get; set; }
        public TimeOnly ParkingArrivalTime { get; set; }
        public TimeOnly ParkingDepartureTime { get; set; }
        public string Note { get; set; }
        public Employee Employee { get; set; }
        public OfficeRoom OfficeRoom { get; set; }
        public Car Car { get; set; }
        public ParkingSpot ParkingSpot { get; set; }
    }
}
