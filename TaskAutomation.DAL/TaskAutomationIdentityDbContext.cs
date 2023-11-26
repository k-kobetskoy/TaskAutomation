using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskAutomation.Domain.Identity;

namespace TaskAutomation.DAL;

public class TaskAutomationIdentityDbContext : IdentityDbContext<User, Role, Guid>
{
    public TaskAutomationIdentityDbContext(DbContextOptions<TaskAutomationIdentityDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}