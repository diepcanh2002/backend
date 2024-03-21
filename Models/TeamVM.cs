namespace PitchManagerAPI.Models
{
    public class TeamVM
    {
        public string TeamCode { get; set; }
        public string TeamName { get; set; }
        public int MaxMembers { get; set; }
        public ICollection<PlayerVM> Players { get; set; }
    }
}
