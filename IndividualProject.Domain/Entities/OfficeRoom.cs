namespace IndividualProject.Domain.Entities
{
    public class OfficeRoom : BaseEntity
    {
        public string RoomName { get; set; }
        public ICollection<Track> Tracks { get; set; } = new List<Track>();
    }
}
