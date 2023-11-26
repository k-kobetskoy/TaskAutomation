namespace TaskAutomation.Models.Response;

public class TemplateResponse
{
    public string? Name { get; set; }
    public List<ActionResponse>? Actions { get; set; }
    public List<TemplatePointResponse>? TemplatePoints { get; set; }
    public List<TemplateAnswerResponse>? TemplateAnswers { get; set; }
}