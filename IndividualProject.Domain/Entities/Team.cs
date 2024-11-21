﻿namespace IndividualProject.Domain.Entities
{
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
