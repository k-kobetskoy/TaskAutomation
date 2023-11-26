using TaskAutomation.Domain.Abstract;

namespace TaskAutomation.Domain;

public class InputAttributeValue : BaseEntity
{
    public string? Name { get; set; }
    public ActionInputAttribute? ActionInputAttribute { get; set; }
    public string? Value { get; set; }
}