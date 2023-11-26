using TaskAutomation.Models.Abstract;

namespace TaskAutomation.Models.Response;

public class ActionQuestionAttributeResponse : ActionCommonAttributeResponse
{
    public string? Question { get; set; }
    public List<string>? Answers { get; set; }
    public string? CorrectAnswer { get; set; }
    public double? CorrectAnswerPoint { get; set; }
}