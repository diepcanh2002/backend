using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PitchManagerAPI.Data
{
   
    public class Player
    {
     
        public string PlayerCode { get; set; }
       
        public string PlayerName { get; set; }
        public float Height {  get; set; }
        public float Weigth { get; set; }
        public DateTime BirthDay { get; set; }
        public string TeamCode {  get; set; }
        public Team Team { get; set; }
    }
}
