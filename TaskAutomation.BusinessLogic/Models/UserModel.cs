using TaskAutomation.BusinessLogic.Models.Abstract;

namespace TaskAutomation.BusinessLogic.Models;

public class UserModel: BaseModel
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; } 
    public string? DisplayName { get; set; }
    public string Email { get; set; } = null!;
    public string? Phone { get; set; }
}