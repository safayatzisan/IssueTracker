#pragma checksum "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\ProjectWiseStatus\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4456b7eb716e2462a8e21fe3794767a11dc5e2f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProjectWiseStatus_Index), @"mvc.1.0.view", @"/Views/ProjectWiseStatus/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProjectWiseStatus/Index.cshtml", typeof(AspNetCore.Views_ProjectWiseStatus_Index))]
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
#line 1 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\_ViewImports.cshtml"
using IssueTracker;

#line default
#line hidden
#line 2 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\_ViewImports.cshtml"
using IssueTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4456b7eb716e2462a8e21fe3794767a11dc5e2f4", @"/Views/ProjectWiseStatus/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ba94f1c87410a469752601943342041e8c9d15b", @"/Views/_ViewImports.cshtml")]
    public class Views_ProjectWiseStatus_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IssueTracker.Models.ProjectWiseStatusIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left: -20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ProjectWiseStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\ProjectWiseStatus\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(146, 63, true);
            WriteLiteral("\r\n<h2 class=\"text-center\">Project Wise Status</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(209, 179, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "964fb4403425453d841aded4f7d5d5e7", async() => {
                BeginContext(319, 65, true);
                WriteLiteral("<i class=\"fa fa-plus-square-o\" aria-hidden=\"true\"></i> Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(388, 509, true);
            WriteLiteral(@"
</p>
<table id=""dtDesignation"" class=""ui celled table"" style=""margin-left: 5px;"">
    <thead>
        <tr>
            <th>Company</th>
            <th>Project</th>
            <th>Last Status Date</th>
            <th>Status By</th>
            <th>Contact Person</th>
            <th>Contract End Date</th>
            <th>Remarks</th>
            <th>Relation With Client</th>
            <th>Last Visit Date</th>
            <th>Project Type</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 29 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\ProjectWiseStatus\Index.cshtml"
         foreach (var item in Model.ProjectWiseStatusList) {

#line default
#line hidden
            BeginContext(959, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(990, 16, false);
#line 31 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\ProjectWiseStatus\Index.cshtml"
           Write(item.CompanyName);

#line default
#line hidden
            EndContext();
            BeginContext(1006, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1030, 16, false);
#line 32 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\ProjectWiseStatus\Index.cshtml"
           Write(item.ProjectName);

#line default
#line hidden
            EndContext();
            BeginContext(1046, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1070, 19, false);
#line 33 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\ProjectWiseStatus\Index.cshtml"
           Write(item.LastStatusDate);

#line default
#line hidden
            EndContext();
            BeginContext(1089, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1113, 13, false);
#line 34 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\ProjectWiseStatus\Index.cshtml"
           Write(item.StatusBy);

#line default
#line hidden
            EndContext();
            BeginContext(1126, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1150, 29, false);
#line 35 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\ProjectWiseStatus\Index.cshtml"
           Write(item.ProjectContactPersonName);

#line default
#line hidden
            EndContext();
            BeginContext(1179, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1203, 20, false);
#line 36 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\ProjectWiseStatus\Index.cshtml"
           Write(item.ContractEndDate);

#line default
#line hidden
            EndContext();
            BeginContext(1223, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1247, 12, false);
#line 37 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\ProjectWiseStatus\Index.cshtml"
           Write(item.Remarks);

#line default
#line hidden
            EndContext();
            BeginContext(1259, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1283, 23, false);
#line 38 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\ProjectWiseStatus\Index.cshtml"
           Write(item.RelationWithClient);

#line default
#line hidden
            EndContext();
            BeginContext(1306, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1330, 18, false);
#line 39 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\ProjectWiseStatus\Index.cshtml"
           Write(item.LastVisitDate);

#line default
#line hidden
            EndContext();
            BeginContext(1348, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1372, 27, false);
#line 40 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\ProjectWiseStatus\Index.cshtml"
           Write(item.ProjectType.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1399, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 42 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\ProjectWiseStatus\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1424, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IssueTracker.Models.ProjectWiseStatusIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
