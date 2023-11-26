using TaskAutomation.Domain.Abstract;

namespace TaskAutomation.Domain;

public class Action : BaseEntity
{
    public string? Name { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public TimeSpan? Duration { get; set; }
    public ActionStatus? ActionStatus { get; set; }
    public Action? RunAfter { get; set; }
    public List<ActivationCondition>? ActivationConditions { get; set; }
    public List<ActionSimpleAttribute>? SimpleAttributes { get; set; }
    public List<ActionQuestionAttribute>? QuestionAttributes { get; set; }
    public List<ActionInputAttribute>? InputAttribute { get; set; }
    public double? CompletionPoints { get; set; }
}