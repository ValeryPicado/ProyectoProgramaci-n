using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solution.UI.Data;
using Solution.UI.Models;

namespace Solution.UI.Controllers
{
    public class FacturaController : Controller
    {
        private readonly ILogger<FacturaController> _logger;

        private readonly ApplicationDbContext Context;

        private readonly IWebHostEnvironment WebHostEnvironment;

        public FacturaController(ILogger<FacturaController> logger, ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _logger = (ILogger<FacturaController>)logger;
            Context = context;
            WebHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var items = Context.Factura.ToList();
            return View(items);
        }

        public async Task<IActionResult> AgregarFactura(int? id)
        {
            var items = Context.Carrito.ToList();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            string codigo = finalString;
            bool existe = false;

            foreach (var item in items)
            {
                if (userId.Equals(item.IdUsuario))
                {
                    existe = true;
                    var factura = new Factura();

                    factura.CodigoFactura = codigo;
                    factura.Fecha = DateTime.Now;
                    factura.IdProducto = item.IdProducto;
                    factura.IdUsuario = userId;
                    factura.NombreProductoF = item.NombreProductoC;
                    factura.TipoProductoF = item.TipoProductoC;
                    factura.PrecioF = item.PrecioC;
                    factura.CantidadF = item.CantidadC;
                    factura.TotalF = item.TotalC;

                    Context.Factura.Add(factura);
                    Context.SaveChanges();
                }
            }

            if (existe == true)
            {
                EnviarCorreo(codigo);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["errorMensaje"] = "No hay productos insertados en el carrito.";
                return RedirectToAction("Index", "Carrito");
            }
        }

        [HttpPost]
        public IActionResult EnviarCorreo(string codigoFactura)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

                    var items = Context.Factura.ToList();
                    var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    var correo = User.FindFirstValue(ClaimTypes.Name);

                    mmsg.To.Add(correo);
                    string asunto = "Factura";

                    string mensaje =

                                                "<h1 text-align: center;><b> Factura </b></h1>" +
                    "<br />" +
                    "<br /> Este es un correo automatizado de la aplicación Mercadito, usted ha realizado la siguiente compra: " +
                    "<br />" +
                    "<br /> ********************************************************************************************** " +

                    "<table>" +
                        "<thead>" +
                            "<tr>" +
                                "<th>" +
                                    "Producto" + 
                                "</th>" +
                                "<th>" +
                                    "Precio" + 
                                "</th>" +
                                "<th>" +
                                    "Cantidad" + 
                                "</th>" +
                                "<th>" +
                                    "Total" + 
                                "</th>" +
                            "</tr>" +
                        "</thead> ";

                    foreach (var item in items)
                        {
                            if (userId.Equals(item.IdUsuario) && codigoFactura.Equals(item.CodigoFactura))
                            {
                                var factura = new Factura();

                                factura.CodigoFactura = item.CodigoFactura;
                                factura.Fecha = item.Fecha;
                                factura.IdProducto = item.IdProducto;
                                factura.IdUsuario = item.IdUsuario;
                                factura.NombreProductoF = item.NombreProductoF;
                                factura.TipoProductoF = item.TipoProductoF;
                                factura.PrecioF = item.PrecioF;
                                factura.CantidadF = item.CantidadF;
                                factura.TotalF = item.TotalF;

                                mensaje +=
                                    "<br />" +
                                    "<tbody>" +
                                        "<tr>" +
                                            "<td>" +
                                                factura.NombreProductoF +
                                            "</td>" +
                                            "<td>" +
                                                factura.PrecioF + 
                                            "</td>" +
                                            "<td>" +
                                                factura.CantidadF + 
                                            "</td>" +
                                            "<td>" +
                                                factura.TotalF + 
                                            "</td>" +
                                        "</tr>";
                            }
                        }
                    var carrito = Context.Carrito.ToList();
                    decimal indexCarrito = 0;

                    foreach (var item in carrito)
                    {
                        if (userId.Equals(item.IdUsuario))
                        {
                            indexCarrito += item.TotalC;
                        }
                    }
                    string TotalCompra = indexCarrito.ToString();

                    mensaje +=
                            "<tr>" +
                                "<td>" +
                                "</td>" +
                                "<td>" +
                                "</td>" +
                                "<td>" +
                                    "Total: " +
                                "</td>" +
                                "<td>" +
                                    "₡" + TotalCompra +
                                "</td>" +
                            "</tr>" +
                            "</tbody>" +
                            "</table>" +
                    "<br /> ********************************************************************************************** ";

                    mmsg.Subject = asunto;
                    mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

                    mmsg.Body = mensaje;
                    mmsg.BodyEncoding = System.Text.Encoding.UTF8;
                    mmsg.IsBodyHtml = true;
                    mmsg.From = new MailAddress("sistemaASEcorreo@gmail.com"); //En "correo" se tiene que escribir el correo que va a usar el sistema para enviar correos

                    SmtpClient cliente = new SmtpClient();

                    cliente.Credentials = new NetworkCredential("sistemaASEcorreo@gmail.com", "sisASE-123"); //En "correo" se escribe de nuevo el correo que va a usar el sistema y en contraseña va la contraseña del correo
                                                                                                                //OJO: cuidado ponen su correo y contraseña aqui y mandan una version del proyecto por accidente con eso
                    cliente.Port = 587;
                    cliente.EnableSsl = true;
                    cliente.Host = "smtp.gmail.com"; //esta dirección de hosteo va a cambiar dependiendo del proveedor de correo electronico que se use en el correo del sistema, en esta caso, esa es la dirección de hosteo de gmail

                    try
                    {
                        cliente.Send(mmsg);
                    }
                    catch (Exception ex)
                    {
                        TempData["errorMensaje"] = "Se ha producido un error al intentar enviar el correo, revise que los datos insertados correspondan a lo que se pide en los campos.";
                    }

                    VaciarCarrito();

                    TempData["exitoMensaje"] = "El pedido ha sido enviado por correo exitosamente.";
                    return RedirectToAction("EnviarCorreo");
                }
                else
                {
                    return View("Crear");
                }
            }
            catch
            {
                TempData["errorMensaje"] = "Inserte correctamente el formato de los datos.";
                return View();
            }
        }

        public async Task<IActionResult> VaciarCarrito()
        {
            var items = Context.Carrito.ToList();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            foreach (var item in items)
            {
                if (userId.Equals(item.IdUsuario))
                {
                    var carrito = await Context.Carrito.FindAsync(item.IdCarrito);
                    Context.Carrito.Remove(carrito);
                }
            }
            await Context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
