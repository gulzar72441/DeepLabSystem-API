using DeepLabSystem.Application.DTOs.Account;
using MediatR;

namespace DeepLabSystem.Application.Features.Account.Commands
{
    public class RegisterUserCommand : IRequest<string>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
