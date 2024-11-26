using IndividualProject.Application.Dtos.Teams;

namespace IndividualProject.Application.Dtos.Employees
{
    public class EmployeeResponseModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public TeamResponseModel Team { get; set; }
    }
}
