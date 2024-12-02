using IndividualProject.Application.Dtos.Employees;
using IndividualProject.Common.ResultPattern;

namespace IndividualProject.Application.Interfaces
{
    public interface IEmployeeService
    {
        Task<ResultT<IEnumerable<EmployeeResponseModel>>> SearchAsync(string querry);
        Task<ResultT<IEnumerable<EmployeeWithCarResponseModel>>> GetAsync();

        Task<ResultT<EmployeeWithCarResponseModel>> GetByIdAsync(int id);

        Task<Result> CreateOrUpdateAsync(int? id, EmployeeRequestModel model);

        Task<Result> DeleteAsync(int id);
    }
}
