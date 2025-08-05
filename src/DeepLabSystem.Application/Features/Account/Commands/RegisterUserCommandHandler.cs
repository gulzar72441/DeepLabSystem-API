using DeepLabSystem.Application.DTOs.Account;
using DeepLabSystem.Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DeepLabSystem.Application.Features.Account.Commands
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, string>
    {
        private readonly IAccountService _accountService;

        public RegisterUserCommandHandler(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public async Task<string> Handle(RegisterUserCommand command, CancellationToken cancellationToken)
        {
            var registerRequest = new RegisterRequest
            {
                Email = command.Email,
                Password = command.Password,
                FirstName = command.FirstName,
                LastName = command.LastName,
                UserName = command.UserName,
                ConfirmPassword = command.Password // Assuming password and confirm password are the same here
            };
            return await _accountService.RegisterAsync(registerRequest, string.Empty);
        }
    }
}
