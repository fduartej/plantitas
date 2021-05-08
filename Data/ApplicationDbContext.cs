using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using plantitas.Models;

namespace plantitas.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<plantitas.Models.Contacto> DataContactos { get; set; }
        public DbSet<plantitas.Models.PrePedido> DataCarrito { get; set; }
        public DbSet<plantitas.Models.Producto> DataProductos { get; set; }
    }
}
