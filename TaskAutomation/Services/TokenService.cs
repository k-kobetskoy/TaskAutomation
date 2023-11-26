using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TaskAutomation.Domain.Identity;
using TaskAutomation.Models;
using TaskAutomation.Services.Abstract;

namespace TaskAutomation.Services;

public class TokenService : ITokenService
{
    private readonly UserManager<User> _userManager;
    private readonly IConfiguration _configuration;

    public TokenService(UserManager<User> userManager, IConfiguration configuration)
    {
        _userManager = userManager;
        _configuration = configuration;
    }
    public async Task<TokenInfo> BuildToken(User user)
    {

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtKey"]!));
        var exp = DateTime.Now.AddDays(1);

        var claims = new List<Claim>()
        {
            new ("Id", user.Id.ToString()),
            new (JwtRegisteredClaimNames.Email, user.Email),
            new (JwtRegisteredClaimNames.Sub, user.Email),
        };
        var claimsDb = await _userManager.GetClaimsAsync(user);
        claims.AddRange(claimsDb);


        var tokenOptions = new JwtSecurityToken(
            issuer: null,
            audience: null,
            claims,
            expires: exp,
            signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
        );

        var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

        return new TokenInfo { Token = token, Expiration = exp };
    }
}