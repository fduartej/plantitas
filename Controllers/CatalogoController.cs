using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using plantitas.Models;
using plantitas.Data;
using Microsoft.EntityFrameworkCore;

namespace plantitas.Controllers
{
    public class CatalogoController : Controller
    {
        
        private readonly ILogger<CatalogoController> _logger;
        private readonly ApplicationDbContext _context;
        

        public CatalogoController(ILogger<CatalogoController> logger,ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        
        public async Task<IActionResult> Index()
        {
            var productos = from o in _context.DataProductos select o;
            productos = productos.Where(s => s.Status.Equals("A"));
            return View(await productos.ToListAsync());
        }

    }
}