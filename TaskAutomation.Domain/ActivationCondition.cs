using TaskAutomation.Domain.Abstract;

namespace TaskAutomation.Domain;

public class ActivationCondition : BaseEntity
{
    public List<Action>? ConditionActions { get; set; }
    public ActionStatus? ConditionActionsStatus { get; set; }
}