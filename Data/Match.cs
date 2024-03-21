namespace PitchManagerAPI.Data
{
    public class Match
    {
        public string MatchCode {  get; set; }
        public string LeftTeamCode {  get; set; }
        public string RightTeamCode { get; set;}
        public DateTime TimeStart{  get; set;}
        public DateTime TimeEnd { get; set;}
        public string RefereeCode {  get; set;}
       
        public string FooballFieldCode {  get; set;}
        public string TournamentCode {  get; set;}
        public Team LeftTeam { get; set; }
        public Team RightTeam { get; set; }
        public Referee Referee { get; set;} 
        public FootballField FootballField { get; set;}

    }
}
