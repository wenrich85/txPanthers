using TxPanthers.Api.Commands;
using TxPanthers.Api.Models;
using TxPanthers.Api.Repositories;
using MediatR;

namespace TxPanthers.Api.Handlers
{
 public class CreateMemberHandler : IRequestHandler<CreateMemberCommand, MemberDetails>
    {
        private readonly IMemberRepository _memberRepository;

        public CreateMemberHandler(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }
        public async Task<MemberDetails> Handle(CreateMemberCommand command, CancellationToken cancellationToken)
        {
            var memberDetails = new MemberDetails()
            {
                FirstName = command.FirstName,
                LastName = command.LastName,
                Email = command.Email,
                Phone = command.Phone
            };

            return await _memberRepository.AddMemberAsync(memberDetails);
        }
    }
}