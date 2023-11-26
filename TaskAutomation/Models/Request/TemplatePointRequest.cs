using TaskAutomation.Models.Abstract;

namespace TaskAutomation.Models.Request;

public class TemplatePointRequest : BaseRequestModel
{
    public string? Name { get; set; }
    public double Value { get; set; }
}