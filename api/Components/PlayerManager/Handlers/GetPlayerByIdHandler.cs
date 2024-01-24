using MediatR;
using System.Numerics;
using api.Components.PlayerManager;

namespace api.Components.PlayerManager
{
    public class GetPlayerByIdHandler : IRequestHandler<GetPlayerByIdQuery, PlayerDetails>
    {
        private readonly IPlayerRepository _playerRepository;

        public GetPlayerByIdHandler(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task<PlayerDetails> Handle(GetPlayerByIdQuery query, CancellationToken cancellationToken)
        {
            return await _playerRepository.GetPlayerByIdAsync(query.Id);
        }
    }   
}