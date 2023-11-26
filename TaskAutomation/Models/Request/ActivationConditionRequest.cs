using TaskAutomation.Models.Abstract;

namespace TaskAutomation.Models.Request;

public class ActivationConditionRequest : BaseRequestModel
{
    public List<ActionRequest>? ConditionActions { get; set; }
    public ActionStatusRequest? ConditionActionsStatus { get; set; }
}