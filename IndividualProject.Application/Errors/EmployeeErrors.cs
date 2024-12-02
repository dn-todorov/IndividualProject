using IndividualProject.Common.ResultPattern;

namespace IndividualProject.Application.Errors
{
    public class EmployeeErrors
    {
        public static Error NotFound(string id) =>
            Error.NotFound("Employee.NotFound", $"Employee: {id} not found");

        public static Error Conflict(string id) =>
            Error.Conflict("Employee.Conflict", $"Employee with ID: {id} already exists.");

        public static Error CreateFailure =>
            Error.Failure("Employee.CreateFailure", $"Something went wrong in creating employee");

        public static Error Updatefailure =>
            Error.Failure("Employee.UpdateFailure", $"Something went wrong in updating employee");

        public static Error DeleteFailure =>
            Error.Failure("Employee.DeleteFailure", $"Something went wrong in deleting employee");
    }
}
