using TxPanthers.Api.Data;
using api.Components.PlayerManager;
using Microsoft.EntityFrameworkCore;
using System;
using System.Numerics;

namespace api.Components.PlayerManager
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly DataContext _dbContext;
        public PlayerRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<PlayerDetails> AddPlayerAsync(PlayerDetails playerDetails)
        {
            var result = _dbContext.Players.Add(playerDetails);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<long> DeletePlayerAsync(long Id)
        {
            var filterData = _dbContext.Players.Where(x => x.Id == Id).FirstOrDefault();
            _dbContext.Players.Remove(filterData);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<PlayerDetails> GetPlayerByIdAsync(long Id)
        {
            return await _dbContext.Players.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<List<PlayerDetails>> GetPlayerListAsync()
        {
            return await _dbContext.Players.ToListAsync();
        }

        public async Task<long> UpdatePlayerAsync(PlayerDetails playerDetails)
        {
            _dbContext.Players.Update(playerDetails);
            return await _dbContext.SaveChangesAsync();
        }
    }
}