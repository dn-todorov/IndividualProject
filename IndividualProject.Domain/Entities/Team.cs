namespace IndividualProject.Domain.Entities
{
    public class Team : BaseEntity
    {
        public string TeamName { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
