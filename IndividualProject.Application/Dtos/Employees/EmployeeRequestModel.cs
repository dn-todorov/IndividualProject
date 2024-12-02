namespace IndividualProject.Application.Dtos.Employees
{
    public class EmployeeRequestModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TeamID { get; set; }
        public int? CarID { get; set; }
    }
}
