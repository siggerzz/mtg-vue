namespace MagicApi.Models.Set
{
    public class Set
    {
        public string code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public object[] booster { get; set; }
        public string releaseDate { get; set; }
        public string block { get; set; }
        public bool onlineOnly { get; set; }
    }
}
