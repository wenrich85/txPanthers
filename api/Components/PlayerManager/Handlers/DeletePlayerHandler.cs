using MediatR;

namespace api.Components.PlayerManager
{
    public class DeletePlayerHandler : IRequestHandler<DeletePlayerCommand, long>
    {
        private readonly IPlayerRepository _playerRepository;

        public DeletePlayerHandler(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task<long> Handle(DeletePlayerCommand command, CancellationToken cancellationToken)
        {
            var playerDetails = await _playerRepository.GetPlayerByIdAsync(command.Id);
            if (playerDetails == null)
                return default;

            return await _playerRepository.DeletePlayerAsync(playerDetails.Id);
        }
    }
}