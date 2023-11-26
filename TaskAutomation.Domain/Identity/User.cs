using Microsoft.AspNetCore.Identity;
using TaskAutomation.Domain.Abstract;

namespace TaskAutomation.Domain.Identity;

public class User : IdentityUser<Guid>, IBaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? DisplayName { get; set; }
}