using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNMOFT.CostTrackR.Web.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace DNMOFT.CostTrackR.Web.Controllers;
[Authorize]
public class ImpuestosControllers: Controller
{
private readonly ILogger<ImpuestosControllers> _logger;
    private readonly ApplicationDbContext _context;

    public ImpuestosControllers(ILogger<ImpuestosControllers> logger, ApplicationDbContext context)
    {
        _context = context;
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    
}