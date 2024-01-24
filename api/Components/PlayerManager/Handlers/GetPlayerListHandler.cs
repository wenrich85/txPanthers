using api.Components.PlayerManager;
using MediatR;
using System.Numerics;

namespace api.Components.PlayerManager
{
    public class GetPlayerListHandler : IRequestHandler<GetPlayerListQuery, List<PlayerDetails>>
    {
        private readonly IPlayerRepository _playerRepository;

        public GetPlayerListHandler(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task<List<PlayerDetails>> Handle(GetPlayerListQuery query, CancellationToken cancellationToken)
        {
            return await _playerRepository.GetPlayerListAsync();
        }
    }
}