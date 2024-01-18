using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DNMOFT.CostTrackR.Web.Controllers;
public class ErrorController : Controller
{
	[Route("/Error/{statusCode}")]
	public IActionResult HttpStatusCodeHandler(int statusCode)
	{
		if (statusCode == 404)
		{
			return View("404");
		}

		// Handle other error codes if desired

		return View("Error");
	}
}
