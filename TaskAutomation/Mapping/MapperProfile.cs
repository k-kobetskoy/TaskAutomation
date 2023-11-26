using AutoMapper;
using TaskAutomation.BusinessLogic.Models;
using TaskAutomation.Models.Request;
using TaskAutomation.Models.Response;

namespace TaskAutomation.Mapping;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        #region Response

        CreateMap<TemplateResponse, TemplateModel>();

        CreateMap<ActionResponse, ActionModel>();

        CreateMap<ActionInputAttributeResponse, ActionInputAttributeModel>();

        CreateMap<ActionQuestionAttributeResponse, ActionQuestionAttributeModel>();

        CreateMap<ActionSimpleAttributeResponse, ActionSimpleAttributeModel>();

        CreateMap<ActivationConditionResponse, ActivationConditionModel>();

        CreateMap<ActionStatusResponse, ActionStatusModel>();

        CreateMap<InputAttributeValueResponse, InputAttributeValueModel>();

        CreateMap<TemplateAnswerResponse, TemplateAnswerModel>();

        CreateMap<TemplatePointResponse, TemplatePointModel>();

        #endregion

        #region Request

        CreateMap<TemplateModel?, TemplateRequest?>();

        CreateMap<ActionModel, ActionRequest>();

        CreateMap<ActionInputAttributeModel, ActionInputAttributeRequest>();

        CreateMap<ActionQuestionAttributeModel, ActionQuestionAttributeRequest>();

        CreateMap<ActionStatusModel, ActionStatusRequest>();

        CreateMap<ActionSimpleAttributeModel, ActionSimpleAttributeRequest>();

        CreateMap<ActivationConditionModel, ActivationConditionRequest>();

        CreateMap<InputAttributeValueModel, InputAttributeValueRequest>();

        CreateMap<TemplateAnswerModel, TemplateAnswerRequest>();

        CreateMap<TemplatePointModel, TemplatePointRequest>();

        #endregion
    }
}