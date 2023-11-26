using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using TaskAutomation.Domain.Identity;

namespace TaskAutomation.DAL.Services;

public class TaskAutomationIdentityDbInitializer
{
    private readonly TaskAutomationIdentityDbContext _identityDbContext;
    private readonly ILogger<TaskAutomationIdentityDbContext> _logger;
    private readonly RoleManager<Role> _roleManager;
    private readonly UserManager<User> _userManager;

    public TaskAutomationIdentityDbInitializer(
        TaskAutomationIdentityDbContext identityDbContext,
        ILogger<TaskAutomationIdentityDbContext> logger,
        RoleManager<Role> roleManager,
        UserManager<User> userManager)
    {
        _identityDbContext = identityDbContext;
        _logger = logger;
        _roleManager = roleManager;
        _userManager = userManager;
    }

    public void Initialize()
    {
        _logger.LogInformation("Db initialization...");
        var db = _identityDbContext.Database;

        #region Delete-Create

        db.EnsureDeleted();
        _logger.LogInformation("Db deleted");

        db.EnsureCreated();
        _logger.LogInformation("Db created");

        #endregion

        #region Users
        try
        {
            _logger.LogInformation("Users initialization...");
            InitializeIdentity().Wait();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Users initialization ERROR");
            throw;
        }
        _logger.LogInformation("Users were initialized");

        _logger.LogInformation("Db initialized");
        #endregion
    }

    private async Task InitializeIdentity()
    {
        await CreateUser(AdminUserConstants.RoleName, AdminUserConstants.Email, AdminUserConstants.Password);
        
        await CreateUser(RegularUserConstants.RoleName, RegularUserConstants.Email, RegularUserConstants.Password);
    }

    private async Task CreateUser(string roleName, string email, string password)
    {
        await CheckIfRoleExists(roleName);
        
        if (await _userManager.FindByEmailAsync(email) is null)
        {
            _logger.LogInformation($"user with email {email} doesn't exist. Begin creating user.");
            
            var user = new User
            {
                UserName = email,
                Email = email
            };

            var creationResult = await _userManager.CreateAsync(user, password);

            if (creationResult.Succeeded)
            {
                var result = await _userManager.AddToRoleAsync(user, roleName);
                if (!result.Succeeded)
                    _logger.LogError($"could not set role for {roleName} user");
            }
            else
            {
                var errors = creationResult.Errors.Select(e => e.Description);
                throw new InvalidOperationException($"Error while creating admin user {string.Join(',', errors)}");
            }
        }
    }

    private async Task CheckIfRoleExists(string roleName)
    {
        if (!await _roleManager.RoleExistsAsync(roleName))
        {
            _logger.LogInformation($"{roleName} role doesn't exist. Creating role...");
            await _roleManager.CreateAsync(new Role { Name = roleName });
        }
    }
}