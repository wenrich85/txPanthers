using TxPanthers.Api.Models;
using MediatR;

namespace TxPanthers.Api.Queries
{
    public class GetMemberListQuery : IRequest<List<MemberDetails>>
    {     
    }
}