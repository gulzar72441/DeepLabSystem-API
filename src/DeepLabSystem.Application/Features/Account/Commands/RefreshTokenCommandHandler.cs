using DeepLabSystem.Application.DTOs.Account;
using DeepLabSystem.Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DeepLabSystem.Application.Features.Account.Commands
{
    public class RefreshTokenCommandHandler : IRequestHandler<RefreshTokenCommand, AuthenticationResponse>
    {
        private readonly IAccountService _accountService;

        public RefreshTokenCommandHandler(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public async Task<AuthenticationResponse> Handle(RefreshTokenCommand command, CancellationToken cancellationToken)
        {
            return await _accountService.RefreshTokenAsync(command.Token, string.Empty);
        }
    }
}
