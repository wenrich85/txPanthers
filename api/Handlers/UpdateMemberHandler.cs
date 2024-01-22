using TxPanthers.Api.Commands;
using TxPanthers.Api.Repositories;
using MediatR;

namespace TxPanthers.Api.Handlers
{
    public class UpdateMemberHandler : IRequestHandler<UpdateMemberCommand, int>
    {
        private readonly IMemberRepository _memberRepository;

        public UpdateMemberHandler(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }
        public async Task<int> Handle(UpdateMemberCommand command, CancellationToken cancellationToken)
        {
            var memberDetails = await _memberRepository.GetMemberByIdAsync(command.Id);
            if (memberDetails == null)
                return default;

            memberDetails.FirstName = command.FirstName;
            memberDetails.LastName = command.LastName;
            memberDetails.Email = command.Email;
            memberDetails.Phone = command.Phone;

            return await _memberRepository.UpdateMemberAsync(memberDetails);
        }
    }
}