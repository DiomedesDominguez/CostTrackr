using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DNMOFT.CostTrackr.Web.Pages
{
    public class Productos : PageModel
    {
        private readonly ILogger<Productos> _logger;

        public Productos(ILogger<Productos> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}