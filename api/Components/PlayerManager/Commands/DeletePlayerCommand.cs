using MediatR;

namespace api.Components.PlayerManager
{
    public class DeletePlayerCommand : IRequest<long>
    {
        public long Id {get; set;}
    }
}