using TaskAutomation.BusinessLogic.Models.Abstract;

namespace TaskAutomation.BusinessLogic.Models;

public class TemplateAnswerModel : BaseModel
{
    public string Name { get; set; } = null!;
    public ActionQuestionAttributeModel? Question { get; set; }
    public string? Answer { get; set; }
}