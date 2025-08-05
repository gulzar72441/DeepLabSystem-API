using DeepLabSystem.Application.DTOs.Account;
using MediatR;

namespace DeepLabSystem.Application.Features.Account.Commands
{
    public class LoginCommand : IRequest<AuthenticationResponse>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
