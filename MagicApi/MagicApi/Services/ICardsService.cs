using MagicApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicApi.Services
{
    public interface ICardsService
    {
        Task<CardsResponse> GetCards(string name);
    }
}
