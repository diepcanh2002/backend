

namespace PitchManagerAPI.Models
{
    public class CardVM
    {
        public string CardCode { get; set; }
        public string CardType { get; set; }
        public string PlayerCode { get; set; }
        public string MatchCode { get; set; }
        public DateTime TimeSet { get; set; }
        public string Reason { get; set; }
        public MatchVM Match { get; set; }
        public PlayerVM Player { get; set; }
    }
}
