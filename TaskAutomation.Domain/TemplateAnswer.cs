using TaskAutomation.Domain.Abstract;

namespace TaskAutomation.Domain;

public class TemplateAnswer : BaseEntity
{
    public string Name { get; set; } = null!;
    public ActionQuestionAttribute? Question { get; set; }
    public string? Answer { get; set; }
}