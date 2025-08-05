using DeepLabSystem.Application.DTOs.Account;

namespace DeepLabSystem.Application.Interfaces
{
    public interface IAccountService
    {
        Task<string> RegisterAsync(RegisterRequest request, string origin);
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request, string ipAddress);
        Task<AuthenticationResponse> RefreshTokenAsync(string token, string ipAddress);
        Task<bool> LogoutAsync(string userId);
    }
}
