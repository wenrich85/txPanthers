using TxPanthers.Api.Models;
using TxPanthers.Api.Queries;
using TxPanthers.Api.Repositories;
using MediatR;
using System.Numerics;

namespace TxPanthers.Api.Handlers
{
    public class GetMemberListHandler : IRequestHandler<GetMemberListQuery, List<MemberDetails>>
    {
        private readonly IMemberRepository _memberRepository;

        public GetMemberListHandler(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }
        public async Task<List<MemberDetails>> Handle(GetMemberListQuery query, CancellationToken canecllationToken)
        {
            return await _memberRepository.GetMemberListAsync();
        }

    }
}