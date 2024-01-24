using api.Components.PlayerManager;
using MediatR;

namespace api.Components.PlayerManager
{
    public class GetPlayerByIdQuery : IRequest<PlayerDetails>
    {
        public long Id {get; set;}
    }
}
