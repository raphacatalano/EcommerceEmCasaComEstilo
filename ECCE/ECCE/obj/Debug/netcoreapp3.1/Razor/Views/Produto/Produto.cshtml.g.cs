#pragma checksum "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Produto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef278e067e94a3b096412b7138574af66377a9dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Produto), @"mvc.1.0.view", @"/Views/Produto/Produto.cshtml")]
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
#line 1 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\_ViewImports.cshtml"
using ECCE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef278e067e94a3b096412b7138574af66377a9dd", @"/Views/Produto/Produto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8d523cb7d045fc283b7b459a0bcbbd2d4e32902", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Produto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProdutoView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div>\r\n        <div>");
#nullable restore
#line 8 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Produto.cshtml"
        Write(Model.tb_produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n        <h4>Fotos</h4>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 13 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Produto.cshtml"
             foreach (var foto in Model.produtofotoModel)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Produto.cshtml"
                 if (foto.Caminho != "")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div><img");
            BeginWriteAttribute("src", " src=\"", 328, "\"", 349, 1);
#nullable restore
#line 17 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Produto.cshtml"
WriteAttributeValue("", 334, foto.Descricao, 334, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:200px;height:200px;\" /></div>\r\n");
#nullable restore
#line 18 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Produto.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Produto.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n        <h4>Cores</h4>\r\n        <hr />\r\n\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 27 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Produto.cshtml"
             foreach (var Cores in Model.produtocorModel)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>");
#nullable restore
#line 29 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Produto.cshtml"
                Write(Cores.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 30 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Produto.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <hr />\r\n        <h4>Tamanhos</h4>\r\n        <hr />\r\n\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 37 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Produto.cshtml"
             foreach (var Tamanho in Model.produtotamanhoModel)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>");
#nullable restore
#line 39 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Produto.cshtml"
                Write(Tamanho.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 40 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Produto.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <hr />\r\n        <h4>Genero</h4>\r\n        <hr />\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 46 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Produto.cshtml"
             foreach (var Genero in Model.produtogeneroModel)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>");
#nullable restore
#line 48 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Produto.cshtml"
                Write(Genero.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 49 "C:\Users\danie\Documents\GitHub\EcommerceEmCasaComEstilo\ECCE\ECCE\Views\Produto\Produto.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <hr />\r\n    </div>\r\n</div>\r\n<button class=\"btn-success\"></button>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProdutoView> Html { get; private set; }
    }
}
#pragma warning restore 1591
