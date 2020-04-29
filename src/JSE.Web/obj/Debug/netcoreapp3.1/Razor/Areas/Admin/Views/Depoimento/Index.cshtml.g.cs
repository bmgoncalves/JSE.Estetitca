#pragma checksum "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Depoimento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe3fe3574d7549d60a56dce15201632b6c21b152"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Depoimento_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Depoimento/Index.cshtml")]
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
#line 1 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\_ViewImports.cshtml"
using JSE.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\_ViewImports.cshtml"
using JSE.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe3fe3574d7549d60a56dce15201632b6c21b152", @"/Areas/Admin/Views/Depoimento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8933707006942fc8515e419d9137f90813bd6f02", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Depoimento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cloudscribe.Pagination.Models.PagedResult<JSE.Web.Models.Depoimento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Areas/Admin/Views/_PaginationPartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("view", new global::Microsoft.AspNetCore.Html.HtmlString("ViewData"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Depoimento\Index.cshtml"
  
    ViewData["Title"] = "Depoimentos";
    ViewData["Controller"] = "Admin";
    ViewData["Action"] = "Depoimento";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Depoimentos Pendentes</h2>\r\n<hr />\r\n\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Depoimento\Index.cshtml"
           Write(Html.DisplayName("Cliente"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"width:600px\">\r\n                ");
#nullable restore
#line 21 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Depoimento\Index.cshtml"
           Write(Html.DisplayName("Depoimento"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th style=\"width:100px\">\r\n                ");
#nullable restore
#line 24 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Depoimento\Index.cshtml"
           Write(Html.DisplayName("Data Criação"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Depoimento\Index.cshtml"
         foreach (var item in Model.Data)
        {
            var descricao = "";

            if (item.Descricao.Length > 100)
                descricao = item.Descricao.Substring(1, 100) + "...";
            else
                descricao = item.Descricao;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Depoimento\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NomeCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Depoimento\Index.cshtml"
               Write(Html.DisplayFor(modelItem => descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Depoimento\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DataCriacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe3fe3574d7549d60a56dce15201632b6c21b1527038", async() => {
                WriteLiteral("<i class=\"fas fa-check-circle\"></i> Aprovar");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1381, "~/admin/depoimento/Aprovar/", 1381, 27, true);
#nullable restore
#line 48 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Depoimento\Index.cshtml"
AddHtmlAttributeValue("", 1408, item.Id, 1408, 8, false);

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
            WriteLiteral(" &nbsp;|&nbsp;\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe3fe3574d7549d60a56dce15201632b6c21b1528649", async() => {
                WriteLiteral("<i class=\"far fa-trash-alt\"></i> Excluir");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1510, "~/admin/depoimento/Delete/", 1510, 26, true);
#nullable restore
#line 49 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Depoimento\Index.cshtml"
AddHtmlAttributeValue("", 1536, item.Id, 1536, 8, false);

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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 52 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Depoimento\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fe3fe3574d7549d60a56dce15201632b6c21b15210510", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 56 "D:\Projetos\JSEEstetica\src\JSE.Web\Areas\Admin\Views\Depoimento\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cloudscribe.Pagination.Models.PagedResult<JSE.Web.Models.Depoimento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
