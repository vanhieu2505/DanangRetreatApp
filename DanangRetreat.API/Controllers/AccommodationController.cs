using DanangRetreat.API.Data;
using DanangRetreat.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DanangRetreat.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccommodationController : ControllerBase
    {
        private readonly IDanangRetreatRepository _repo;

        public AccommodationController(IDanangRetreatRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> GetAccommodation()
        {
            var lstAccommodations = await _repo.GetAccommodations();
            return Ok(lstAccommodations);
        }
    }
}