#pragma checksum "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "928a1b88e75c6bcaaaf4243d7fedd4d744f1bf88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Torta_Index), @"mvc.1.0.view", @"/Views/Torta/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Torta/Index.cshtml", typeof(AspNetCore.Views_Torta_Index))]
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
#line 1 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\_ViewImports.cshtml"
using Torta5.Web;

#line default
#line hidden
#line 2 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\_ViewImports.cshtml"
using Torta5.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"928a1b88e75c6bcaaaf4243d7fedd4d744f1bf88", @"/Views/Torta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"225fe4308e38a8f39325b397e4308f74da01949e", @"/Views/_ViewImports.cshtml")]
    public class Views_Torta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Torta.DA.Models.Torta>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(86, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(115, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff65cd5f07154872a36fc0294342bd66", async() => {
                BeginContext(138, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(152, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(245, 38, false);
#line 16 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(283, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(339, 40, false);
#line 19 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(379, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(435, 47, false);
#line 22 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descrizione));

#line default
#line hidden
            EndContext();
            BeginContext(482, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(538, 48, false);
#line 25 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Osservazioni));

#line default
#line hidden
            EndContext();
            BeginContext(586, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(642, 42, false);
#line 28 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Prezzo));

#line default
#line hidden
            EndContext();
            BeginContext(684, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(740, 44, false);
#line 31 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(784, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(840, 53, false);
#line 34 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ImageThumbnailUrl));

#line default
#line hidden
            EndContext();
            BeginContext(893, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(949, 48, false);
#line 37 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TortaDelMese));

#line default
#line hidden
            EndContext();
            BeginContext(997, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1115, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1164, 37, false);
#line 46 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1201, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1257, 39, false);
#line 49 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1352, 46, false);
#line 52 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descrizione));

#line default
#line hidden
            EndContext();
            BeginContext(1398, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1454, 47, false);
#line 55 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Osservazioni));

#line default
#line hidden
            EndContext();
            BeginContext(1501, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1557, 41, false);
#line 58 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Prezzo));

#line default
#line hidden
            EndContext();
            BeginContext(1598, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1654, 43, false);
#line 61 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1697, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1753, 52, false);
#line 64 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ImageThumbnailUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1805, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1861, 47, false);
#line 67 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TortaDelMese));

#line default
#line hidden
            EndContext();
            BeginContext(1908, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1964, 65, false);
#line 70 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2029, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2050, 71, false);
#line 71 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2121, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2142, 69, false);
#line 72 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2211, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 75 "Z:\giuliobosco On My Mac\drive\progetti\CsharpSAMT\05-TortaDellaNonna\Torta5.Web\Views\Torta\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2250, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Torta.DA.Models.Torta>> Html { get; private set; }
    }
}
#pragma warning restore 1591
