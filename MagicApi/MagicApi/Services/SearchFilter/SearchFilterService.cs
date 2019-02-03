using MagicApi.Models.Formats;
using MagicApi.Models.Set;
using MagicApi.Models.Types;
using MagicApi.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MagicApi.Services.Set
{
    public class SearchFilterService : ISearchFilterService
    {
        public HttpClient _httpclient;

        public SearchFilterService(HttpClient httpclient)
        {
            _httpclient = httpclient;
        }

        public async Task<FilterByViewModel> GetFilters()
        {
            var sets = await GetSets();
            var formats = await GetFormats();
            var types = await GetTypes();

            return new FilterByViewModel
            {
                Sets = sets.sets,
                Formats = formats.Formats,
                Types = types.Types
            };
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

        public async Task<TypesResponse> GetTypes()
        {
            var request = "https://api.magicthegathering.io/v1/types";

            var response = await _httpclient.GetAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var typesResponse = await response.Content.ReadAsAsync<TypesResponse>();

                return typesResponse;
            }
            else
            {
                throw new System.Exception("Error making API call, please debug");
            }
        }

        public async Task<FormatsResponse> GetFormats()
        {
            var request = "https://api.magicthegathering.io/v1/formats";

            var response = await _httpclient.GetAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var formatsResponse = await response.Content.ReadAsAsync<FormatsResponse>();

                return formatsResponse;
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
