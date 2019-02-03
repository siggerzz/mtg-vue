using MagicApi.Models.Set;

namespace MagicApi.ViewModels
{
    public class FilterByViewModel
    {
        public string[] Types { get; set; }
        public Set[] Sets { get; set; }
        public string[] Formats { get; set; }
    }
}
