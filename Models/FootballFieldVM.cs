namespace PitchManagerAPI.Models
{
    public class FootballFieldVM
    {
        public string FootballFieldCode { get; set; }
        public string FootballFieldName { get; set; }
        public string FootballFieldDescription { get; set; }
        public int FootballFieldType { get; set; }
        public string FootballFieldLocation { get; set; }
        public MatchVM Match { get; set; }
    }
}
