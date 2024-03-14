using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace DNMOFT.CostTrackr.Web.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class ValuesController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return new string[] { "value1", "value2" };
    }
}