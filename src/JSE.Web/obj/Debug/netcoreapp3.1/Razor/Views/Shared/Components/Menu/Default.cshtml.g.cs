#pragma checksum "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef8c3bc08898a1241b3fc6fab1615ca77b8a90c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/Default.cshtml")]
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
#line 1 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\_ViewImports.cshtml"
using JSE.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\_ViewImports.cshtml"
using JSE.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\_ViewImports.cshtml"
using JSE.Web.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef8c3bc08898a1241b3fc6fab1615ca77b8a90c6", @"/Views/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d4d714d6c0cffedc5cb26e52d5050fdea28e70", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Estabelecimento>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <div id=\"topbar\" class=\"d-none d-lg-flex align-items-center fixed-top\">\r\n        <div class=\"container d-flex\">\r\n\r\n            <div class=\"contact-info mr-auto\">\r\n                <i class=\"icofont-envelope\"></i> <a");
            BeginWriteAttribute("href", " href=\"", 246, "\"", 265, 1);
#nullable restore
#line 8 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 253, Model.Email, 253, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 8 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Shared\Components\Menu\Default.cshtml"
                                                                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                <i class=\"icofont-phone\"></i> ");
#nullable restore
#line 9 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Shared\Components\Menu\Default.cshtml"
                                         Write(Model.TelefoneCelular);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <i class=\"icofont-google-map\"></i> ");
#nullable restore
#line 10 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Shared\Components\Menu\Default.cshtml"
                                              Write(Model.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral("  - ");
#nullable restore
#line 10 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Shared\Components\Menu\Default.cshtml"
                                                                 Write(Model.Bairro);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 10 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Shared\Components\Menu\Default.cshtml"
                                                                                 Write(Model.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 10 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Shared\Components\Menu\Default.cshtml"
                                                                                                 Write(Model.UF);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"social-links\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 546, "\"", 571, 1);
#nullable restore
#line 13 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 553, Model.UrlFacebook, 553, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"facebook\"><i class=\"icofont-facebook\"></i></a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 646, "\"", 672, 1);
#nullable restore
#line 14 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue("", 653, Model.UrlInstagram, 653, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""instagram""><i class=""icofont-instagram""></i></a>
            </div>
        </div>
    </div>





    <header id=""header"" class=""fixed-top"">
        <div class=""container d-flex align-items-center"">
            <nav class=""nav-menu d-none d-lg-block"">
                <ul>
                    <li class=""active""><a href=""index.html"">Inicio</a></li>
                    <li><a href=""#services"">Serviços</a></li>
                    <li>
                        <a href=""#gallery"">Galeria</a>
                    </li>
                    <li><a href=""#testimonials"">Depoimentos</a></li>
                    <li><a href=""#departments"">Departments</a></li>
                    <li><a href=""#doctors"">Doctors</a></li>
");
            WriteLiteral("                    <li><a href=\"#contact\">Contato</a></li>\r\n                    <li><a href=\"#about\">Quem Somos</a></li>\r\n\r\n                </ul>\r\n            </nav><!-- .nav-menu -->\r\n\r\n");
            WriteLiteral("\r\n        </div>\r\n    </header><!-- End Header -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Estabelecimento> Html { get; private set; }
    }
}
#pragma warning restore 1591
