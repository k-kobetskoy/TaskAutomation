using Microsoft.AspNetCore.Identity;
using TaskAutomation.Domain.Abstract;

namespace TaskAutomation.Domain.Identity;

public class Role : IdentityRole<Guid>, IBaseEntity
{
}