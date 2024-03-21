using PitchManagerAPI.Models;

namespace PitchManagerAPI.Interfaces
{
    public interface ITeamRepository
    {
        public Task<List<TeamVM>>getAll();
        public Task<TeamVM>getTeamById(int id);
        public Task<TeamVM> getTeamByName(string name);
        public Task<List<PlayerVM>>getPlayerBy(int id);

    }
}
