using TaskAutomation.Domain.Abstract;

namespace TaskAutomation.Domain;

public class TemplatePoint : BaseEntity
{
    public string? Name { get; set; }
    public double Value { get; set; }
}