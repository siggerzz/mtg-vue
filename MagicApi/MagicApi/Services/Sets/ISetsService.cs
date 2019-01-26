using System.Collections.Generic;
using System.Threading.Tasks;
using MagicApi.Models.Set;

namespace MagicApi.Services.Set
{
    public interface ISetsService
    {
        Task<SetsResponse> GetSets();
        Task<IEnumerable<string>> GetSetNames();
    }
}
