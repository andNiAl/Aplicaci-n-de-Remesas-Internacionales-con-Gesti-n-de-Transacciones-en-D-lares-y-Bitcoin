using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace app_remesas_parcial.Controllers
{
    [Route("[controller]")]
    public class TransaccionesController : Controller
    {
        private readonly ILogger<TransaccionesController> _logger;

        public TransaccionesController(ILogger<TransaccionesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}