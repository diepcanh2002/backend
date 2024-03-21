namespace PitchManagerAPI.Models
{
    public class GoalVM
    {
        public string GoalCode { get; set; }
        public string GoalType { get; set; }
        public string PlayerCode { get; set; }
        public string MatchCode { get; set; }
        public DateTime TimeSet { get; set; }
        public PlayerVM Player { get; set; }
        public MatchVM Match { get; set; }

    }
}
