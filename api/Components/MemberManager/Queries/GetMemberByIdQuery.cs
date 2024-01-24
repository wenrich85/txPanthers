using TxPanthers.Api.Models;
using MediatR;

namespace TxPanthers.Api.Queries
{
    public class GetMemberByIdQuery : IRequest<MemberDetails>
    {
        public int Id {get; set;}
    }
}
