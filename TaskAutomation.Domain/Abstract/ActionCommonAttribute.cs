namespace TaskAutomation.Domain.Abstract;

public abstract class ActionCommonAttribute : BaseEntity
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public double? CompletionPoint { get; set; }
}