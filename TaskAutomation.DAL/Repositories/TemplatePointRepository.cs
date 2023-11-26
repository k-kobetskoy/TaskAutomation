using TaskAutomation.DAL.Abstract;
using TaskAutomation.DAL.Abstract.Interfaces;
using TaskAutomation.Domain;

namespace TaskAutomation.DAL.Repositories;

public class TemplatePointRepository : BusinessRepository<TemplatePoint>, ITemplatePointRepository
{
    public TemplatePointRepository(TaskAutomationBusinessDbContext context) : base(context)
    {
    }
}