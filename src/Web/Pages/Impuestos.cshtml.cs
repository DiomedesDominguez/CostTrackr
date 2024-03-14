using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DNMOFT.CostTrackr.Web.Pages
{
    public class Impuestos : PageModel
    {
        private readonly ILogger<Impuestos> _logger;

        public Impuestos(ILogger<Impuestos> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}