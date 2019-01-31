using MagicApi.Models.Card;
using MagicApi.Services.Extensions;
using MagicApi.ViewModels;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MagicApi.Services.Cards
{
    public class CardsService : ICardsService
    {
        public HttpClient _httpclient;

        public CardsService(HttpClient httpclient)
        {
            _httpclient = httpclient;
        }

        public async Task<IEnumerable<CardViewModel>> GetCards(string name, string colorIdentity)
        {
            var request = "https://api.magicthegathering.io/v1/cards?name=" + name + "&colorIdentity=" + colorIdentity;

            var response = await _httpclient.GetAsync(request);

            if (response.IsSuccessStatusCode)
            {
                 var cardsResponse = await response.Content.ReadAsAsync<CardRoot>();

                var filteredCards = cardsResponse.Cards.Where(c => c.multiverseid != 0);

                var dictionary = new ConcurrentDictionary<string, List<string>>();
                foreach (var card in filteredCards)
                {
                    if (!dictionary.TryAdd(card.name, new List<string> { card.set }))
                    {
                        dictionary[card.name].Add(card.set);
                    }
                }
                var cardsViewModel = filteredCards.Select(c => c.ToCardViewModel(dictionary[c.name]));

                var distinctCardsViewModel = cardsViewModel.GroupBy(c => c.Name).Select(g => g.First());

                return distinctCardsViewModel;
            }
            else
            {
                throw new System.Exception("Error making API call, please debug");
            }
        }
    }
}
