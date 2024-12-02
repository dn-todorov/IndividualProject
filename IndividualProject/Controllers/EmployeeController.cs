using IndividualProject.Application.Dtos.Employees;
using IndividualProject.Application.Interfaces;
using IndividualProject.Common.ResultPattern;
using Microsoft.AspNetCore.Mvc;

namespace IndividualProject.Controllers
{
    [Route("employee")]
    public class EmployeeController(IEmployeeService employeeService) : BaseController
    {
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await employeeService.GetByIdAsync(id);

            return result.Match(onSuccess: Ok, onFailure: Problem);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await employeeService.GetAsync();

            return result.Match(onSuccess: Ok, onFailure: Problem);
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search([FromQuery] string querry)
        {
            var result = await employeeService.SearchAsync(querry);

            return result.Match(onSuccess: Ok, onFailure: Problem);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Create([FromBody] EmployeeRequestModel model)
        {
            var result = await employeeService.CreateOrUpdateAsync(null, model);

            return result.Match(onSuccess: Ok, onFailure: Problem);
        }

        [HttpPut("update{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int? id, [FromBody] EmployeeRequestModel model)
        {
            var result = await employeeService.CreateOrUpdateAsync(id, model);

            return result.Match(onSuccess: Ok, onFailure: Problem);
        }

        [HttpDelete("delete{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var result = await employeeService.DeleteAsync(id);

            return result.Match(onSuccess: Ok, onFailure: Problem);
        }
    }
}
