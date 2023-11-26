using TaskAutomation.DAL.Abstract;
using TaskAutomation.DAL.Abstract.Interfaces;
using TaskAutomation.Domain;

namespace TaskAutomation.DAL.Repositories;

public class StatusRepository : BusinessRepository<ActionStatus>, IStatusRepository
{
    public StatusRepository(TaskAutomationBusinessDbContext context) : base(context)
    {
    }
}