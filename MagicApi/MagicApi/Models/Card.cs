namespace MagicApi.Models
{

    public class CardRoot
    {
        public Card[] Cards { get; set; }
    }
    public class Card
    {
        public string name { get; set; }
        public string[] names { get; set; }
        public string manaCost { get; set; }
        public double cmc { get; set; }
        public string[] colors { get; set; }
        public string[] colorIdentity { get; set; }
        public string type { get; set; }
        public string[] supertypes { get; set; }
        public string[] types { get; set; }
        public string[] subtypes { get; set; }
        public string rarity { get; set; }
        public string set { get; set; }
        public string text { get; set; }
        public string artist { get; set; }
        public string number { get; set; }
        public string power { get; set; }
        public string toughness { get; set; }
        public string layout { get; set; }
        public int multiverseid { get; set; }
        public string imageUrl { get; set; }
        public Ruling[] rulings { get; set; }
        public string[] printings { get; set; }
        public string originalText { get; set; }
        public string originalType { get; set; }
        public string id { get; set; }
    }
}
