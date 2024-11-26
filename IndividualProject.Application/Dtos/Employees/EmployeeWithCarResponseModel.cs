using IndividualProject.Application.Dtos.Cars;

namespace IndividualProject.Application.Dtos.Employees
{
    public class EmployeeWithCarResponseModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CarResponseModel Car { get; set; }
    }
}
