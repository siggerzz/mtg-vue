using MagicApi.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MagicApi.Services.Cards
{
    public interface ICardsService
    {
        Task<IEnumerable<CardViewModel>> GetCards(string name, string colorIdentity, string set, string format, string type);
        Task<CardViewModel> GetCard(string multiverseid);
    }
}
