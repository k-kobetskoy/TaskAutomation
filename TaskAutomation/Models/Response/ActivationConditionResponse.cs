namespace TaskAutomation.Models.Response;

public class ActivationConditionResponse
{
    public List<ActionResponse>? ConditionActions { get; set; }
    public ActionStatusResponse? ConditionActionsStatus { get; set; }
}