using TaskAutomation.Models.Abstract;

namespace TaskAutomation.Models.Request;

public class TemplateAnswerRequest : BaseRequestModel
{
    public string Name { get; set; } = null!;
    public ActionQuestionAttributeRequest? Question { get; set; }
    public string? Answer { get; set; }
}