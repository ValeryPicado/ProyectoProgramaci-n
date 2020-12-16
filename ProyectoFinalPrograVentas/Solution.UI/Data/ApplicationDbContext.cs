using System;
using System.Collections.Generic;
using System.Text;
using Solution.UI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Solution.UI.ViewModel;

namespace Solution.UI.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<TipoProducto> TipoProducto { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Carrito> Carrito { get; set; }
        //public DbSet<ProductoViewModel> ProductoViewModels { get; set; }
    }
}
