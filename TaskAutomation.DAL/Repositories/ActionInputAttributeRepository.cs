using TaskAutomation.DAL.Abstract;
using TaskAutomation.DAL.Abstract.Interfaces;
using TaskAutomation.Domain;

namespace TaskAutomation.DAL.Repositories;

public class ActionInputAttributeRepository : BusinessRepository<ActionInputAttribute>, IActionInputAttributeRepository
{
    public ActionInputAttributeRepository(TaskAutomationBusinessDbContext context): base(context)
    {
        
    }
}