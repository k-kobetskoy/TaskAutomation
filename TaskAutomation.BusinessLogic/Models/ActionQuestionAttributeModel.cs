using TaskAutomation.BusinessLogic.Models.Abstract;

namespace TaskAutomation.BusinessLogic.Models;

public class ActionQuestionAttributeModel : ActionCommonAttributeModel
{
    public string? Question { get; set; }
    public string? AnswersString { get; set; }
    public string? CorrectAnswer { get; set; }
    public double? CorrectAnswerPoint { get; set; }
}