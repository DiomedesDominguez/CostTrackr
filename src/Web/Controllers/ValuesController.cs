using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace DNMOFT.CostTrackr.Web.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return new string[] { "value1", "value2" };
    }
}