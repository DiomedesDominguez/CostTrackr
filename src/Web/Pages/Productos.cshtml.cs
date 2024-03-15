using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNMOFT.CostTrackr.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;

namespace DNMOFT.CostTrackr.Web.Pages;
public class Productos : PageModel
{
    private readonly ILogger<Productos> _logger;
    private readonly IDistributedCache _distributedCache;
    private readonly ApplicationDbContext _dbContext;

    public Productos(ILogger<Productos> logger,
    IDistributedCache distributedCache, ApplicationDbContext dbContext)
    {
        _logger = logger;
        _distributedCache = distributedCache;
        _dbContext = dbContext;
    }

    public void OnGet()
    {
    }
}