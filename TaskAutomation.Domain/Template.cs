using TaskAutomation.Domain.Abstract;

namespace TaskAutomation.Domain;

public class Template : BaseEntity
{
    public string? Name { get; set; }
    public List<Action>? Actions { get; set; }
    public List<TemplatePoint>? TemplatePoints { get; set; }
    public List<TemplateAnswer>? TemplateAnswers { get; set; }
}