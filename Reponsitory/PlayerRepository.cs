using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PitchManagerAPI.Data;
using PitchManagerAPI.Interfaces;
using PitchManagerAPI.Models;

namespace PitchManagerAPI.Reponsitory
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public PlayerRepository(DataContext context,IMapper mapper) {
        _context=context;
            _mapper=mapper;
        }

        public async Task<string> AddPlayer(PlayerVM player)
        {
            var newplayer= _mapper.Map<Player>(player);
            _context.Players.Add(newplayer);
            await _context.SaveChangesAsync();
            string reponseString = "Create Player"+newplayer.PlayerName+" sussceed";
            return reponseString;
        }

        public Task<PlayerVM> DeletePlayer(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<PlayerVM>> GetAll()
        {
            var list=await _context.Players!.ToListAsync();
            return _mapper.Map<List<PlayerVM>>(list);

        }

        public async Task<PlayerVM> GetById(int id)
        {
            var player= await _context.Players.FindAsync(id);
            return _mapper.Map<PlayerVM>(player);

        }

        public Task<PlayerVM> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<PlayerVM> UpdatePlayer(PlayerVM playerVM)
        {
            throw new NotImplementedException();
        }

        Task<PlayerVM> IPlayerRepository.AddPlayer(PlayerVM player)
        {
            throw new NotImplementedException();
        }
    }
}
