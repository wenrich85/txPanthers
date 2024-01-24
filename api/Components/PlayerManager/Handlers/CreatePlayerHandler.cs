using MediatR;
using api.Components.PlayerManager;

namespace api.Components.PlayerManager
{
    public class CreatePlayerHandler : IRequestHandler<CreatePlayerCommand, PlayerDetails>
    {
        private readonly IPlayerRepository _playerRepository;

        public CreatePlayerHandler(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task<PlayerDetails> Handle(CreatePlayerCommand command, CancellationToken cancellationToken)
        {
            var playerDetails = new PlayerDetails()
            {
                MemberId = command.MemberId,
                Position = command.Position,
                JerseyNumber = command.JerseyNumber,
                Height = command.Height,
                Weight = command.Weight,
                DateOfBirth = command.DateOfBirth,
                GraduationYear = command.GraduationYear,
                CurrentGrade = command.CurrentGrade
            };

            return await _playerRepository.AddPlayerAsync(playerDetails);
        }
    }
}