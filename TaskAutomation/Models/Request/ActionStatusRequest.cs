using TaskAutomation.Models.Abstract;

namespace TaskAutomation.Models.Request;

public class ActionStatusRequest : BaseModel
{
    public string Name { get; set; } = null!;
}