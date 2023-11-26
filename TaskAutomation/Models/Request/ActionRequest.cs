using TaskAutomation.Models.Abstract;

namespace TaskAutomation.Models.Request;

public class ActionRequest : BaseModel
{
    public string? Name { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public TimeSpan? Duration { get; set; }
    public ActionStatusRequest? ActionStatus { get; set; }
    public ActionRequest? RunAfter { get; set; }
    public List<ActivationConditionRequest>? ActivationConditions { get; set; }
    public List<ActionSimpleAttributeRequest>? SimpleAttributes { get; set; }
    public List<ActionQuestionAttributeRequest>? QuestionAttributes { get; set; }
    public List<ActionInputAttributeRequest>? InputAttribute { get; set; }
    public double? CompletionPoints { get; set; }
}