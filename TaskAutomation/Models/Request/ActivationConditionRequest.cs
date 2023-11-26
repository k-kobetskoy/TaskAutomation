using TaskAutomation.Models.Abstract;

namespace TaskAutomation.Models.Request;

public class ActivationConditionRequest : BaseModel
{
    public List<ActionRequest>? ConditionActions { get; set; }
    public ActionStatusRequest? ConditionActionsStatus { get; set; }
}