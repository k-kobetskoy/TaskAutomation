namespace TaskAutomation.BusinessLogic.Models.Abstract;

public class ActionCommonAttributeModel : BaseModel
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public double? CompletionPoint { get; set; }
}