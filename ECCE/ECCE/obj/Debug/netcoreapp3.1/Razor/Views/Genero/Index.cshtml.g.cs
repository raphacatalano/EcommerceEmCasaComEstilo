#pragma checksum "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-vIgor\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Genero\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adc1a263139037ffedc5b34f879b4a506edf840a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Genero_Index), @"mvc.1.0.view", @"/Views/Genero/Index.cshtml")]
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
#line 1 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-vIgor\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-vIgor\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adc1a263139037ffedc5b34f879b4a506edf840a", @"/Views/Genero/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d523cb7d045fc283b7b459a0bcbbd2d4e32902", @"/Views/_ViewImports.cshtml")]
    public class Views_Genero_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tb_genero>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-vIgor\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Genero\Index.cshtml"
    ViewData["Title"] = "Genero";

    Layout = "_Layout_dashboard";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div >
    <table class=""table"">
        <tr>
            <th><h4>Generos</h4></th>
            <th></th>
            <th></th>
            <th class=""text-sm-right""><button class=""btn btn-primary"" type=""button"" onclick=""window.location.href ='/genero/cadastrogenero'"">Novo Genero</button>
            <th>
        </tr>
    </table>
");
#nullable restore
#line 19 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-vIgor\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Genero\Index.cshtml"
     if (Model.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"">

            <thead>
                <tr>
                    <th>Código</th>
                    <th>Nome</th>
                    <th></th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 32 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-vIgor\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Genero\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 35 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-vIgor\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Genero\Index.cshtml"
                       Write(item.CodigoGenero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 36 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-vIgor\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Genero\Index.cshtml"
                       Write(item.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><button type=\"button\" class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1033, "\"", 1138, 5);
            WriteAttributeValue("", 1043, "window.location.href=\'/genero/editar?CodigoGenero=", 1043, 50, true);
#nullable restore
#line 37 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-vIgor\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Genero\Index.cshtml"
WriteAttributeValue("", 1093, item.CodigoGenero, 1093, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1111, "&Descricao=", 1111, 11, true);
#nullable restore
#line 37 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-vIgor\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Genero\Index.cshtml"
WriteAttributeValue("", 1122, item.Descricao, 1122, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1137, "\'", 1137, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</button></td>\r\n                        <td><button type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1234, "\"", 1314, 3);
            WriteAttributeValue("", 1244, "window.location.href=\'/genero/excluir?CodigoGenero=", 1244, 51, true);
#nullable restore
#line 38 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-vIgor\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Genero\Index.cshtml"
WriteAttributeValue("", 1295, item.CodigoGenero, 1295, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1313, "\'", 1313, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Excluir</button></td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 41 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-vIgor\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Genero\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 44 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-vIgor\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Genero\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-primary\" role=\"alert\">\r\n            Sem Registros!\r\n        </div>\r\n");
#nullable restore
#line 50 "C:\Users\danie\Desktop\EcommerceEmCasaComEstilo-vIgor\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Genero\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tb_genero>> Html { get; private set; }
    }
}
#pragma warning restore 1591
