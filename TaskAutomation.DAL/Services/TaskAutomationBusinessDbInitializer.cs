using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace TaskAutomation.DAL.Services;

public class TaskAutomationBusinessDbInitializer
{
    private readonly TaskAutomationBusinessDbContext _businessDbContext;
    private readonly ILogger<TaskAutomationBusinessDbInitializer> _logger;

    public TaskAutomationBusinessDbInitializer(
        TaskAutomationBusinessDbContext businessDbContext, 
        ILogger<TaskAutomationBusinessDbInitializer> logger)
    {
        _businessDbContext = businessDbContext;
        _logger = logger;
    }
    public void Initialize()
    {
        _logger.LogInformation("Db initialization...");
        var db = _businessDbContext.Database;

        #region Delete-Create

        db.EnsureDeleted();
        _logger.LogInformation("Db deleted");

        db.EnsureCreated();
        _logger.LogInformation("Db created");

        #endregion
    }
}