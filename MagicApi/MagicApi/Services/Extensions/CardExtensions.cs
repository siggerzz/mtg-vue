using MagicApi.Models.Card;
using MagicApi.ViewModels;
using System.Collections.Generic;

namespace MagicApi.Services.Extensions
{
    public static class CardExtensions
    {
        public static CardViewModel ToCardViewModel(this Card card, List<string> sets)
        {

            return new CardViewModel
            {
                Name = card.name,
                Sets = sets,
                ImageUrl = card.imageUrl,
                MultiverseId = card.multiverseid,
                Cmc = card.cmc,
                Type = card.type,
                OriginalText = card.originalText,
                Rarity = card.rarity,
                ManaCost = card.FormatManaCost()
            };
        }

        public static IList<string> FormatManaCost(this Card card)
        {
            var manaCost = card.manaCost.Split('}');
            IList<string> trimmedManaCostList = new List<string>();

            foreach (var mc in manaCost)
            {
                var trimmedManaCost = mc.TrimStart('{');

                if (!string.IsNullOrWhiteSpace(mc))
                {
                    trimmedManaCostList.Add(trimmedManaCost);
                }
            }

            return trimmedManaCostList;
        }
    }
}
