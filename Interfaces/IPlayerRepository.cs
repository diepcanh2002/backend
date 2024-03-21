using PitchManagerAPI.Models;

namespace PitchManagerAPI.Interfaces
{
    public interface IPlayerRepository
    {
        public Task<List<PlayerVM>> GetAll();
        public Task<PlayerVM> GetById(int id);
        public Task<PlayerVM> GetByName(string name);
        public Task<PlayerVM> AddPlayer(PlayerVM player);
        public Task<PlayerVM> UpdatePlayer(PlayerVM playerVM);
        public Task<PlayerVM> DeletePlayer(int id);
    }
}
