#pragma checksum "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c22f78990303eaefee9f27e8568603d8aaa772b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrito_Index), @"mvc.1.0.view", @"/Views/Carrito/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22f78990303eaefee9f27e8568603d8aaa772b9", @"/Views/Carrito/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a551a45034672aaae37cec1b4ca411d1831cdd50", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrito_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Solution.UI.Models.Carrito>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Factura", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AgregarFactura", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Finalizar compra"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Carrito</h1>\r\n\r\n<div style=\"text-align:center;color:red\">\r\n    ");
#nullable restore
#line 10 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
Write(TempData["errorMensaje"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div style=\"text-align:center;color:green\">\r\n    ");
#nullable restore
#line 14 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
Write(TempData["exitoMensaje"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<table id=\"Datos\" class=\"table table-bordered table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdCarrito));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NombreProductoC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TipoProductoC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PrecioC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CantidadC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 45 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
#nullable restore
#line 48 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
                 if (ViewBag.IdUsuario.Equals(item.IdUsuario))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 51 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IdCarrito));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 54 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IdProducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 57 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NombreProductoC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 60 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TipoProductoC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 63 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PrecioC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 66 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CantidadC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 69 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TotalC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c22f78990303eaefee9f27e8568603d8aaa772b912909", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
                                                 WriteLiteral(item.IdCarrito);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 74 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 76 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<table>
    <tbody>
        <tr>
            <td>
                <label> </label>
            </td>
            <td>
                <label> </label>
            </td>
            <td>
                <label> </label>
            </td>
            <td>
                <label> </label>
            </td>
            <td>
                <label> </label>
            </td>
            <td>
                <label class=""control-label"">
                    <b>
                        Total:
                    </b>
                </label>

            <td>
                <label class=""control-label"">
                    <b>
                        ₡ ");
#nullable restore
#line 134 "C:\Users\Usuario\Desktop\Mercadito\ProyectoFinalPrograVentas\Solution.UI\Views\Carrito\Index.cshtml"
                     Write(ViewBag.TotalCompra);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </b>\r\n                </label>\r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c22f78990303eaefee9f27e8568603d8aaa772b916707", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c22f78990303eaefee9f27e8568603d8aaa772b917008", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Solution.UI.Models.Carrito>> Html { get; private set; }
    }
}
#pragma warning restore 1591
