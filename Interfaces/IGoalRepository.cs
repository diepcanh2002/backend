using PitchManagerAPI.Models;

namespace PitchManagerAPI.Interfaces
{
    public interface IGoalRepository
    {
        public Task<GoalVM> Get(int id);
        public Task<List<GoalVM>> Get(PlayerVM player);
        public Task<List<GoalVM>> Get(MatchVM match);
    }
}
