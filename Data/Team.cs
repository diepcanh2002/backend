namespace PitchManagerAPI.Data
{
    public class Team
    {
        public string TeamCode {  get; set; }
        public string TeamName { get; set; }
        public int MaxMembers {  get; set; }
        public ICollection<Player> Players { get; set; }
    }
}
