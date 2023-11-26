using AutoMapper;
using TaskAutomation.BusinessLogic.Models;
using TaskAutomation.Domain;
using TaskAutomation.Domain.Identity;
using Action = TaskAutomation.Domain.Action;

namespace TaskAutomation.BusinessLogic.Mapping;

public class ModelMappingProfile : Profile
{
    public ModelMappingProfile()
    {
        #region ToDomain
        
        CreateMap<ActionInputAttributeModel, ActionInputAttribute>();

        CreateMap<ActionModel, Action>();

        CreateMap<ActionQuestionAttributeModel, ActionQuestionAttribute>();

        CreateMap<ActionSimpleAttributeModel, ActionSimpleAttribute>();

        CreateMap<ActionStatusModel, ActionStatus>();

        CreateMap<ActivationConditionModel, ActivationCondition>();

        CreateMap<InputAttributeValueModel, InputAttributeValue>();

        CreateMap<TemplateAnswerModel, TemplateAnswer>();

        CreateMap<TemplateModel, Template>();

        CreateMap<TemplatePointModel, TemplatePoint>();

        CreateMap<UserModel, User>();

        #endregion

        #region ToModel

        CreateMap<ActionInputAttribute, ActionInputAttributeModel>();

        CreateMap<Action, ActionModel>();

        CreateMap<ActionQuestionAttribute, ActionInputAttributeModel>();

        CreateMap<ActionSimpleAttribute, ActionSimpleAttributeModel>();

        CreateMap<ActionStatus, ActionStatusModel>();

        CreateMap<ActivationCondition, ActivationConditionModel>();

        CreateMap<InputAttributeValue, InputAttributeValueModel>();

        CreateMap<TemplateAnswer, TemplateAnswerModel>();

        CreateMap<Template, TemplateModel>();

        CreateMap<TemplatePoint, TemplatePointModel>();

        CreateMap<User, UserModel>();

        #endregion
    }
}