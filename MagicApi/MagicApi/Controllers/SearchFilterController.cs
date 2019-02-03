using MagicApi.Services.Set;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MagicApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [EnableCors("CORS")]
    public class SearchFilter : Controller
    {
        public ISearchFilterService _searchFilterService;

        public SearchFilter(ISearchFilterService searchFilterService)
        {
            _searchFilterService = searchFilterService;
        }

        [HttpGet]
        [Route("GetFilters")]
        public async Task<IActionResult> GetFilters()
        {
            return Ok(await _searchFilterService.GetFilters());
        }

        [HttpGet]
        [Route("GetSets")]
        public async Task<IActionResult> GetSets()
        {
            return Ok(await _searchFilterService.GetSets());
        }

        [HttpGet]
        [Route("GetTypes")]
        public async Task<IActionResult> GetTypes()
        {
            return Ok(await _searchFilterService.GetTypes());
        }

        [HttpGet]
        [Route("GetFormats")]
        public async Task<IActionResult> GetFormats()
        {
            return Ok(await _searchFilterService.GetFormats());
        }

        [HttpGet]
        [Route("GetSetNames")]
        public async Task<IActionResult> GetSetNames()
        {
            return Ok(await _searchFilterService.GetSetNames());
        }
    }
}
