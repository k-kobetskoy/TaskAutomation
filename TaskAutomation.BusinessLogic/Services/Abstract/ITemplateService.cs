using TaskAutomation.BusinessLogic.Models;

namespace TaskAutomation.BusinessLogic.Services.Abstract;

public interface ITemplateService
{
    bool AddTemplate(TemplateModel model);
    bool UpdateTemplate(Guid id, TemplateModel model);
    List<TemplateModel>? GetTemplates();
    TemplateModel? GetTemplateById(Guid templateId);
    bool Delete(Guid templateId);
}