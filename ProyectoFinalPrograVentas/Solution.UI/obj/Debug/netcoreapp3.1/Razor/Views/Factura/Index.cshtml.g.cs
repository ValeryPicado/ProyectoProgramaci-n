#pragma checksum "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0be79c9808f18ae671fadf3d2ef256d0f2e1efac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Factura_Index), @"mvc.1.0.view", @"/Views/Factura/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\_ViewImports.cshtml"
using Solution.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\_ViewImports.cshtml"
using Solution.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0be79c9808f18ae671fadf3d2ef256d0f2e1efac", @"/Views/Factura/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a551a45034672aaae37cec1b4ca411d1831cdd50", @"/Views/_ViewImports.cshtml")]
    public class Views_Factura_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Solution.UI.Models.Factura>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Facturas</h1>\r\n\r\n");
            WriteLiteral("<table id=\"Datos\" class=\"table table-bordered table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdFactura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CodigoFactura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NombreProductoF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TipoProductoF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrecioF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CantidadF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 49 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdFactura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CodigoFactura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.IdUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NombreProductoF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TipoProductoF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PrecioF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CantidadF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 80 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 88 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Factura\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#Datos').DataTable({
                'paging': true,
                'lengthChange': false,
                'searching': false,
                'ordering': true,
                'info': true,
                'autoWidth': false
            })
        })
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Solution.UI.Models.Factura>> Html { get; private set; }
    }
}
#pragma warning restore 1591
