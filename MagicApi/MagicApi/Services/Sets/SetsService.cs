using MagicApi.Models.Set;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MagicApi.Services.Set
{
    public class SetsService : ISetsService
    {
        public HttpClient _httpclient;

        public SetsService(HttpClient httpclient)
        {
            _httpclient = httpclient;
        }

        public async Task<SetsResponse> GetSets()
        {
            var request = "https://api.magicthegathering.io/v1/sets";

            var response = await _httpclient.GetAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var setsResponse = await response.Content.ReadAsAsync<SetsResponse>();

                return setsResponse;
            }
            else
            {
                throw new System.Exception("Error making API call, please debug");
            }
        }

        public async Task<IEnumerable<string>> GetSetNames()
        {

            var setsResponse = await GetSets();
            var setNames = setsResponse.sets.Select(set => set.name);

            return setNames;

        }
    }
}
