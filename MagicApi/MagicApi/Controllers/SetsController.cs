

using MagicApi.Services.Set;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MagicApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [EnableCors("CORS")]
    public class SetsController : Controller
    {
        public ISetsService _setsService;

        public SetsController(ISetsService setsService)
        {
            _setsService = setsService;
        }

        [HttpGet]
        [Route("GetSets")]
        public async Task<IActionResult> GetCards()
        {
            return Ok(await _setsService.GetSets());
        }

        [HttpGet]
        [Route("GetSetNames")]
        public async Task<IActionResult> GetSetNames()
        {
            return Ok(await _setsService.GetSetNames());
        }
    }
}
