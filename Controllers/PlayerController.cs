using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PitchManagerAPI.Interfaces;
using System.Diagnostics.Eventing.Reader;

namespace PitchManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerRepository _repo;

        public PlayerController(IPlayerRepository repo) {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _repo.GetAll());
            }
            catch  { return BadRequest(); }
        }
    }
}
