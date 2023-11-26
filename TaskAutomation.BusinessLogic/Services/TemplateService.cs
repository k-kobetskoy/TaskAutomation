using TaskAutomation.BusinessLogic.Models;
using TaskAutomation.BusinessLogic.Services.Abstract;

namespace TaskAutomation.BusinessLogic.Services;

public class TemplateService : ITemplateService
{
    public bool AddTemplate(TemplateModel model)
    {
        throw new NotImplementedException();
    }

    public bool UpdateTemplate(Guid id, TemplateModel model)
    {
        throw new NotImplementedException();
    }

    public List<TemplateModel> GetTemplates()
    {
        throw new NotImplementedException();
    }

    public TemplateModel GetTemplateById(Guid templateId)
    {
        throw new NotImplementedException();
    }

    public bool Delete(Guid templateId)
    {
        throw new NotImplementedException();
    }
}