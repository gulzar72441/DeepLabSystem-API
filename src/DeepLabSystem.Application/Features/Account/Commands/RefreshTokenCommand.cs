using DeepLabSystem.Application.DTOs.Account;
using MediatR;

namespace DeepLabSystem.Application.Features.Account.Commands
{
    public class RefreshTokenCommand : IRequest<AuthenticationResponse>
    {
        public string Token { get; set; }
    }
}
