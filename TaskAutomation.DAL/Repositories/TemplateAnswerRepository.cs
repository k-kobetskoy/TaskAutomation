using TaskAutomation.DAL.Abstract;
using TaskAutomation.DAL.Abstract.Interfaces;
using TaskAutomation.Domain;

namespace TaskAutomation.DAL.Repositories;

public class TemplateAnswerRepository : BusinessRepository<TemplateAnswer>, ITemplateAnswerRepository
{
    public TemplateAnswerRepository(TaskAutomationBusinessDbContext context) : base(context)
    {
    }
}