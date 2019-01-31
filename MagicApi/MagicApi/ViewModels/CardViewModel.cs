using System.Collections.Generic;

namespace MagicApi.ViewModels
{
    public class CardViewModel
    {
        public string Name { get; set; }
        public List<string> Sets { get; set; }
        public string ImageUrl { get; set; }
        public int MultiverseId { get; set; }
        public double Cmc { get; set; }
        public string Type { get; set; }
        public string OriginalText { get; set; }
        public string Rarity { get; set; }
    }
}
