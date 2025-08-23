using Microsoft.AspNetCore.Mvc;
using TechnologyPracticeTestWeb.Requests.ModifyStringRequest;
using TechnologyPracticeTestWeb.Services.StringModifierService.Interfaces;

namespace TechnologyPracticeTestWeb.Controllers;

[ApiController]
[Route("[controller]")]
public class ModifyStringController : ControllerBase
{
    private IStringModifierService StringModifierService { get; }

    public ModifyStringController(IStringModifierService stringModifierService)
    {
        StringModifierService = stringModifierService;
    }

    [HttpGet]
    public ActionResult Index([FromQuery] ModifyStringRequest request)
    {
        var result = StringModifierService.Modify(request);
        return Ok(result);
    }
}