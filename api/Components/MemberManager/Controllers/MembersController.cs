using TxPanthers.Api.Commands;
using TxPanthers.Api.Models;
using TxPanthers.Api.Queries;
using TxPanthers.Api.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TxPanthers.Api.Services;

namespace TxPanthers.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private IMediator mediator;


        public MembersController(IMediator  mediator)

        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<List<MemberDetails>> GetMemberListAsync()
        {
            var memberDetails = await mediator.Send(new GetMemberListQuery());
            return memberDetails;
        }

        [HttpGet("memberId")]
        public async Task<MemberDetails> GetStudentByIdAsync(int memberId)
        {
            var memberDetails = await mediator.Send(new GetMemberByIdQuery() {Id = memberId});
            return memberDetails;
        }

        [HttpPost]
        public async Task<MemberDetails> AddMemberAsync(MemberDetails memberDetails)
        {
            var memberDetail = await mediator.Send( new CreateMemberCommand(
                memberDetails.FirstName,
                memberDetails.LastName,
                memberDetails.Phone,
                memberDetails.Email
            ));
            return memberDetail;
        }

        [HttpPut]
        public async Task<int> UpdateMemberAsync(MemberDetails memberDetails)
        {
            var isMemberDetailUpdated = await mediator.Send(new UpdateMemberCommand(
                memberDetails.Id,
                memberDetails.FirstName,
                memberDetails.LastName,
                memberDetails.Email,
                memberDetails.Phone
            ));
            return isMemberDetailUpdated;
        }

        [HttpDelete]
        public async Task<int> DeleteMemberAsync(int Id)
        {
            return await mediator.Send(new DeleteMemberCommand() {Id = Id});
        }
    }
}