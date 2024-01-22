using TxPanthers.Api.Models;
using MediatR;

namespace TxPanthers.Api.Commands
{
    public class CreateMemberCommand : IRequest<MemberDetails>
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public string Phone {get; set;}

        public CreateMemberCommand(string firstName, string lastName, string email, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }
    }
}