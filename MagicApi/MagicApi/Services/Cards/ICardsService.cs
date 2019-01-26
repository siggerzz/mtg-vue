using MagicApi.Models;
using MagicApi.Models.Card;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicApi.Services.Cards
{
    public interface ICardsService
    {
        Task<List<Card>> GetCards(string name);
    }
}
