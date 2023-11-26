using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DNMOFT.CostTrackr.Web.Models;
using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net;

namespace DNMOFT.CostTrackr.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly IConfiguration _config;

    public HomeController(ILogger<HomeController> logger, IConfiguration config)
    {
        _logger = logger;
        _config = config;
    }

    public IActionResult Index(string code)
    {
        if (string.IsNullOrEmpty(code))
            return View();

        var client = new RestClient("https://login.microsoftonline.com/common/oauth2/v2.0/token");
        var request = new RestRequest();
        request.Method = Method.Post;

        ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        request.AddParameter("grant_type", "authorization_code");
        request.AddParameter("code", code);
        request.AddParameter("redirect_uri", $"{Request.Scheme}://{Request.Host}/Home/Index");

        request.AddParameter("client_id", _config.GetValue<string>("Authentication:Microsoft:ClientId"));
        request.AddParameter("client_secret", _config.GetValue<string>("Authentication:Microsoft:ClientSecret"));

        var response = client.Execute(request);
        var content = response.Content;
        var res = (JObject)JsonConvert.DeserializeObject(content);

        var client2 = new RestClient("https://graph.microsoft.com/v1.0/me");
        client2.AddDefaultHeader("Authorization", $"Bearer {res["access_token"]}");
        request = new RestRequest();
        request.Method = Method.Get;
        var responser2 = client2.Execute(request);
        var content2 = responser2.Content;

        var user_data = (JObject)JsonConvert.DeserializeObject(content2);

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
