using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TaskAutomation.BusinessLogic.Models;
using TaskAutomation.Domain.Identity;
using TaskAutomation.Models;
using TaskAutomation.Models.Constants;
using TaskAutomation.Models.Request;
using TaskAutomation.Models.Response;
using TaskAutomation.Services.Abstract;

namespace TaskAutomation.Controllers;

[Produces("application/json")]
[Route("api/[controller]")]
[ApiController]
[Authorize]
public class AccountsController : ControllerBase
{
    private readonly ITokenService _tokenService;
    private readonly UserManager<User> _userManager;
    private readonly IConfiguration _configuration;
    private readonly ILogger<AccountsController> _logger;
    private readonly IMapper _mapper;

    public AccountsController(
        ITokenService tokenService,
        UserManager<User> userManager,
        IConfiguration configuration,
        ILogger<AccountsController> logger,
        IMapper mapper)
    {
        _tokenService = tokenService;
        _userManager = userManager;
        _configuration = configuration;
        _logger = logger;
        _mapper = mapper;
    }

    [HttpPost]
    [Route("register")]
    [AllowAnonymous]
    public async Task<IActionResult> Register([FromBody] UserCredentials model)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var user = new User { UserName = model.Email, Email = model.Email };
        var creationResult = await _userManager.CreateAsync(user, model.Password);

        if (!creationResult.Succeeded)
            return Unauthorized(creationResult.Errors);

        await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, RegularUserConstants.RoleName));

        return Ok(await _tokenService.BuildToken(user));
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var user = await _userManager.FindByIdAsync(id.ToString());

        var response = _mapper.Map<UserResponse>(user);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Edit([FromForm] UserRequest userRequest)
    {
        var currentUserId = User.FindFirstValue("Id");
        if (currentUserId != userRequest.Id.ToString())
            return Unauthorized();

        var user = await _userManager.FindByIdAsync(userRequest.Id.ToString());

        user.FirstName = userRequest.FirstName;
        user.LastName = userRequest.LastName;
        user.Email = userRequest.Email;
        user.DisplayName = userRequest.DisplayName;

        var result = await _userManager.UpdateAsync(user);
        if (!result.Succeeded)
        {
            //Todo: Create custom ex or error respModel
            return BadRequest();
        }

        return NoContent();
    }

    [HttpPost]
    [Route("login")]
    [AllowAnonymous]
    public async Task<IActionResult> Login([FromBody] UserCredentials model)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);


        var user = await _userManager.FindByEmailAsync(model.Email);
        if (user == null)
            //todo: create custom ex or custom RegistrationResponseModel{bool:success, Errors:List<string>}
            return BadRequest();

        var correctPassword = await _userManager.CheckPasswordAsync(user, model.Password);
        if (!correctPassword)
            //todo: create custom ex or custom RegistrationResponseModel{bool:success, Errors:List<string>}
            return BadRequest();

        return Ok(await _tokenService.BuildToken(user));
    }

    [HttpGet]
    [Route("users")]
    [Authorize(Policy = Policies.IsAdmin)]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = await _userManager.Users.ToListAsync();
        var models = _mapper.Map<IEnumerable<UserModel>>(users);
        return Ok(models);
    }
}