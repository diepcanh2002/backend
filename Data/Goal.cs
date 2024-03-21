using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PitchManagerAPI.Data
{
    public class Goal
    {
        public string GoalCode {  get; set; }
        public string GoalType {  get; set; }
        public string PlayerCode { get; set; }
        public string MatchCode { get; set; }
        public DateTime TimeSet { get; set; }
        public Player Player { get; set; }
        public Match Match { get; set; }

    }
}
