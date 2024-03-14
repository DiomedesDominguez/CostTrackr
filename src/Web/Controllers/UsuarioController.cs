using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Caching.Distributed;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.Web.Helpers;
using Microsoft.EntityFrameworkCore;

namespace DNMOFT.CostTrackr.Web.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly ILogger<UsuarioController> _logger;
    private readonly IDistributedCache _distributedCache;
    private readonly ApplicationDbContext _dbContext;

    public UsuarioController(ILogger<UsuarioController> logger,
        IDistributedCache distributedCache, ApplicationDbContext dbContext)
    {
        _logger = logger;
        _distributedCache = distributedCache;
        _dbContext = dbContext;
    }
    public class UsuarioModel
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
    [HttpGet]
    public async Task<ActionResult<UsuarioModel>> Get()
    {
        var usuario = new UsuarioModel();
        if (User.Identity != null)
        {
            var cacheEmail = await _distributedCache.GetRecordAsync<string>(DistributedCacheKeys.UserEmail);
            var cacheName = await _distributedCache.GetRecordAsync<string>(DistributedCacheKeys.UserName);

            if (cacheName != null && cacheEmail != null)
            {
                usuario = new UsuarioModel
                {

                    Name = cacheName,
                    Email = cacheEmail
                };
                return usuario;
            }
            else
            {
                var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == User.Identity.Name);
                if (user != null)
                {
                    usuario = new UsuarioModel
                    {
                        Name = $"{user.Name} {user.LastName}",
                        Email = user.Email
                    };
                    await _distributedCache.SetRecordAsync(DistributedCacheKeys.UserName, usuario.Name);
                    await _distributedCache.SetRecordAsync(DistributedCacheKeys.UserEmail, usuario.Email);
                }
            }
        }

        return usuario;
    }
}