#pragma checksum "C:\Users\Vasko\Desktop\NetCodingTest\CodingTest\CodingTest\Views\Project\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4971ab5270a4c70a597fcf7a92d1345a1c02cff8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Index), @"mvc.1.0.view", @"/Views/Project/Index.cshtml")]
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
#line 1 "C:\Users\Vasko\Desktop\NetCodingTest\CodingTest\CodingTest\Views\_ViewImports.cshtml"
using CodingTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vasko\Desktop\NetCodingTest\CodingTest\CodingTest\Views\_ViewImports.cshtml"
using CodingTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Vasko\Desktop\NetCodingTest\CodingTest\CodingTest\Views\_ViewImports.cshtml"
using CodingTest.Models.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4971ab5270a4c70a597fcf7a92d1345a1c02cff8", @"/Views/Project/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eecf657203d2a7fa053c8b4f71940e4c50e47573", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Project>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Project", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Vasko\Desktop\NetCodingTest\CodingTest\CodingTest\Views\Project\Index.cshtml"
  
    ViewData["Title"] = "List of Projects";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 offset-md-2\">\r\n        <table>\r\n            <thead>\r\n                <tr>\r\n                    <th>");
#nullable restore
#line 12 "C:\Users\Vasko\Desktop\NetCodingTest\CodingTest\CodingTest\Views\Project\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.NameProject));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 13 "C:\Users\Vasko\Desktop\NetCodingTest\CodingTest\CodingTest\Views\Project\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 14 "C:\Users\Vasko\Desktop\NetCodingTest\CodingTest\CodingTest\Views\Project\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    \r\n                </tr>\r\n\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\Vasko\Desktop\NetCodingTest\CodingTest\CodingTest\Views\Project\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"align-middle\">\r\n                            <img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 722, "\"", 745, 1);
#nullable restore
#line 24 "C:\Users\Vasko\Desktop\NetCodingTest\CodingTest\CodingTest\Views\Project\Index.cshtml"
WriteAttributeValue("", 728, item.NameProject, 728, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width:150px\" />\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 27 "C:\Users\Vasko\Desktop\NetCodingTest\CodingTest\CodingTest\Views\Project\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 30 "C:\Users\Vasko\Desktop\NetCodingTest\CodingTest\CodingTest\Views\Project\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        \r\n\r\n                        \r\n                    </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Vasko\Desktop\NetCodingTest\CodingTest\CodingTest\Views\Project\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div class=\"text-white\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4971ab5270a4c70a597fcf7a92d1345a1c02cff87695", async() => {
                WriteLiteral(" <i class=\"bi bi-plus-circle\"></i> Add New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
