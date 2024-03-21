using PitchManagerAPI.Models;

namespace PitchManagerAPI.Interfaces
{
    public interface IFootballFieldRepository
    {
        public Task<FootballFieldVM> findFootballFieldById(int  id);
        public Task<FootballFieldVM> findFootballFieldByName(int name);
        public Task<List<FootballFieldVM>> getAllFootballField();
    }
}
