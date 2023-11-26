namespace TaskAutomation.Models.Abstract;

public class ActionCommonAttributeRequest : BaseModel
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public double? CompletionPoint { get; set; }
}