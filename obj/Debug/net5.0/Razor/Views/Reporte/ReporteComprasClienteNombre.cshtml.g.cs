#pragma checksum "C:\Users\rcast\Desktop\C#\SistemaFacturacion\Views\Reporte\ReporteComprasClienteNombre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd8ad17ee96149dbbee3a62e7f4ad1a5e3c156ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reporte_ReporteComprasClienteNombre), @"mvc.1.0.view", @"/Views/Reporte/ReporteComprasClienteNombre.cshtml")]
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
#line 1 "C:\Users\rcast\Desktop\C#\SistemaFacturacion\Views\_ViewImports.cshtml"
using SistemaFacturacion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rcast\Desktop\C#\SistemaFacturacion\Views\_ViewImports.cshtml"
using SistemaFacturacion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd8ad17ee96149dbbee3a62e7f4ad1a5e3c156ef", @"/Views/Reporte/ReporteComprasClienteNombre.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c924262c56030d526f60bb241927fba06f72a5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Reporte_ReporteComprasClienteNombre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemaFacturacion.Models.ReporteCliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cliente"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("mostrarDatos()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rcast\Desktop\C#\SistemaFacturacion\Views\Reporte\ReporteComprasClienteNombre.cshtml"
  
    ViewData["Title"] = "ReporteComprasClienteNombre";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    function mostrarDatos() {\r\n        var codigoCliente = document.getElementById(\"cliente\").value;\r\n\r\n        var url = \"");
#nullable restore
#line 12 "C:\Users\rcast\Desktop\C#\SistemaFacturacion\Views\Reporte\ReporteComprasClienteNombre.cshtml"
              Write(Url.Action("ReporteComprasClienteNombre", "Reporte", new { codigoCliente = "param-id" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
        url = url.replace(""param-id"", codigoCliente);
            $(""#result"").load(url);
            window.location.href = url;
    }
</script>

<h1>Reporte de Ventas por Cliente filtrado por Nombre</h1>

<div class=""form-group"">
    <label class=""control-label""></label>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd8ad17ee96149dbbee3a62e7f4ad1a5e3c156ef5379", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 23 "C:\Users\rcast\Desktop\C#\SistemaFacturacion\Views\Reporte\ReporteComprasClienteNombre.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.codigoCliente;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <input id=""codigo"" class=""form-control"" type=""hidden"" />
</div>

<div class=""table-responsive"">
    <table class=""table"">
        <thead class=""thead-dark"">
            <tr style=""text-align:center;"">
                <th>
                    ");
#nullable restore
#line 32 "C:\Users\rcast\Desktop\C#\SistemaFacturacion\Views\Reporte\ReporteComprasClienteNombre.cshtml"
               Write(Html.DisplayNameFor(model => model.nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 35 "C:\Users\rcast\Desktop\C#\SistemaFacturacion\Views\Reporte\ReporteComprasClienteNombre.cshtml"
               Write(Html.DisplayNameFor(model => model.apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 38 "C:\Users\rcast\Desktop\C#\SistemaFacturacion\Views\Reporte\ReporteComprasClienteNombre.cshtml"
               Write(Html.DisplayNameFor(model => model.dia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 41 "C:\Users\rcast\Desktop\C#\SistemaFacturacion\Views\Reporte\ReporteComprasClienteNombre.cshtml"
               Write(Html.DisplayNameFor(model => model.fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 44 "C:\Users\rcast\Desktop\C#\SistemaFacturacion\Views\Reporte\ReporteComprasClienteNombre.cshtml"
               Write(Html.DisplayNameFor(model => model.total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 49 "C:\Users\rcast\Desktop\C#\SistemaFacturacion\Views\Reporte\ReporteComprasClienteNombre.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\"text-align:center;\">\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\Users\rcast\Desktop\C#\SistemaFacturacion\Views\Reporte\ReporteComprasClienteNombre.cshtml"
                   Write(Html.DisplayFor(modelItem => item.nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "C:\Users\rcast\Desktop\C#\SistemaFacturacion\Views\Reporte\ReporteComprasClienteNombre.cshtml"
                   Write(Html.DisplayFor(modelItem => item.apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "C:\Users\rcast\Desktop\C#\SistemaFacturacion\Views\Reporte\ReporteComprasClienteNombre.cshtml"
                   Write(Html.DisplayFor(modelItem => item.dia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\Users\rcast\Desktop\C#\SistemaFacturacion\Views\Reporte\ReporteComprasClienteNombre.cshtml"
                   Write(Html.DisplayFor(modelItem => item.fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\Users\rcast\Desktop\C#\SistemaFacturacion\Views\Reporte\ReporteComprasClienteNombre.cshtml"
                   Write(Html.DisplayFor(modelItem => item.total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 68 "C:\Users\rcast\Desktop\C#\SistemaFacturacion\Views\Reporte\ReporteComprasClienteNombre.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SistemaFacturacion.Models.ReporteCliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
