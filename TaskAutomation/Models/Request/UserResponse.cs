using TaskAutomation.Models.Abstract;

namespace TaskAutomation.Models.Request;

public class UserRequest : BaseModel
{
    public string? DisplayName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string Email { get; set; } = null!;
}