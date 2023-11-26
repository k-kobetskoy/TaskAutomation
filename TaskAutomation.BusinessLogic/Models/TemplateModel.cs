using TaskAutomation.BusinessLogic.Models.Abstract;

namespace TaskAutomation.BusinessLogic.Models;

public class TemplateModel : BaseModel
{
    public string? Name { get; set; }
    public List<ActionModel>? Actions { get; set; }
    public List<TemplatePointModel>? TemplatePoints { get; set; }
    public List<TemplateAnswerModel>? TemplateAnswers { get; set; }
}