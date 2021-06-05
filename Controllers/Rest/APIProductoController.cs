using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using plantitas.Models;
using plantitas.Data;

namespace plantitas.Controllers.Rest
{
    [ApiController]
    [Route("api/productos")]
    public class APIProductoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public APIProductoController(ApplicationDbContext context){
             _context = context;
        }

        [HttpGet]
        public IEnumerable<Producto> ListProductos()
        {
             var listProductos=_context.DataProductos.OrderBy(s => s.ID).ToList();   
             return listProductos.ToArray();
        }

        [HttpGet("{id}")]
        public Producto GetProduct(int? id)
        {
            var producto =  _context.DataProductos.Find(id);
            return producto;
        }

        [HttpPost]
        public Producto CreateProduct(Producto producto){
            _context.Add(producto);
            _context.SaveChanges();
            return producto;
        }
    }
}