namespace IndividualProject.Domain.Entities
{
    public class OfficeRoom
    {
        public int OfficeRoomID { get; set; }
        public string RoomName { get; set; }
        public ICollection<Track> Tracks { get; set; } = new List<Track>();
    }
}
