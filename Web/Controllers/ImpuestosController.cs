using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNMOFT.CostTrackR.Web.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace DNMOFT.CostTrackR.Web.Controllers;
[Authorize]
public class ImpuestosController: Controller
{
private readonly ILogger<ImpuestosController> _logger;
    private readonly ApplicationDbContext _context;

    public ImpuestosController(ILogger<ImpuestosController> logger, ApplicationDbContext context)
    {
        _context = context;
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    
}