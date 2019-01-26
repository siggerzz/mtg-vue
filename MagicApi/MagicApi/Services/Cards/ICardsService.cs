using MagicApi.Models;
using MagicApi.Models.Card;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicApi.Services.Cards
{
    public interface ICardsService
    {
        Task<IEnumerable<Card>> GetCards(string name);
    }
}
