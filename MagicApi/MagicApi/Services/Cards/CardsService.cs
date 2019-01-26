using MagicApi.Models.Card;
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

        public async Task<IEnumerable<Card>> GetCards(string name, string colours)
        {
            var request = "https://api.magicthegathering.io/v1/cards?name=" + name + "&colors=" + colours;

            var response = await _httpclient.GetAsync(request);

            if (response.IsSuccessStatusCode)
            {
                 var cardsResponse = await response.Content.ReadAsAsync<CardRoot>();

                var filteredCards = cardsResponse.Cards.Where(c => c.multiverseid != 0);

                return filteredCards;
            }
            else
            {
                throw new System.Exception("Error making API call, please debug");
            }
        }
    }
}
