#pragma checksum "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Home\Servicos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95803eafa8c0ca92bcf33dc05e6a28eea9891978"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Servicos), @"mvc.1.0.view", @"/Views/Home/Servicos.cshtml")]
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
#line 2 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Home\Servicos.cshtml"
using JSE.Web.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95803eafa8c0ca92bcf33dc05e6a28eea9891978", @"/Views/Home/Servicos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de36a3c09db4c0456a2fea2bd6f3ba71ed534cc2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Servicos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JSE.Web.Models.Servico>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top img-fluid img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Home\Servicos.cshtml"
  
    ViewData["Title"] = "Servicos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""text-center"">
        <!--sobreNos-->
        <section id=""sobreNos"" class=""content"">
            <div class=""container portfolio_title"">
                <div class=""section-title"">
                    <br />
                    <h2>Serviços</h2>
                    <h4></h4>
                </div>

");
#nullable restore
#line 18 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Home\Servicos.cshtml"
                 foreach (var row in Model.ToArray().Split(4))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card-group\">\r\n");
#nullable restore
#line 21 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Home\Servicos.cshtml"
                         foreach (var servico in row)
                        {
                            string descricao;

                            if (servico.Descricao.Length > 150)
                            {
                                descricao = servico.Descricao.Substring(0, 150);
                            }
                            else
                            {
                                descricao = servico.Descricao;
                            }

                            descricao += "...";


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "95803eafa8c0ca92bcf33dc05e6a28eea98919785625", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1265, "~/images/uploads/Servicos/", 1265, 26, true);
#nullable restore
#line 37 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Home\Servicos.cshtml"
AddHtmlAttributeValue("", 1291, servico.NomeArquivo, 1291, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Home\Servicos.cshtml"
AddHtmlAttributeValue("", 1318, servico.NomeServico, 1318, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"card-body\">\r\n                                    <h3 class=\"card-title\">");
#nullable restore
#line 39 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Home\Servicos.cshtml"
                                                      Write(servico.NomeServico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <p class=\"card-text\">");
#nullable restore
#line 40 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Home\Servicos.cshtml"
                                                    Write(descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                                <div class=""card-footer text-muted d-flex justify-content-between bg-transparent border-top-0"">
                                    <a href=""#"" class=""btn btn-primary""
                                       data-titulo=""");
#nullable restore
#line 44 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Home\Servicos.cshtml"
                                               Write(servico.NomeServico);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                       data-action=\"");
#nullable restore
#line 45 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Home\Servicos.cshtml"
                                               Write(servico.NomeServico);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                       data-toggle=\"modal\"\r\n                                       data-target=\"#leiameModal\"\r\n                                       data-body-message=\"");
#nullable restore
#line 48 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Home\Servicos.cshtml"
                                                     Write(servico.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" onclick=\"btnLeiaMais(this)\">Leia mais</a>                                    \r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 51 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Home\Servicos.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 54 "D:\Projetos\JSEEstetica\src\JSE.Web\Views\Home\Servicos.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>

        </section>

        <div class=""modal fade"" id=""leiameModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""leiameModalTitle"" aria-hidden=""true"">
            <div class=""modal-dialog"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h3 class=""modal-title"" id=""leiameModalTitle"" style=""font-weight:bold"">Modal title</h3>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"" style=""font-size:xx-large"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        <p id=""modalTextBody"" style=""text-align:left;font-size:large""></p>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Fechar</button>
");
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>



    </div>
<div>
    <footer class=""footer_wrapper"">
        <div class=""container"">
            <div class=""footer_bottom""><span>Todos os Direitos © reservados - Jay Soares Estética de Resultado | <a href=""https://www.linkedin.com/in/bmendesgonca/"" target=""_blank"" title=""Linkedin"">Desenvolvido por Bruno M. Gonçalves</a> </span> </div>
        </div>
    </footer>
</div>

<script>
    var items = document.querySelectorAll("".liAtv"");
    for (var i = 0; i < items.length; ++i) {
        items[i].classList.remove(""Active"");
    }

    function btnLeiaMais(componente) {
        var tituloModal = document.querySelector(""#leiameModalTitle"");
        var messageModal = document.querySelector(""#modalTextBody"");

        tituloModal.innerHTML = componente.getAttribute(""data-titulo"");
        messageModal.innerHTML = componente.getAttribute(""data-body-message"");
    }

</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JSE.Web.Models.Servico>> Html { get; private set; }
    }
}
#pragma warning restore 1591
