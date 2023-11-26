using TaskAutomation.DAL.Abstract;
using TaskAutomation.DAL.Abstract.Interfaces;
using TaskAutomation.Domain;

namespace TaskAutomation.DAL.Repositories;

public class ActionSimpleAttributeRepository : BusinessRepository<ActionSimpleAttribute>, IActionSimpleAttributeRepository
{
    public ActionSimpleAttributeRepository(TaskAutomationBusinessDbContext context) : base(context)
    {
    }
}