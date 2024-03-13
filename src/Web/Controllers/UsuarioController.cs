
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Caching.Distributed;


namespace DNMOFT.CostTrackr.Web.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly ILogger<UsuarioController> _logger;
    private readonly IDistributedCache _distributedCache;
    public UsuarioController(ILogger<UsuarioController> logger,
        IDistributedCache distributedCache)
    {
        _logger = logger;
        _distributedCache = distributedCache;        
    }
    public class UsuarioModel
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
[HttpGet]
    public ActionResult<UsuarioModel> Get()
    {
        var usuario = 
        return new UsuarioModel { Name = "", Email = "Email" };
    }
}
