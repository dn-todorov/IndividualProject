﻿using IndividualProject.Application.Interfaces;
using IndividualProject.Common.ResultPattern;
using Microsoft.AspNetCore.Mvc;

namespace IndividualProject.Controllers
{
    [Route("parking")]
    public class ParkingController(IParkingSpotService parkingSpot) : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await parkingSpot.GetAsync();

            return result.Match(onSuccess: Ok, onFailure: Problem);
        }
    }
}
