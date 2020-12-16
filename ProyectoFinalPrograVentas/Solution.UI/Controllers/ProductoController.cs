using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Solution.UI.Data;
using Solution.UI.Models;
using Solution.UI.ViewModel;

namespace Solution.UI.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ILogger<ProductoController> _logger;

        private readonly ApplicationDbContext Context;

        private readonly IWebHostEnvironment WebHostEnvironment;

        //private readonly UserManager<AspNetUser> _userManager;

        //public YourControllerNameController(UserManager<ApplicationUser> userManager)
        //{
        //    _userManager = userManager;
        //}

        string baseURL = "http://localhost:51780/";

        public ProductoController(ILogger<ProductoController> logger, ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            Context = context;
            WebHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            //var items = Context.Productos.ToList();
            //return View(items);

            List<Producto> aux = new List<Models.Producto>();
            using (var cl = new HttpClient())
            {
                cl.BaseAddress = new Uri(baseURL);
                cl.DefaultRequestHeaders.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await cl.GetAsync("api/Producto");
                if (res.IsSuccessStatusCode)
                {
                    var auxR = res.Content.ReadAsStringAsync().Result;
                    aux = JsonConvert.DeserializeObject<List<Models.Producto>>(auxR);
                }
            }
            return View(aux);
        }

        [HttpGet]
        public async Task<IActionResult> IndexCliente(string TipoProducto)
        {
            if (User.Identity.IsAuthenticated.Equals(true))
            {
                var items = Context.Productos.ToList();
                ViewBag.TipoProducto = TipoProducto;
                return View("Index", items);
            }
            else
            {
                return View("./Identity/Account/Login");
            }
        }

        public IActionResult Create()
        {
            ViewBag.Lista = Context.TipoProducto.ToList();
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombreProducto,TipoProducto,Precio,Cantidad,ProfileImage")] ProductoViewModel vm, string listTipoProducto)
        {
            //string stringFileName = UploadFile(vm);
            //var producto = new Producto
            //{
            //    NombreProducto = vm.NombreProducto,
            //    TipoProducto = listTipoProducto,
            //    Precio = vm.Precio,
            //    Cantidad = vm.Cantidad,
            //    ProfileImage = stringFileName
            //};

            //Context.Productos.Add(producto);
            //Context.SaveChanges();

            //return RedirectToAction("Index");

            if (ModelState.IsValid)
            {
                if (vm.Cantidad > 0)
                {
                    using (var cl = new HttpClient())
                    {
                        string stringFileName = UploadFile(vm);
                        var producto = new Producto
                        {
                            NombreProducto = vm.NombreProducto,
                            TipoProducto = listTipoProducto,
                            Precio = vm.Precio,
                            Cantidad = vm.Cantidad,
                            ProfileImage = stringFileName
                        };

                        cl.BaseAddress = new Uri(baseURL);
                        var content = JsonConvert.SerializeObject(producto);
                        var buffer = System.Text.Encoding.UTF8.GetBytes(content);
                        var byteContent = new ByteArrayContent(buffer);
                        byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                        HttpResponseMessage res = await cl.PostAsync("api/Producto", byteContent);
                        if (res.IsSuccessStatusCode)
                        {
                            return RedirectToAction(nameof(Index));
                        }
                    }
                }
                else
                {
                    ViewBag.Lista = Context.TipoProducto.ToList();
                    TempData["errorMensaje"] = "La cantidad de unidades ingresadas debe ser mayor que 0.";
                    return View(vm);
                }
            }
            ModelState.AddModelError(string.Empty, "Server Error, Please contact administrator");
            return View(vm);
        }

        private string UploadFile(ProductoViewModel vm)
        {
            string fileName = null;
            if (vm.ProfileImage != null)
            {
                string uploadDir = Path.Combine(WebHostEnvironment.WebRootPath, "Images");
                fileName = Guid.NewGuid().ToString() + "-" + vm.ProfileImage.FileName;
                string filePath = Path.Combine(uploadDir, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    vm.ProfileImage.CopyTo(fileStream);
                }
            }
            return fileName;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Delete(int? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var producto = await Context.Productos
            //    .FirstOrDefaultAsync(p => p.Id == id);
            //if (producto == null)
            //{
            //    return NotFound();
            //}

            if (id == null)
            {
                return NotFound();
            }

            var producto = await GetProducto(id);
            if (producto == null)
            {
                return NotFound();
            }

            //return View(dragonball);

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Images", producto.ProfileImage);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            return View(producto);
        }

        // POST: PaisWEF/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //var producto = await Context.Productos.FindAsync(id);
            //Context.Productos.Remove(producto);
            //await Context.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));

            using (var cl = new HttpClient())
            {
                cl.BaseAddress = new Uri(baseURL);
                cl.DefaultRequestHeaders.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await cl.DeleteAsync("api/Producto/" + id);
                if (res.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Lista = Context.TipoProducto.ToList();

            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var producto = await Context.Productos.FindAsync(id);

            //if (producto == null)
            //{
            //    return NotFound();
            //}

            if (id == null)
            {
                return NotFound();
            }

            var producto = await GetProducto(id);
            if (producto == null)
            {
                return NotFound();
            }

            var productoVM = new ProductoViewModel();

            productoVM.Id = producto.Id;

            productoVM.Id = Context.Productos.FindAsync(id).Result.Id;
            productoVM.NombreProducto = Context.Productos.FindAsync(id).Result.NombreProducto;
            productoVM.TipoProducto = Context.Productos.FindAsync(id).Result.TipoProducto;
            productoVM.Precio = Context.Productos.FindAsync(id).Result.Precio;
            productoVM.Cantidad = Context.Productos.FindAsync(id).Result.Cantidad;

            return View(productoVM);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombreProducto,TipoProducto,Precio,Cantidad,ProfileImage")] ProductoViewModel vm, string listTipoProducto)
        {
            if (vm.Cantidad > 0)
            {
                string stringFileName = UploadFile(vm);
                var producto = new Producto
                {
                    Id = vm.Id,
                    NombreProducto = vm.NombreProducto,
                    TipoProducto = listTipoProducto,
                    Precio = vm.Precio,
                    Cantidad = vm.Cantidad,
                    ProfileImage = stringFileName
                };

                //if (id != vm.Id)
                //{
                //    return NotFound();
                //}

                //if (ModelState.IsValid)
                //{
                //    try
                //    {
                //        Context.Update(producto);
                //        Context.SaveChanges();
                //    }
                //    catch (DbUpdateConcurrencyException)
                //    {
                //        if (!ProductoExists(producto.Id))
                //        {
                //            return NotFound();
                //        }
                //        else
                //        {

                //            throw;
                //        }
                //    }
                //    return RedirectToAction(nameof(Index));
                //}
                //return View(producto);

                if (id != producto.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        using (var cl = new HttpClient())
                        {
                            cl.BaseAddress = new Uri(baseURL);
                            var content = JsonConvert.SerializeObject(producto);
                            var buffer = System.Text.Encoding.UTF8.GetBytes(content);
                            var byteContent = new ByteArrayContent(buffer);
                            byteContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                            HttpResponseMessage res = await cl.PutAsync("api/Producto/" + id, byteContent);
                            if (res.IsSuccessStatusCode)
                            {
                                return RedirectToAction(nameof(Index));
                            }
                        }
                    }
                    catch (Exception ee)
                    {
                        var temp = await GetProducto(id);
                        if (temp == null)
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(producto);
            }
            else
            {
                ViewBag.Lista = Context.TipoProducto.ToList();
                TempData["errorMensaje"] = "La cantidad de unidades ingresadas debe ser mayor que 0.";
                return View(vm);
            }
        }

        public async Task<IActionResult> Details(int? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var producto = await Context.Productos.FindAsync(id);

            //if (producto == null)
            //{
            //    return NotFound();
            //}

            if (id == null)
            {
                return NotFound();
            }

            var producto = await GetProducto(id);
            if (producto == null)
            {
                return NotFound();
            }

            var productoVM = new ProductoViewModel();

            productoVM.Id = producto.Id;

            productoVM.Id = Context.Productos.FindAsync(id).Result.Id;
            productoVM.NombreProducto = Context.Productos.FindAsync(id).Result.NombreProducto;
            productoVM.TipoProducto = Context.Productos.FindAsync(id).Result.TipoProducto;
            productoVM.Precio = Context.Productos.FindAsync(id).Result.Precio;
            productoVM.Cantidad = Context.Productos.FindAsync(id).Result.Cantidad;

            return View(productoVM);
        }
        
        // POST: PaisWEF/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details([Bind("Id,NombreProducto,TipoProducto,Precio,Cantidad,ProfileImage")] ProductoViewModel vm, int id, int txtCantidad)
        {
            //var Producto = await Context.Productos.FindAsync(id);
            if (txtCantidad > 0)
            {
                var Producto = await GetProducto(id);
                int unidades = Producto.Cantidad;
                int resta = txtCantidad;

                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (unidades - resta > 0)
                {
                    Producto.Cantidad = unidades - resta;

                    Context.Productos.Update(Producto);
                    Context.SaveChanges();

                    var carrito = new Carrito
                    {
                        IdUsuario = userId,
                        IdProducto = vm.Id,
                        NombreProductoC = vm.NombreProducto,
                        TipoProductoC = vm.TipoProducto,
                        PrecioC = vm.Precio,
                        CantidadC = resta,
                        TotalC = vm.Precio * resta
                    };

                    Context.Carrito.Add(carrito);
                    Context.SaveChanges();
                }
                else
                {
                    TempData["errorMensaje"] = "La cantidad de unidades ingresadas excedes las unidades disponibles.";
                    return RedirectToAction("Details");
                }

                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["errorMensaje"] = "La cantidad de unidades ingresadas debe ser mayor que 0.";
                return RedirectToAction("Details");
            }
        }
        
        private bool ProductoExists(int id)
        {
            return Context.Productos.Any(e => e.Id == id);
        }

        private async Task<Producto> GetProducto(int? id)
        {
            Producto aux = new Producto();
            using (var cl = new HttpClient())
            {
                cl.BaseAddress = new Uri(baseURL);
                cl.DefaultRequestHeaders.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await cl.GetAsync("api/Producto/" + id);
                if (res.IsSuccessStatusCode)
                {
                    var auxR = res.Content.ReadAsStringAsync().Result;
                    aux = JsonConvert.DeserializeObject<Models.Producto>(auxR);
                }
            }
            return aux;
        }
    }
}
