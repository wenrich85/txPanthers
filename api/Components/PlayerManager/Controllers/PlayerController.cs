using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace api.Components.PlayerManager
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IMediator mediator;

        public PlayersController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public async Task<List<PlayerDetails>> GetPlayerListAsync()
        {
            var playerDetails = await mediator.Send(new GetPlayerListQuery());
            return playerDetails;
        }

        [HttpGet("playerId")]
        public async Task<PlayerDetails> GetPlayerByIdAsync(long playerId)
        {
            var playerDetails = await mediator.Send(new GetPlayerByIdQuery() { Id = playerId });
            return playerDetails;
        }
        [HttpPost]
        public async Task<PlayerDetails> AddPlayerAsync(PlayerDetails playerDetails)
        {
            var playerDetail = await mediator.Send(new CreatePlayerCommand(
                playerDetails.MemberId,
                playerDetails.Position,
                playerDetails.JerseyNumber,
                playerDetails.Height,
                playerDetails.Weight,
                playerDetails.DateOfBirth,
                playerDetails.GraduationYear,
                playerDetails.CurrentGrade
            ));
            return playerDetail;
        }

        [HttpPut]
        public async Task<long> UpdatePlayerAsync(PlayerDetails playerDetails)
        {
            var isPlayerDetailUpdated = await mediator.Send(new UpdatePlayerCommand(
                playerDetails.Id,
                playerDetails.MemberId,
                playerDetails.Position,
                playerDetails.JerseyNumber,
                playerDetails.Height,
                playerDetails.Weight,
                playerDetails.DateOfBirth,
                playerDetails.GraduationYear,
                playerDetails.CurrentGrade
            ));
            return isPlayerDetailUpdated;
        }

        [HttpDelete]
        public async Task<long> DeletePlayerAsync(long Id)
        {
            return await mediator.Send(new DeletePlayerCommand() { Id = Id });
        }
    }   
}