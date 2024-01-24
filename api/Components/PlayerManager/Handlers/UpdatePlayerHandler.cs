using MediatR;

namespace api.Components.PlayerManager
{
    public class UpdatePlayerHandler : IRequestHandler<UpdatePlayerCommand, long>
    {
        private readonly IPlayerRepository _playerRepository;

        public UpdatePlayerHandler(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task<long> Handle(UpdatePlayerCommand command, CancellationToken cancellationToken)
        {
            var playerDetails = await _playerRepository.GetPlayerByIdAsync(command.Id);
            if (playerDetails == null)
                return default;
            
            playerDetails.MemberId = command.MemberId;
            playerDetails.Position = command.Position;
            playerDetails.JerseyNumber = command.JerseyNumber;
            playerDetails.Height = command.Height;
            playerDetails.Weight = command.Weight;
            playerDetails.DateOfBirth = command.DateOfBirth;
            playerDetails.GraduationYear = command.GraduationYear;
            playerDetails.CurrentGrade = command.CurrentGrade;

            return await _playerRepository.UpdatePlayerAsync(playerDetails);
        }
    }
}
