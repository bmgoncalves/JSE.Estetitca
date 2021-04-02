#pragma checksum "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4270c7e3fe67f569f3d1b9805385bc6f48801bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\_ViewImports.cshtml"
using JSE.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\_ViewImports.cshtml"
using JSE.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\_ViewImports.cshtml"
using cloudscribe.Pagination.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4270c7e3fe67f569f3d1b9805385bc6f48801bd", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26a86ccdd58d5bee8e664f608fd174d4235d588a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contato", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOrEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Depoimento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Pagina Inicial";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
        <h1 class=""h3 mb-0 text-gray-800"">Pagina Inicial</h1>
        <hr />
    </div>

    <div class=""content-wrapper"">
        <div class=""row"">
            <div class=""col-xl-3 col-lg-3 col-md-3 col-sm-6 mb-4"">
                <div class=""card card-statistics"">
                    <div class=""card-body"">
                        <div class=""clearfix"">
                            <div class=""float-left"">
                                <h4 class=""text-danger"">
                                    <i class=""fa fa-bar-chart-o highlight-icon"" style=""font-size:40px"" aria-hidden=""true""></i>
                                </h4>
                            </div>
                            <div class=""float-right"">
                                <p class=""card-text text-dark"">Visitas diárias</p>
                                <h4 class=""bold-text"">600</h4>
                            </div>
                ");
            WriteLiteral(@"        </div>
                        <p class=""text-muted"">
                            <i class=""fa fa-repeat mr-1"" aria-hidden=""true""></i> Ultima atualização: 06/06/2020
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-xl-3 col-lg-3 col-md-3 col-sm-6 mb-4"">
                <div class=""card card-statistics"">
                    <div class=""card-body"">
                        <div class=""clearfix"">
                            <div class=""float-left"">
                                <h4 class=""text-warning"">
                                    <i class=""fa fa-youtube highlight-icon"" style=""color:#c4302b;font-size:40px"" aria-hidden=""true""></i>
                                </h4>
                            </div>
                            <div class=""float-right"">
                                <p class=""card-text text-dark""><i class=""fa fa-users mr-1"" aria-hidden=""true""></i>Seguidores</p>
                     ");
            WriteLiteral(@"           <h4 class=""bold-text"">500</h4>
                            </div>
                        </div>
                        <p class=""text-muted"">
                            <i class=""fa fa-repeat mr-1"" aria-hidden=""true""></i> Ultima atualização: 06/06/2020
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-xl-3 col-lg-3 col-md-3 col-sm-6 mb-4"">
                <div class=""card card-statistics"">
                    <div class=""card-body"">
                        <div class=""clearfix"">
                            <div class=""float-left"">
                                <h4 class=""text-success"">
                                    <i class=""fa fa-facebook-official highlight-icon"" style=""color:#3b5998; font-size:40px"" aria-hidden=""true""></i>
                                </h4>
                            </div>
                            <div class=""float-right"">
                                <p class=""car");
            WriteLiteral(@"d-text text-dark""><i class=""fa fa-users mr-1"" aria-hidden=""true""></i>Seguidores</p>
                                <h4 class=""bold-text"">1.000</h4>
                            </div>
                        </div>
                        <p class=""text-muted"">
                            <i class=""fa fa-repeat mr-1"" aria-hidden=""true""></i> Ultima atualização: 06/06/2020
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-xl-3 col-lg-3 col-md-3 col-sm-6 mb-4"">
                <div class=""card card-statistics"">
                    <div class=""card-body"">
                        <div class=""clearfix"">
                            <div class=""float-left"">
                                <h4 class=""text-primary"">
                                    <i class=""fa fa-instagram highlight-icon"" style=""font-size:40px"" aria-hidden=""true""></i>
                                </h4>
                            </div>
               ");
            WriteLiteral(@"             <div class=""float-right"">
                                <p class=""card-text text-dark""><i class=""fa fa-users mr-1"" aria-hidden=""true""></i>Seguidores</p>
                                <h4 class=""bold-text"">1.000</h4>
                            </div>
                        </div>
                        <p class=""text-muted"">
                            <i class=""fa fa-repeat mr-1"" aria-hidden=""true""></i> Ultima atualização: 06/06/2020
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""justify-content-between"">
        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
                    <h5 class=""mb-0 text-gray-800"">Contatos Pendentes</h5>
                </div>

                <div>
");
#nullable restore
#line 105 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
                     if (ViewBag.Contatos != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""table-responsive"">
                            <table class=""table table-striped table-bordered table-hover"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">Cliente</th>
                                        <th scope=""col"">Mensagem</th>
                                        <th scope=""col"">E-mail</th>
                                        <th scope=""col"">Telefone</th>
                                        <th scope=""col"">Data/Hora</th>
                                    </tr>
                                </thead>
                                <tbody>


");
#nullable restore
#line 121 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
                                     foreach (var contato in ViewBag.Contatos)
                                    {
                                        var mensagem = "";
                                       

                                        if (contato.Mensagem.Length > 20)
                                        {
                                            mensagem = contato.Mensagem.Substring(1, 20) + "...";
                                        }
                                        else
                                        {
                                            mensagem = contato.Mensagem;
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n\r\n                                            <th scope=\"row\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4270c7e3fe67f569f3d1b9805385bc6f48801bd12436", async() => {
#nullable restore
#line 136 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
                                                                                                                                                             Write(contato.Nome);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 136 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
                                                                                                                                  WriteLiteral(contato.ContatoId);

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
            WriteLiteral(" </th>\r\n                                            <td>");
#nullable restore
#line 137 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
                                           Write(mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 138 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
                                           Write(contato.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 139 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
                                           Write(contato.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 140 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
                                           Write(contato.DataHora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 142 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
#nullable restore
#line 146 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Nenhum contato pendente.</p>\r\n");
#nullable restore
#line 150 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>

            <div class=""col-md-6"">
                <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
                    <h5 class=""mb-0 text-gray-800"">Depoimentos Pendentes</h5>
                </div>

                <div>
");
#nullable restore
#line 161 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
                     if (ViewBag.Depoimentos != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""table-responsive"">
                            <table class=""table table-striped table-bordered table-hover"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">Cliente</th>
                                        <th scope=""col"">Depoimento</th>
                                        <th scope=""col"">Data/Hora</th>
                                    </tr>
                                </thead>
                                <tbody>


");
#nullable restore
#line 175 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
                                     foreach (var depoimento in ViewBag.Depoimentos)
                                    {
                                        var descricao = "";

                                        if (depoimento.Descricao.Length > 100)
                                            descricao = depoimento.Descricao.Substring(1, 100) + "...";
                                        else
                                            descricao = depoimento.Descricao;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <th scope=\"row\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4270c7e3fe67f569f3d1b9805385bc6f48801bd19560", async() => {
#nullable restore
#line 184 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
                                                                                                                                                            Write(depoimento.NomeCliente);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 184 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
                                                                                                                                     WriteLiteral(depoimento.Id);

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
            WriteLiteral(" </th>\r\n                                            <td>");
#nullable restore
#line 185 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
                                           Write(descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 186 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
                                           Write(depoimento.DataCriacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 188 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
#nullable restore
#line 193 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Nenhum depoimento pendente.</p>\r\n");
#nullable restore
#line 197 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\Dashboard\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
