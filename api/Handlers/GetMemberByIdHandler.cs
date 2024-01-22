using TxPanthers.Api.Models;
using TxPanthers.Api.Queries;
using TxPanthers.Api.Repositories;
using MediatR;
using System.Numerics;

namespace TxPanthers.Api.Handlers
{
    public class GetMemberByIdHandler : IRequestHandler<GetMemberByIdQuery, MemberDetails>
    {
        private readonly IMemberRepository _memberRepository;

        public GetMemberByIdHandler(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public async Task<MemberDetails> Handle(GetMemberByIdQuery query, CancellationToken cancellationToken)
        {
            return await _memberRepository.GetMemberByIdAsync(query.Id);
        }
    }
}