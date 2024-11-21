namespace IndividualProject.Domain.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Team Team { get; set; }
        public ICollection<Track> Tracks { get; set; } = new List<Track>();
    }
}
