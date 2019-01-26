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

        public async Task<List<Card>> GetCards(string name)
        {
            var request = "https://api.magicthegathering.io/v1/cards?name=" + name;

            var response = await _httpclient.GetAsync(request);

            if (response.IsSuccessStatusCode)
            {
                 var cardsResponse = await response.Content.ReadAsAsync<CardsResponse>();

                var filteredCards = FilterCards(cardsResponse);
                return filteredCards;
            }
            else
            {
                throw new System.Exception("Error making API call, please debug");
            }
        }

        public List<Card> FilterCards(CardsResponse cardsResponse)
        {
            var filteredCards = new List<Card>();
            
            foreach(var card in cardsResponse.Cards)
            {
                if(card.multiverseid != 0)
                {
                    filteredCards.Add(card);
                }
            }
            return filteredCards;
        }

    }
}
