using TaskAutomation.BusinessLogic.Models.Abstract;

namespace TaskAutomation.BusinessLogic.Models;

public class ActionModel : BaseModel
{
    public string? Name { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public TimeSpan? Duration { get; set; }
    public ActionStatusModel? ActionStatus { get; set; }
    public ActionModel? RunAfter { get; set; }
    public List<ActivationConditionModel>? ActivationConditions { get; set; }
    public List<ActionSimpleAttributeModel>? SimpleAttributes { get; set; }
    public List<ActionQuestionAttributeModel>? QuestionAttributes { get; set; }
    public List<ActionInputAttributeModel>? InputAttribute { get; set; }
    public double? CompletionPoints { get; set; }
    public bool? IsDeleted { get; set; }
}