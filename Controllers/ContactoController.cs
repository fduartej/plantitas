using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace plantitas.Controllers
{
    public class ContactoController
    {
        private readonly ILogger<ContactoController> _logger;

        public IActionResult Index()
        {
            return View();
        }
    }
}