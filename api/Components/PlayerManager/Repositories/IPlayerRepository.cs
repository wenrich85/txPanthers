using api.Components.PlayerManager;

    namespace api.Components.PlayerManager
    {
        public interface IPlayerRepository
        {
            public Task<List<PlayerDetails>> GetPlayerListAsync();
            public Task<PlayerDetails> GetPlayerByIdAsync(long Id);
            public Task<PlayerDetails> AddPlayerAsync(PlayerDetails playerDetails);
            public Task<long> UpdatePlayerAsync(PlayerDetails playerDetails);
            public Task<long> DeletePlayerAsync(long Id);
        }   
    }
