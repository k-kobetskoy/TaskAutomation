using TaskAutomation.BusinessLogic.Models.Abstract;

namespace TaskAutomation.BusinessLogic.Models;

public class TemplatePointModel : BaseModel
{
    public string? Name { get; set; }
    public double Value { get; set; }
}