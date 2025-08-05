using MediatR;

namespace DeepLabSystem.Application.Features.Account.Commands
{
    public class LogoutCommand : IRequest<bool>
    {
        public string UserId { get; set; }
    }
}
