namespace IndividualProject.Domain.Entities
{
    public class ParkingSpot
    {
        public int ParkingSpotID { get; set; }
        public string SpotName { get; set; }
        public ICollection<Track> Tracks { get; set; } = new List<Track>();
    }
}
