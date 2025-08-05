using DeepLabSystem.Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DeepLabSystem.Application.Features.Account.Commands
{
    public class LogoutCommandHandler : IRequestHandler<LogoutCommand, bool>
    {
        private readonly IAccountService _accountService;

        public LogoutCommandHandler(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public async Task<bool> Handle(LogoutCommand command, CancellationToken cancellationToken)
        {
            return await _accountService.LogoutAsync(command.UserId);
        }
    }
}
