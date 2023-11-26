using TaskAutomation.Models.Abstract;

namespace TaskAutomation.Models.Response;

public class UserResponse : BaseModel
{
    public string? DisplayName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string Email { get; set; } = null!;
}