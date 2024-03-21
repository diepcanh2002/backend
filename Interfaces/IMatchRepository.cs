using PitchManagerAPI.Models;

namespace PitchManagerAPI.Interfaces
{
    public interface IMatchRepository
    {
       public Task<List<MatchVM>> GetAll();
       public Task<MatchVM> Get(int id);
        public Task<MatchVM> Get(DateTime startTime,DateTime endTime);
        public Task<MatchVM> AddMatch();
    }
}
