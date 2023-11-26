using AutoMapper;
using Microsoft.AspNetCore.Identity;
using TaskAutomation.BusinessLogic.Models;
using TaskAutomation.Domain.Identity;

namespace TaskAutomation.BusinessLogic.Services;

public class IdentityService
{
    private readonly UserManager<User> _userManager;
    private readonly IMapper _mapper;

    public IdentityService(UserManager<User> userManager, IMapper mapper)
    {
        _userManager = userManager;
        _mapper = mapper;
    }
    public async Task<UserModel> GetByEmail(string? email)
    {
        var user = email == null
            ? null
            : await _userManager.FindByEmailAsync(email);

        var model = _mapper.Map<UserModel>(user);
        return model;
    }
}