using TaskAutomation.Domain.Identity;
using TaskAutomation.Models;

namespace TaskAutomation.Services.Abstract;

public interface ITokenService
{
    Task<TokenInfo> BuildToken(User user);
}