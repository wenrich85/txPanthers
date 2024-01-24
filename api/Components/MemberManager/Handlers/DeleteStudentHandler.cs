using TxPanthers.Api.Commands;
using TxPanthers.Api.Repositories;
using MediatR;

namespace TxPanthers.Api.Handlers
{
    public class DeleteMemberHandler : IRequestHandler<DeleteMemberCommand, int>
    {
        private readonly IMemberRepository _memberRepository;

        public DeleteMemberHandler(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public async Task<int> Handle(DeleteMemberCommand command, CancellationToken cancellationToken)
        {
            var memberDetails = await _memberRepository.GetMemberByIdAsync(command.Id);
            if (memberDetails == null)
                return default;

            return await _memberRepository.DeleteMemberAsync(memberDetails.Id);
        }
    }
}