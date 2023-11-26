using TaskAutomation.DAL.Abstract;
using TaskAutomation.DAL.Abstract.Interfaces;
using Action = TaskAutomation.Domain.Action;

namespace TaskAutomation.DAL.Repositories;

public class ActionRepository : BusinessRepository<Action>, IActionRepository
{
    public ActionRepository(TaskAutomationBusinessDbContext context) : base(context)
    {
    }
}