#pragma checksum "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\_PaginationPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0359749958a0cff8cc2db650e5bb27232278b3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views__PaginationPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/_PaginationPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0359749958a0cff8cc2db650e5bb27232278b3b", @"/Areas/Admin/Views/_PaginationPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26a86ccdd58d5bee8e664f608fd174d4235d588a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views__PaginationPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pagenumber-param", "pagenumber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::cloudscribe.Web.Pagination.PagerTagHelper __cloudscribe_Web_Pagination_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("cs-pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0359749958a0cff8cc2db650e5bb27232278b3b3957", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            __cloudscribe_Web_Pagination_PagerTagHelper = CreateTagHelper<global::cloudscribe.Web.Pagination.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__cloudscribe_Web_Pagination_PagerTagHelper);
#nullable restore
#line 1 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\_PaginationPartial.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.PageNumber = (int)Model.PageNumber;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-pagenumber", __cloudscribe_Web_Pagination_PagerTagHelper.PageNumber, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 2 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\_PaginationPartial.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.TotalItems = (int)Model.TotalItems;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-totalitems", __cloudscribe_Web_Pagination_PagerTagHelper.TotalItems, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 3 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\_PaginationPartial.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.PageSize = Model.PageSize;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-pagesize", __cloudscribe_Web_Pagination_PagerTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __cloudscribe_Web_Pagination_PagerTagHelper.PageNumberParam = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 5 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\_PaginationPartial.cshtml"
             WriteLiteral(ViewData["Controller"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __cloudscribe_Web_Pagination_PagerTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __cloudscribe_Web_Pagination_PagerTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 6 "C:\Projetos\JSE.Estetitca\src\JSE.Web\Areas\Admin\Views\_PaginationPartial.cshtml"
         WriteLiteral(ViewData["Action"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __cloudscribe_Web_Pagination_PagerTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __cloudscribe_Web_Pagination_PagerTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
