#pragma checksum "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4809da36d6da442cf15a2c21f0c3d6ae26732b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Inventario_Views_Inventario_ImprimirInventario), @"mvc.1.0.view", @"/Areas/Inventario/Views/Inventario/ImprimirInventario.cshtml")]
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
#line 1 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\_ViewImports.cshtml"
using InventoryWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\_ViewImports.cshtml"
using InventoryWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4809da36d6da442cf15a2c21f0c3d6ae26732b9", @"/Areas/Inventario/Views/Inventario/ImprimirInventario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a833584978aed5848ef7c15b5743eab4962dce7", @"/Areas/Inventario/Views/_ViewImports.cshtml")]
    public class Areas_Inventario_Views_Inventario_ImprimirInventario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Inventory.Models.InventarioDetalle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
  
    ViewData["Title"] = "ImprimirInventario";
    Layout = null;
    var Total = 0.00;
    var Costo = 0.00;
    var Logo = @HttpContextAccessor.HttpContext.Session.GetString("Logo");
    var Nombre = @HttpContextAccessor.HttpContext.Session.GetString("Nombre");
    var Telefono = @HttpContextAccessor.HttpContext.Session.GetString("Telefono");
    var Descripcion = @HttpContextAccessor.HttpContext.Session.GetString("Descripcion");
    var Pais = @HttpContextAccessor.HttpContext.Session.GetString("Pais");
    var Ciudad = @HttpContextAccessor.HttpContext.Session.GetString("Ciudad");

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4809da36d6da442cf15a2c21f0c3d6ae26732b95826", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c4809da36d6da442cf15a2c21f0c3d6ae26732b96088", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4809da36d6da442cf15a2c21f0c3d6ae26732b97970", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-4\">\r\n            <img");
                BeginWriteAttribute("src", " src=\"", 973, "\"", 984, 1);
#nullable restore
#line 25 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
WriteAttributeValue("", 979, Logo, 979, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded\" width=\"250\" height=\"200\" />\r\n        </div>\r\n        <div class=\"col-sm-4\">\r\n            <label class=\"col-form-label\" style=\"font-size: 20px; font-weight: bold\">");
#nullable restore
#line 28 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
                                                                                Write(Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
        </div>
    </div>
    <div class=""form-group row"">
        <div class=""col-12"">
            <label class=""col-form-label"" style=""font-weight:bold; font-size:20px;"">
                Descripcion:
            </label>
            <label class=""col-form-label""
                   style=""font-size:20px;"">");
#nullable restore
#line 37 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
                                      Write(Descripcion);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
            </div>
        </div>

        <div class=""form-group row"">
            <div class=""col-4"">
                <label class=""col-form-label"" style=""font-weight: bold; font-size:20px;"">Telefono: </label>
                <label class=""col-form-label"" style=""font-size:20px;"">");
#nullable restore
#line 44 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
                                                                 Write(Telefono);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col-4\">\r\n                <label class=\"col-form-label\" style=\"font-weight: bold; font-size:20px;\">País: </label>\r\n                <label class=\"col-form-label\" style=\"font-size:20px;\">");
#nullable restore
#line 48 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
                                                                 Write(Pais);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"col-4\">\r\n                <label class=\"col-form-label\" style=\"font-weight: bold; font-size:20px;\">Ciudad: </label>\r\n                <label class=\"col-form-label\" style=\"font-size:20px;\">");
#nullable restore
#line 52 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
                                                                 Write(Ciudad);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
            </div>
        </div>
        <div>
            <table class=""table table-striped border"" style=""height:10px;"">
                <thead class=""thead-dark"">
                    <tr class=""table-secondary thead-dark"">
                        <th style=""font-weight: bold; font-size:20px;"">
                            Categoría
                        </th>
                        <th style=""text-align:left; font-weight: bold; font-size:20px;"">
                            Nombre producto
                        </th>
                        <th style=""text-align:left; font-weight: bold; font-size:20px;"">
                            Marca
                        </th>
                        <th style=""text-align:right; font-weight: bold; font-size:20px;"">
                            Stock
                        </th>
                        <th style=""text-align:right; font-weight: bold; font-size:20px;"">
                            Precio
                        </th>
 ");
                WriteLiteral(@"                       <th style=""text-align:right; font-weight: bold; font-size:20px;"">
                            Valor inventario
                        </th>
                    </tr>
                <thead>
                <tbody style=""height:10px;"">
");
#nullable restore
#line 80 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
                     foreach (var item in Model.ToList())
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td style=\"font-size:20px;\">\r\n                                ");
#nullable restore
#line 84 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
                           Write(Html.DisplayFor(m => item.Producto.Categoria.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td style=\"font-size:20px;\">\r\n                                ");
#nullable restore
#line 87 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
                           Write(Html.DisplayFor(m => item.Producto.Descripcion));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td style=\"font-size:20px;\">\r\n                                ");
#nullable restore
#line 90 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
                           Write(Html.DisplayFor(m => item.Producto.Marca.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td style=\"text-align:right;font-size:20px;\">\r\n                                ");
#nullable restore
#line 93 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
                           Write(Html.DisplayFor(m => item.Cantidad));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n                            <td style=\"text-align:right;font-size:20px;\">\r\n                                ");
#nullable restore
#line 96 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
                           Write(Html.DisplayFor(m => item.Producto.Precio, "Currency"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </td>\r\n");
#nullable restore
#line 98 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
                              
                                var subTotal = @item.Producto.Precio * item.Cantidad;
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td style=\"text-align:right;font-size:20px;\">\r\n                                <label class=\"col-form-label\">");
#nullable restore
#line 102 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
                                                         Write(subTotal.ToString("C2"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                            </td>\r\n");
#nullable restore
#line 104 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
                              
                                Total += @item.Producto.Precio * item.Cantidad;
                                Costo += item.Producto.Costo * item.Cantidad;

                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 110 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </tbody>
            </table>
        </div>
        <br />

        <div class=""form-group row"">
            <div class=""col-12 col-md-6"" style=""font-weight: bold;font-size:20px;"">
                <label class=""col-form-label"">
                    Costo Inventario:
                </label>
                <label class=""col-form-label text-danger"">");
#nullable restore
#line 121 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
                                                      Write(String.Format("{0:C}",Costo));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
            </div>
        </div>

        <div class=""form-group row"">
            <div class=""col-12 col-md-6"" style=""font-weight: bold;font-size:20px;"">
                <label class=""col-form-label"">
                    Precio Inventario:
                </label>
                <label class=""col-form-label text-danger"">");
#nullable restore
#line 130 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
                                                      Write(String.Format("{0:C}",Total));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
            </div>
        </div>

        <div class=""form-group row"">
            <div class=""col-12 col-md-6"" style=""font-weight: bold;font-size:20px;"">
                <label class=""col-form-label"">
                    Ganancia sobre inventario:
                </label>
                <label class=""col-form-label text-danger"">");
#nullable restore
#line 139 "D:\UNA\Segundo Ciclo 2022\Programacion III\Proyecto Final Tienda\WebTienda\WebTienda\Areas\Inventario\Views\Inventario\ImprimirInventario.cshtml"
                                                      Write(String.Format("{0:C}",Total-Costo));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Inventory.Models.InventarioDetalle>> Html { get; private set; }
    }
}
#pragma warning restore 1591
