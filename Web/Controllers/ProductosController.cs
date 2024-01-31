using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNMOFT.CostTrackR.Web.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Authorize]
    public class ProductosController : Controller
    {
        private readonly ILogger<ProductosController> _logger;
        private readonly ApplicationDbContext _context;

        public ProductosController(ILogger<ProductosController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }
    }
}