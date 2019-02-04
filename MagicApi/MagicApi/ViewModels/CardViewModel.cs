using MagicApi.Models.Types;
using System.Collections.Generic;

namespace MagicApi.ViewModels
{
    public class CardViewModel
    {
        public string Name { get; set; }
        public string ManaCost { get; set; }
        public double Cmc { get; set; }
        public string[] Types { get; set; }
        public string Text { get; set; }
        public string Flavor { get; set; }
        public string Power { get; set; }
        public string Toughness { get; set; }
        public string Rarity { get; set; }
        public string Number { get; set; }
        public string Artist { get; set; }
        public List<string> Sets { get; set; }
        public string ImageUrl { get; set; }
        public int MultiverseId { get; set; }
        public string Type { get; set; }
        public string OriginalText { get; set; }
        public string SetName { get; set; }
    }
}
