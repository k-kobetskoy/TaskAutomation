using TaskAutomation.BusinessLogic.Models.Abstract;

namespace TaskAutomation.BusinessLogic.Models;

public class ActivationConditionModel : BaseModel
{
    public List<ActionModel>? ConditionActions { get; set; }
    public ActionStatusModel? ConditionActionsStatus { get; set; }
}