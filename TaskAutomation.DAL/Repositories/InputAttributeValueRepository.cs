using TaskAutomation.DAL.Abstract;
using TaskAutomation.DAL.Abstract.Interfaces;
using TaskAutomation.Domain;

namespace TaskAutomation.DAL.Repositories;

public class InputAttributeValueRepository : BusinessRepository<InputAttributeValue>, IInputAttributeValueRepository
{
    public InputAttributeValueRepository(TaskAutomationBusinessDbContext context) : base(context)
    {
    }
}