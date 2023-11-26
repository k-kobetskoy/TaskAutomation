using Microsoft.AspNetCore.Identity;
using TaskAutomation.Domain.Abstract;

namespace TaskAutomation.Domain.Identity;

public class User : IdentityUser<Guid>, IBaseEntity
{
}