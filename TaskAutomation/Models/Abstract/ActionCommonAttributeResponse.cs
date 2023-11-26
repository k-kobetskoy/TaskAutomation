namespace TaskAutomation.Models.Abstract;

public class ActionCommonAttributeResponse : BaseModel
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public double? CompletionPoint { get; set; }
}