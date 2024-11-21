﻿namespace IndividualProject.Domain.Entities
{
    public class Track
    {
        public int TrackID { get; set; }
        public DateOnly OccupationDate { get; set; }
        public TimeOnly ParkingArrivalTime { get; set; }
        public TimeOnly ParkingDepartureTime { get; set; }
        public string Note { get; set; }
        public Employee Employee { get; set; }
        public ICollection<OfficeRoom> OfficeRooms { get; set; } = new List<OfficeRoom>();
        public ICollection<Car> Cars { get; set; } = new List<Car>();
        public ICollection<ParkingSpot> ParkingSpots { get; set; } = new List<ParkingSpot>();
    }
}