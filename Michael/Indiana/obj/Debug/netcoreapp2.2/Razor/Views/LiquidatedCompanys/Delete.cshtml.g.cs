#pragma checksum "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\LiquidatedCompanys\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fe4a2ad39433640a73e987c87aecbb597a0587e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LiquidatedCompanys_Delete), @"mvc.1.0.view", @"/Views/LiquidatedCompanys/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LiquidatedCompanys/Delete.cshtml", typeof(AspNetCore.Views_LiquidatedCompanys_Delete))]
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
#line 1 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\_ViewImports.cshtml"
using Indiana;

#line default
#line hidden
#line 2 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\_ViewImports.cshtml"
using Indiana.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fe4a2ad39433640a73e987c87aecbb597a0587e", @"/Views/LiquidatedCompanys/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac064a92acf5a4afadc4d0f453fe79576e450585", @"/Views/_ViewImports.cshtml")]
    public class Views_LiquidatedCompanys_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Indiana.Models.LiquidatedCompanys>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\LiquidatedCompanys\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(86, 188, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>LiquidatedCompanys</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(275, 45, false);
#line 15 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\LiquidatedCompanys\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LegalName));

#line default
#line hidden
            EndContext();
            BeginContext(320, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(384, 41, false);
#line 18 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\LiquidatedCompanys\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LegalName));

#line default
#line hidden
            EndContext();
            BeginContext(425, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(488, 43, false);
#line 21 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\LiquidatedCompanys\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Dbaname));

#line default
#line hidden
            EndContext();
            BeginContext(531, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(595, 39, false);
#line 24 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\LiquidatedCompanys\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Dbaname));

#line default
#line hidden
            EndContext();
            BeginContext(634, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(697, 43, false);
#line 27 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\LiquidatedCompanys\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(740, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(804, 39, false);
#line 30 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\LiquidatedCompanys\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(843, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(906, 45, false);
#line 33 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\LiquidatedCompanys\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Oosreason));

#line default
#line hidden
            EndContext();
            BeginContext(951, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1015, 41, false);
#line 36 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\LiquidatedCompanys\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Oosreason));

#line default
#line hidden
            EndContext();
            BeginContext(1056, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1119, 43, false);
#line 39 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\LiquidatedCompanys\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Oosdate));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1226, 39, false);
#line 42 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\LiquidatedCompanys\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Oosdate));

#line default
#line hidden
            EndContext();
            BeginContext(1265, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1328, 42, false);
#line 45 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\LiquidatedCompanys\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1370, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1434, 38, false);
#line 48 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\LiquidatedCompanys\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1472, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1535, 47, false);
#line 51 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\LiquidatedCompanys\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GeoLocation));

#line default
#line hidden
            EndContext();
            BeginContext(1582, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1646, 43, false);
#line 54 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\LiquidatedCompanys\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GeoLocation));

#line default
#line hidden
            EndContext();
            BeginContext(1689, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1752, 44, false);
#line 57 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\LiquidatedCompanys\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AddminId));

#line default
#line hidden
            EndContext();
            BeginContext(1796, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1860, 40, false);
#line 60 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\LiquidatedCompanys\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AddminId));

#line default
#line hidden
            EndContext();
            BeginContext(1900, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1938, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fe4a2ad39433640a73e987c87aecbb597a0587e12208", async() => {
                BeginContext(1964, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1974, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8fe4a2ad39433640a73e987c87aecbb597a0587e12601", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 65 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\LiquidatedCompanys\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Usdot);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2013, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2096, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fe4a2ad39433640a73e987c87aecbb597a0587e14531", async() => {
                    BeginContext(2118, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2134, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2147, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Indiana.Models.LiquidatedCompanys> Html { get; private set; }
    }
}
#pragma warning restore 1591
