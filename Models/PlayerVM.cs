using PitchManagerAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;
namespace PitchManagerAPI.Models
{
    public class PlayerVM
    {
        public string PlayerCode { get; set; }

        public string PlayerName { get; set; }
        public float Height { get; set; }
        public float Weigth { get; set; }
        public DateTime BirthDay { get; set; }
    }

}
