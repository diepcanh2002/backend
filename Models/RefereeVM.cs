namespace PitchManagerAPI.Models
{
    public class RefereeVM
    {
        public string RefereeCode { get; set; }
        public string Name { get; set; }
        public MatchVM Match { get; set; }
    }
}
