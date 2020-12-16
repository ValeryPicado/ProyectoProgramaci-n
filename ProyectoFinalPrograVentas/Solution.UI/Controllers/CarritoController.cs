using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Solution.UI.Data;
using Solution.UI.Models;
using Solution.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Solution.UI.Controllers
{
    public class CarritoController : Controller
    {
        private readonly ILogger<CarritoController> _logger;

        private readonly ApplicationDbContext Context;

        private readonly IWebHostEnvironment WebHostEnvironment;

        public CarritoController(ILogger<CarritoController> logger, ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            Context = context;
            WebHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var items = Context.Carrito.ToList();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.IdUsuario = userId;

            decimal indexCarrito = 0;

            foreach (var item in items)
            {
                if (userId.Equals(item.IdUsuario))
                {
                    indexCarrito += item.TotalC;
                }
            }

            ViewBag.TotalCompra = indexCarrito;

            return View(items);
        }

        // GET: CarritoController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: CarritoController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarritoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CarritoViewModel vm)
        {
            var carrito = new Carrito
            {
                IdProducto = vm.IdProducto,
                NombreProductoC = vm.NombreProductoC,
                TipoProductoC = vm.TipoProductoC,
                PrecioC = vm.PrecioC,
                CantidadC = vm.CantidadC,
                TotalC = vm.PrecioC * vm.CantidadC
            };
            Context.Carrito.Add(carrito);
            Context.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: CarritoController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: CarritoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrito = await Context.Carrito
                .FirstOrDefaultAsync(p => p.IdCarrito == id);

            if (carrito == null)
            {
                return NotFound();
            }

            return View(carrito);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed([Bind("IdCarrito,IdProducto,IdUsuario,NombreProductoC,TipoProductoC,PrecioC","CantidadC","TotalC")] Carrito vm, int id)
        {
            var carritoProducto = await Context.Carrito.FindAsync(id);

            int IdProducto = carritoProducto.IdProducto;

            var Producto = await Context.Productos.FindAsync(IdProducto);
            int unidades = Producto.Cantidad;
            int suma = carritoProducto.CantidadC;

            Producto.Cantidad = unidades + suma;

            Context.Productos.Update(Producto);
            Context.SaveChanges();

            var carrito = await Context.Carrito.FindAsync(id);
            Context.Carrito.Remove(carrito);
            await Context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
