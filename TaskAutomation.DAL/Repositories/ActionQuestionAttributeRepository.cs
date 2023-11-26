using TaskAutomation.DAL.Abstract;
using TaskAutomation.DAL.Abstract.Interfaces;
using TaskAutomation.Domain;

namespace TaskAutomation.DAL.Repositories;

public class ActionQuestionAttributeRepository : BusinessRepository<ActionQuestionAttribute>, IActionQuestionAttributeRepository
{
    public ActionQuestionAttributeRepository(TaskAutomationBusinessDbContext context) : base(context)
    {
    }
}