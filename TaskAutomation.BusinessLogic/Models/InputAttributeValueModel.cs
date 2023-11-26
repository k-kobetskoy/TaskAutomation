using TaskAutomation.BusinessLogic.Models.Abstract;

namespace TaskAutomation.BusinessLogic.Models;

public class InputAttributeValueModel : BaseModel
{
    public string? Name { get; set; }
    public ActionInputAttributeModel? ActionInputAttribute { get; set; }
    public string? Value { get; set; }
}