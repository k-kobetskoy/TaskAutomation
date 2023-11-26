using TaskAutomation.Models.Abstract;

namespace TaskAutomation.Models.Request;

public class InputAttributeValueRequest : BaseRequestModel
{
    public string? Name { get; set; }
    public ActionInputAttributeRequest? ActionInputAttribute { get; set; }
    public string? Value { get; set; }
}