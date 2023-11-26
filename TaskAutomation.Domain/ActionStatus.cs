using TaskAutomation.Domain.Abstract;

namespace TaskAutomation.Domain;

public class ActionStatus: BaseEntity
{
    public string Name { get; set; } = null!;
}