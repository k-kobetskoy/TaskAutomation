using TaskAutomation.DAL.Abstract;
using TaskAutomation.DAL.Abstract.Interfaces;
using TaskAutomation.Domain;

namespace TaskAutomation.DAL.Repositories;

public class ActivationConditionRepository : BusinessRepository<ActivationCondition>, IActivationConditionRepository
{
    public ActivationConditionRepository(TaskAutomationBusinessDbContext context) : base(context)
    {
    }
}