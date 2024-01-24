using api.Components.PlayerManager;
using MediatR;

namespace api.Components.PlayerManager
{
    public class GetPlayerListQuery : IRequest<List<PlayerDetails>>
    {
    }
}