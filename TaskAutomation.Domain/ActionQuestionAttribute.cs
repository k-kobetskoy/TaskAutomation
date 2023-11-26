using TaskAutomation.Domain.Abstract;

namespace TaskAutomation.Domain;

public class ActionQuestionAttribute : ActionCommonAttribute
{
    public string? Question { get; set; }
    public string? AnswersString { get; set; }
    public string? CorrectAnswer { get; set; }
    public double? CorrectAnswerPoint { get; set; }
}