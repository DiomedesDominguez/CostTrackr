using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DNMOFT.CostTrackr.Web.Pages;

[Authorize]
public class ProductsModel : PageModel
    {
        public void OnGet()
        {
        }
    }