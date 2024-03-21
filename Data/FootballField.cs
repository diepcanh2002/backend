using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PitchManagerAPI.Data
{
   
    public class FootballField
    {
        public string FootballFieldCode {  get; set; }
        public string FootballFieldName { get; set;}
        public string FootballFieldDescription { get; set;}
        public int FootballFieldType { get; set;}
        public string FootballFieldLocation {  get; set;}
        public Match Match { get; set;}

    }
}
