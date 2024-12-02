using IndividualProject.Application.Interfaces;
using IndividualProject.Common.ResultPattern;
using Microsoft.AspNetCore.Mvc;

namespace IndividualProject.Controllers
{
    [Route("officeroom")]
    public class RoomController(IRoomService roomService) : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await roomService.GetAsync();

            return result.Match(onSuccess: Ok, onFailure: Problem);
        }
    }
}
