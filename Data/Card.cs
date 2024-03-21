
namespace PitchManagerAPI.Data
{
   
    public class Card
    {
        public string CardCode { get; set; }
        public string CardType {  get; set; }
        public string PlayerCode {  get; set; }
        public string MatchCode {  get; set; }
        public DateTime TimeSet { get; set; }
        public string Reason {  get; set; }
        public Match Match { get; set; }
        public Player Player { get; set; }

    }
}
