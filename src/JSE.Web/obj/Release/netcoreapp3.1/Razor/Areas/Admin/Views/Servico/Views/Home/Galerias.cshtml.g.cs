#pragma checksum "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Servico\Views\Home\Galerias.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83128b78505abe419ebd8d5ef73dc92d4877696f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Servico_Views_Home_Galerias), @"mvc.1.0.view", @"/Areas/Admin/Views/Servico/Views/Home/Galerias.cshtml")]
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
#line 3 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Servico\Views\_ViewImports.cshtml"
using JSE.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Servico\Views\_ViewImports.cshtml"
using JSE.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Servico\Views\Home\Galerias.cshtml"
using JSE.Web.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83128b78505abe419ebd8d5ef73dc92d4877696f", @"/Areas/Admin/Views/Servico/Views/Home/Galerias.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7d2d58c1713f4e4e42d94562edccc4bc5ca2ec1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"342cbc31f0b5e2caedfc8fa06048e851c89205de", @"/Areas/Admin/Views/Servico/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Servico_Views_Home_Galerias : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JSE.Web.Models.Galeria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top img-fluid img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("imgGaleria"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Servico\Views\Home\Galerias.cshtml"
  
    ViewData["Title"] = "Galeria de resultados";

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
                <h2>Galeria de resultados</h2>
                <h4></h4>
            </div>

");
#nullable restore
#line 18 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Servico\Views\Home\Galerias.cshtml"
             foreach (var row in Model.ToArray().Split(4))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card-group\">\r\n");
#nullable restore
#line 21 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Servico\Views\Home\Galerias.cshtml"
             foreach (var galeria in row)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "83128b78505abe419ebd8d5ef73dc92d4877696f5935", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 732, "~/images/uploads/Galeria/", 732, 25, true);
#nullable restore
#line 24 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Servico\Views\Home\Galerias.cshtml"
AddHtmlAttributeValue("", 757, galeria.NomeArquivo, 757, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 24 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Servico\Views\Home\Galerias.cshtml"
AddHtmlAttributeValue("", 784, galeria.NomeServico, 784, 20, false);

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
            WriteLiteral("\r\n                <div class=\"card-body\">\r\n                    <h3 class=\"card-title\">");
#nullable restore
#line 26 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Servico\Views\Home\Galerias.cshtml"
                                      Write(galeria.NomeServico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n                <div class=\"card-footer text-muted d-flex justify-content-between bg-transparent border-top-0\">\r\n                    <a href=\"#\" class=\"btn btn-primary\"\r\n                       data-action=\"");
#nullable restore
#line 30 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Servico\Views\Home\Galerias.cshtml"
                               Write(galeria.NomeServico);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                       data-toggle=\"modal\"\r\n                       data-target=\"#leiameModal\"\r\n                       data-body-message=\"../images/uploads/Galeria/");
#nullable restore
#line 33 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Servico\Views\Home\Galerias.cshtml"
                                                               Write(galeria.NomeArquivo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" onclick=\"btnAmpliar(this)\"><i class=\"fa fa-search-plus\"></i> Ampliar</a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 36 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Servico\Views\Home\Galerias.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 39 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Servico\Views\Home\Galerias.cshtml"
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
                <div class=""modal-body"">
                    <button type=""button"" class=""fancybox-close"" data-dismiss=""modal"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                    <img id=""imgModal""");
            BeginWriteAttribute("src", " src=\"", 2055, "\"", 2061, 0);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2062, "\"", 2068, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%\">\r\n");
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>

</div>
<div>
    <footer class=""footer_wrapper"">
        <div class=""container"">
            <div class=""footer_bottom""><span>Todos os Direitos © reservados - Jay Soares Estética de Resultado - <a href=""https://www.linkedin.com/in/bmendesgonca/"" target=""_blank"" title=""Linkedin"">Desenvolvido por Bruno M. Gonçalves</a> </span> </div>
        </div>
    </footer>
</div>

<script>
    function btnAmpliar(componente) {
        var imagem = componente.getAttribute(""data-body-message"");
        var imagemModal = document.getElementById(""imgModal"");
        imagemModal.src = """";
        imagemModal.src = imagem;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JSE.Web.Models.Galeria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
