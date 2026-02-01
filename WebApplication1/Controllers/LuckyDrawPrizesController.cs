using Microsoft.AspNetCore.Mvc;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/lucky-draw-prizes")]
    public class LuckyDrawPrizesController : ControllerBase
    {
        private readonly PrizeRepository _repo;

        public LuckyDrawPrizesController(PrizeRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_repo.GetAllPrizes());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var prize = _repo.GetPrizeById(id);

            if (prize == null)
            {
                return NotFound(new { message = "Prize not found!" });
            }

            return Ok(prize);
        }
    }
}
