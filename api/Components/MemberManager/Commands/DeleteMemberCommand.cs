using MediatR;

namespace TxPanthers.Api.Commands
{
    public class DeleteMemberCommand : IRequest<int>
    {
        public int Id {get; set;}
    }
}