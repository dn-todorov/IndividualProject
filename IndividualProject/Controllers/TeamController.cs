using IndividualProject.Application.Interfaces;
using IndividualProject.Common.ResultPattern;
using Microsoft.AspNetCore.Mvc;

namespace IndividualProject.Controllers
{
    [Route("team")]
    public class TeamController(ITeamService teamService) : BaseController
    {
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await teamService.GetByIdAsync(id);

            return result.Match(onSuccess: Ok, onFailure: Problem);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await teamService.GetAsync();

            return result.Match(onSuccess: Ok, onFailure: Problem);
        }
    }
}
