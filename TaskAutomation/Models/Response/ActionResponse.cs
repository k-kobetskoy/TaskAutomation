namespace TaskAutomation.Models.Response;

public class ActionResponse
{
    public string? Name { get; set; }
    public TimeSpan? Duration { get; set; }
    public ActionResponse? RunAfter { get; set; }
    public List<ActivationConditionResponse>? ActivationConditions { get; set; }
    public List<ActionSimpleAttributeResponse>? SimpleAttributes { get; set; }
    public List<ActionQuestionAttributeResponse>? QuestionAttributes { get; set; }
    public List<ActionInputAttributeResponse>? InputAttribute { get; set; }
    public double? CompletionPoints { get; set; }
    public ActionTransactionTypeResponse? TransactionType { get; set; }
}