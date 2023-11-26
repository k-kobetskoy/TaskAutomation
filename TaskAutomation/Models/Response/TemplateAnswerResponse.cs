using TaskAutomation.Domain;

namespace TaskAutomation.Models.Response;

public class TemplateAnswerResponse
{
    public ActionQuestionAttributeResponse? Question { get; set; }
    public string? Answer { get; set; }
}