using IndividualProject.Application.Dtos.Tracks;
using IndividualProject.Application.Interfaces;
using IndividualProject.Common.ResultPattern;
using Microsoft.AspNetCore.Mvc;

namespace IndividualProject.Controllers
{
    [Route("track")]
    public class TrackController(ITrackService trackService) : BaseController
    {
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id, CancellationToken ct)
        {
            var result = await trackService.GetByIdAsync(id, ct);

            return result.Match(onSuccess: Ok, onFailure: Problem);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(CancellationToken ct)
        {
            var result = await trackService.GetAsync(ct);

            return result.Match(onSuccess: Ok, onFailure: Problem);
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search([FromQuery] string querry)
        {
            var result = await trackService.SearchAsync(querry);

            return result.Match(onSuccess: Ok, onFailure: Problem);
        }

        [HttpPost("add")]
        public async Task Create([FromBody] TracksRequestModel model, CancellationToken ct)
            => await trackService.CreateOrUpdateAsync(null, model, ct);
    }
}
