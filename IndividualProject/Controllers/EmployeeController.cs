using IndividualProject.Application.Interfaces;
using IndividualProject.Common.ResultPattern;
using Microsoft.AspNetCore.Mvc;

namespace IndividualProject.Controllers
{
    [Route("employee")]
    public class EmployeeController(IEmployeeService employeeService) : BaseController
    {
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id, CancellationToken ct)
        {
            var result = await employeeService.GetByIdAsync(id, ct);

            return result.Match(onSuccess: Ok, onFailure: Problem);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(CancellationToken ct)
        {
            var result = await employeeService.GetAsync(ct);

            return result.Match(onSuccess: Ok, onFailure: Problem);
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search([FromQuery] string querry)
        {
            var result = await employeeService.SearchAsync(querry);

            return result.Match(onSuccess: Ok, onFailure: Problem);
        }
    }
}
