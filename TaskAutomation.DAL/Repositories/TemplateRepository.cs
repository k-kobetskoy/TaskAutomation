using TaskAutomation.DAL.Abstract;
using TaskAutomation.DAL.Abstract.Interfaces;
using TaskAutomation.Domain;

namespace TaskAutomation.DAL.Repositories;

public class TemplateRepository: BusinessRepository<Template>, ITemplateRepository
{
    public TemplateRepository(TaskAutomationBusinessDbContext context) : base(context)
    {
    }
}