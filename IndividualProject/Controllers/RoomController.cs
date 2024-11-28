using IndividualProject.Application.Interfaces;
using IndividualProject.Common.ResultPattern;
using Microsoft.AspNetCore.Mvc;

namespace IndividualProject.Controllers
{
    [Route("officeroom")]
    public class RoomController(IRoomService roomService) : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAllAsync(CancellationToken ct)
        {
            var result = await roomService.GetAsync(ct);

            return result.Match(onSuccess: Ok, onFailure: Problem);
        }
    }
}
