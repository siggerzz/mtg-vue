using System.Collections.Generic;
using System.Threading.Tasks;
using MagicApi.Models.Formats;
using MagicApi.Models.Set;
using MagicApi.Models.Types;
using MagicApi.ViewModels;

namespace MagicApi.Services.Set
{
    public interface ISearchFilterService
    {
        Task<FilterByViewModel> GetFilters();
        Task<SetsResponse> GetSets();
        Task<TypesResponse> GetTypes();
        Task<FormatsResponse> GetFormats();
        Task<IEnumerable<string>> GetSetNames();
    }
}
