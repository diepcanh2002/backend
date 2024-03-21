using AutoMapper;
using PitchManagerAPI.Data;
using PitchManagerAPI.Models;


namespace PitchManagerAPI.Helpers
{
    public class ApplicationMapper:Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Player,PlayerVM>().ReverseMap();
        }
    }
}
