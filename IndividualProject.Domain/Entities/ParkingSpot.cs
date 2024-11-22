namespace IndividualProject.Domain.Entities
{
    public class ParkingSpot : BaseEntity
    {
        public string SpotName { get; set; }
        public ICollection<Track> Tracks { get; set; } = new List<Track>();
    }
}
