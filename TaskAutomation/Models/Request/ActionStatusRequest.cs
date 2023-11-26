using TaskAutomation.Models.Abstract;

namespace TaskAutomation.Models.Request;

public class ActionStatusRequest : BaseRequestModel
{
    public string Name { get; set; } = null!;
}