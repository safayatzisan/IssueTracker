#pragma checksum "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\InvolvedPerson\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cb998105b7be00cbf6a2089b7ffc045cbe3136b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InvolvedPerson_Index), @"mvc.1.0.view", @"/Views/InvolvedPerson/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/InvolvedPerson/Index.cshtml", typeof(AspNetCore.Views_InvolvedPerson_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cb998105b7be00cbf6a2089b7ffc045cbe3136b", @"/Views/InvolvedPerson/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ba94f1c87410a469752601943342041e8c9d15b", @"/Views/_ViewImports.cshtml")]
    public class Views_InvolvedPerson_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IssueTracker.Models.IssueLogInvolvedPersonListingModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(76, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\InvolvedPerson\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 7 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\InvolvedPerson\Index.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(188, 68, true);
            WriteLiteral("    <h2 class=\"text-center\">Assigned Tasks</h2>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(256, 186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8800b0714d145e58c6290cafe101362", async() => {
                BeginContext(320, 115, true);
                WriteLiteral("\r\n            <input style=\"margin-bottom:18px\" type=\"text\" class=\"homeSearch\" placeholder=\"Search...\" />\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(442, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(458, 72, true);
            WriteLiteral("    <!-- Modal placeholder -->\r\n    <div id=\"modal-placeholder\"></div>\r\n");
            EndContext();
            BeginContext(532, 56, true);
            WriteLiteral("    <table class=\"table table-hover\">\r\n        <tbody>\r\n");
            EndContext();
#line 21 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\InvolvedPerson\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(645, 150, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <div class=\"col-md-1\">\r\n                            <div class=\"raisedByImage\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 795, "\"", 859, 3);
            WriteAttributeValue("", 803, "background-image:url(../uploads/", 803, 32, true);
#line 26 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\InvolvedPerson\Index.cshtml"
WriteAttributeValue("", 835, item.RaisedByImageUrl, 835, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 857, ");", 857, 2, true);
            EndWriteAttribute();
            BeginContext(860, 307, true);
            WriteLiteral(@"></div>
                        </div>
                        <div class=""col-md-11"">
                            <div class=""issueTitle"">
                                <span>
                                    <a style=""cursor:pointer"" data-toggle=""ajax-modal"" data-target=""#view-issue"" data-url=""");
            EndContext();
            BeginContext(1168, 57, false);
#line 31 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\InvolvedPerson\Index.cshtml"
                                                                                                                      Write(Url.Action("View","InvolvedPerson", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1225, 44, true);
            WriteLiteral("\">\r\n                                        ");
            EndContext();
            BeginContext(1270, 10, false);
#line 32 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\InvolvedPerson\Index.cshtml"
                                   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1280, 163, true);
            WriteLiteral("\r\n                                    </a>\r\n                                </span>\r\n                                <span>\r\n                                    - ");
            EndContext();
            BeginContext(1444, 16, false);
#line 36 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\InvolvedPerson\Index.cshtml"
                                 Write(item.ProjectName);

#line default
#line hidden
            EndContext();
            BeginContext(1460, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(1463, 16, false);
#line 36 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\InvolvedPerson\Index.cshtml"
                                                    Write(item.CompanyName);

#line default
#line hidden
            EndContext();
            BeginContext(1479, 3, true);
            WriteLiteral(")\r\n");
            EndContext();
#line 37 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\InvolvedPerson\Index.cshtml"
                                     if (item.IsAllTeamMemberCompleted)
                                    {

#line default
#line hidden
            BeginContext(1594, 137, true);
            WriteLiteral("                                        <p class=\"small\">(All of your team members except you have completed their assigned tasks.)</p>\r\n");
            EndContext();
#line 40 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\InvolvedPerson\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(1770, 129, true);
            WriteLiteral("                                </span>\r\n                                <br />\r\n                                Expected date : ");
            EndContext();
            BeginContext(1900, 68, false);
#line 43 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\InvolvedPerson\Index.cshtml"
                                           Write(DateTime.Parse(item.ExpectedDate.ToString()).ToString("dd MMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1968, 120, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 48 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\InvolvedPerson\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2103, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 51 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\InvolvedPerson\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(2147, 97, true);
            WriteLiteral("    <div class=\"noIssue\">\r\n        <h3>You don\'t have any assigned issue<br /></h3>\r\n    </div>\r\n");
            EndContext();
#line 57 "D:\WORKS\IssueTracker\IssueTracker\IssueTracker\Views\InvolvedPerson\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2247, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IssueTracker.Models.IssueLogInvolvedPersonListingModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
