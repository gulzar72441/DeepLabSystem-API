using DeepLabSystem.Application.DTOs.Account;
using DeepLabSystem.Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DeepLabSystem.Application.Features.Account.Commands
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, AuthenticationResponse>
    {
        private readonly IAccountService _accountService;

        public LoginCommandHandler(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public async Task<AuthenticationResponse> Handle(LoginCommand command, CancellationToken cancellationToken)
        {
            var authRequest = new AuthenticationRequest
            {
                Email = command.Email,
                Password = command.Password
            };
            return await _accountService.AuthenticateAsync(authRequest, string.Empty);
        }
    }
}
