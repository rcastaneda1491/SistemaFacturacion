#pragma checksum "C:\Users\rcast\Desktop\C#\SistemaFacturacion\Views\Productos\HttpError404.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21fb696b0fe9e7f5b531bf56b672307ad5468e90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_HttpError404), @"mvc.1.0.view", @"/Views/Productos/HttpError404.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21fb696b0fe9e7f5b531bf56b672307ad5468e90", @"/Views/Productos/HttpError404.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c924262c56030d526f60bb241927fba06f72a5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_HttpError404 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\rcast\Desktop\C#\SistemaFacturacion\Views\Productos\HttpError404.cshtml"
   
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""./css/ErrorView.css"">
<div class=""site"" asp-action=""Edit"">
    <div class=""sketch"">
        <div class=""bee-sketch red""></div>
        <div class=""bee-sketch blue""></div>
    </div>

    <h1>
        Error:
        <small>No es posible eliminar el registro debido a una relación con otra tabla</small>
    </h1>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
