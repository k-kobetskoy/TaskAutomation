using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TaskAutomation.BusinessLogic.Models;
using TaskAutomation.BusinessLogic.Services.Abstract;
using TaskAutomation.Models.Response;

namespace TaskAutomation.Controllers;

[Produces("application/json")]
[Route("api/[controller]")]
[ApiController]
public class TemplatesController : ControllerBase
{
    private readonly ITemplateService _templateService;
    private readonly IMapper _mapper;

    public TemplatesController(ITemplateService templateService, IMapper mapper)
    {
        _templateService = templateService;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult GetAllByUser()
    {
        var templates = _templateService.GetTemplates();
        return Ok(_mapper.Map<List<TemplateResponse>?>(templates));
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetById(Guid id)
    {
        var template = _templateService.GetTemplateById(id);
        return Ok(template);
    }

    [HttpPost]
    public IActionResult Add([FromBody] TemplateResponse response)
    {
        _templateService.AddTemplate(_mapper.Map<TemplateModel>(response));
        return Ok();
    }

    [HttpPut("{id:guid}")]
    public IActionResult Update(Guid id, [FromBody] TemplateResponse response)
    {
        _templateService.UpdateTemplate(id, _mapper.Map<TemplateModel>(response));
        return Ok();
    }

    [HttpDelete("{id:guid}")]
    public IActionResult Delete(Guid id)
    {
        _templateService.Delete(id);
        return Ok();
    }
}