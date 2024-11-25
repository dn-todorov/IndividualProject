namespace IndividualProject.Domain.Entities
{
    public class Track : BaseEntity
    {
        public DateOnly OccupationDate { get; set; }
        public TimeOnly? ParkingArrivalTime { get; set; }
        public TimeOnly? ParkingDepartureTime { get; set; }
        public string? Note { get; set; }
        public int EmployeeID { get; set; }
        public int OfficeRoomID { get; set; }
        public int? CarID { get; set; }
        public int? ParkingSpotID { get; set; }
        public Employee Employee { get; set; }
        public OfficeRoom OfficeRoom { get; set; }
        public Car Car { get; set; }
        public ParkingSpot ParkingSpot { get; set; }
    }
}
