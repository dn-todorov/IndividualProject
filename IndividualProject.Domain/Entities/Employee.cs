namespace IndividualProject.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TeamID { get; set; }
        public Team Team { get; set; }
        public int? CarID { get; set; }
        public Car Car { get; set; }
        public ICollection<Track> Tracks { get; set; } = new List<Track>();

    }
}
