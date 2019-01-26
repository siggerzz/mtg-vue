using MagicApi.Services.Cards;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MagicApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [EnableCors("CORS")]
    public class CardsController : Controller
    {
        public ICardsService _cardsService;

        public CardsController(ICardsService cardsService)
        {
            _cardsService = cardsService;
        }

        [HttpGet]
        [Route("GetCards")]
        public async Task<IActionResult> GetCards(string name, string colours)
        {
            return Ok(await _cardsService.GetCards(name, colours));
        }
    }
}
