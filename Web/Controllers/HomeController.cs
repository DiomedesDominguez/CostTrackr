using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DNMOFT.CostTrackR.Web.Models;
using Microsoft.AspNetCore.Authorization;
using DNMOFT.CostTrackR.Web.Data;

namespace DNMOFT.CostTrackR.Web.Controllers;
[Authorize]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _context = context;
        _logger = logger;
    }

    public IActionResult Index()
    {
        var user = _context.Users.FirstOrDefault(x => x.UserName == User.Identity.Name);
        if (user != null)
            ViewData["User"] =string.Concat(user.Name, " ", user.LastName);

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
[AllowAnonymous]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
