#pragma checksum "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d46871da7306ebda29adf79499f3614b0367e306"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LiquidatedCompanys_Index), @"mvc.1.0.view", @"/Views/LiquidatedCompanys/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LiquidatedCompanys/Index.cshtml", typeof(AspNetCore.Views_LiquidatedCompanys_Index))]
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
#line 1 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\_ViewImports.cshtml"
using Indiana;

#line default
#line hidden
#line 2 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\_ViewImports.cshtml"
using Indiana.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d46871da7306ebda29adf79499f3614b0367e306", @"/Views/LiquidatedCompanys/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac064a92acf5a4afadc4d0f453fe79576e450585", @"/Views/_ViewImports.cshtml")]
    public class Views_LiquidatedCompanys_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Indiana.Models.LiquidatedCompanys>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 59, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n<!--Do not mess with this code below-->\r\n");
            EndContext();
            BeginContext(157, 713, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d46871da7306ebda29adf79499f3614b0367e3065767", async() => {
                BeginContext(196, 176, true);
                WriteLiteral("\r\n    <div class=\"form-group col\" style=\"padding-right:1em;\">\r\n        <input class=\"form-control select-custom-me\" type=\"text\" name=\"keyword\" id=\"keyword\" placeholder=\"Search\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 372, "\"", 405, 1);
#line 11 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
WriteAttributeValue("", 380, ViewData["SearchString"], 380, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(406, 162, true);
                WriteLiteral(" />\r\n    </div>\r\n    <div class=\"form-group col\">\r\n        <button type=\"search\" class=\"btn btn-primary\">Search</button>\r\n    </div>\r\n    <div class=\"form-row\">\r\n");
                EndContext();
#line 17 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
         foreach (int i in (List<int>)(ViewData["pageList"]))
        {

#line default
#line hidden
                BeginContext(642, 31, true);
                WriteLiteral("            <input type=\"radio\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 673, "\"", 686, 3);
                WriteAttributeValue("", 678, "page{", 678, 5, true);
#line 19 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
WriteAttributeValue("", 683, i, 683, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 685, "}", 685, 1, true);
                EndWriteAttribute();
                BeginContext(687, 19, true);
                WriteLiteral(" name=\"page\" hidden");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 706, "\"", 716, 1);
#line 19 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
WriteAttributeValue("", 714, i, 714, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(717, 95, true);
                WriteLiteral(" onchange=\"this.form.submit();\">\r\n            <label class=\"btn-link\" style=\"padding-right:5px\"");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 812, "\"", 826, 3);
                WriteAttributeValue("", 818, "page{", 818, 5, true);
#line 20 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
WriteAttributeValue("", 823, i, 823, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 825, "}", 825, 1, true);
                EndWriteAttribute();
                BeginContext(827, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(829, 1, false);
#line 20 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
                                                                        Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(830, 10, true);
                WriteLiteral("</label>\r\n");
                EndContext();
#line 21 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(851, 12, true);
                WriteLiteral("    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(870, 43, true);
            WriteLiteral("\r\n<!--Do not mess with this code above-->\r\n");
            EndContext();
#line 25 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
 if (User.IsInRole("Administrator"))
{

#line default
#line hidden
            BeginContext(954, 17, true);
            WriteLiteral("    <p>\r\n        ");
            EndContext();
            BeginContext(971, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d46871da7306ebda29adf79499f3614b0367e30611537", async() => {
                BeginContext(994, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1008, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 30 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1023, 134, true);
            WriteLiteral("<table class=\"table table-striped table-bordered table-hover table-sm\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1158, 41, false);
#line 35 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Usdot));

#line default
#line hidden
            EndContext();
            BeginContext(1199, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1255, 45, false);
#line 38 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LegalName));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 42, true);
            WriteLiteral("\r\n                <br />\r\n                ");
            EndContext();
            BeginContext(1343, 43, false);
#line 40 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Dbaname));

#line default
#line hidden
            EndContext();
            BeginContext(1386, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1442, 43, false);
#line 43 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1485, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1541, 45, false);
#line 46 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Oosreason));

#line default
#line hidden
            EndContext();
            BeginContext(1586, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1642, 43, false);
#line 49 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Oosdate));

#line default
#line hidden
            EndContext();
            BeginContext(1685, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1741, 42, false);
#line 52 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1783, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1839, 47, false);
#line 55 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GeoLocation));

#line default
#line hidden
            EndContext();
            BeginContext(1886, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 61 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2021, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2082, 40, false);
#line 65 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Usdot));

#line default
#line hidden
            EndContext();
            BeginContext(2122, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2190, 44, false);
#line 68 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LegalName));

#line default
#line hidden
            EndContext();
            BeginContext(2234, 50, true);
            WriteLiteral("\r\n                    <br />\r\n                    ");
            EndContext();
            BeginContext(2285, 42, false);
#line 70 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dbaname));

#line default
#line hidden
            EndContext();
            BeginContext(2327, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2395, 42, false);
#line 73 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2437, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2505, 44, false);
#line 76 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Oosreason));

#line default
#line hidden
            EndContext();
            BeginContext(2549, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2617, 42, false);
#line 79 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Oosdate));

#line default
#line hidden
            EndContext();
            BeginContext(2659, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2727, 41, false);
#line 82 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2768, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2836, 46, false);
#line 85 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.GeoLocation));

#line default
#line hidden
            EndContext();
            BeginContext(2882, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 88 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
                     if (User.IsInRole("Administrator"))
                    {

#line default
#line hidden
            BeginContext(3010, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3034, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d46871da7306ebda29adf79499f3614b0367e30621273", async() => {
                BeginContext(3082, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 90 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
                                               WriteLiteral(item.Usdot);

#line default
#line hidden
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
            EndContext();
            BeginContext(3090, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 91 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3115, 43, true);
            WriteLiteral("                    |\r\n                    ");
            EndContext();
            BeginContext(3158, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d46871da7306ebda29adf79499f3614b0367e30623953", async() => {
                BeginContext(3209, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 93 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
                                              WriteLiteral(item.Usdot);

#line default
#line hidden
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
            EndContext();
            BeginContext(3220, 25, true);
            WriteLiteral("\r\n                    |\r\n");
            EndContext();
#line 95 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
                     if (User.IsInRole("Administrator"))
                    {

#line default
#line hidden
            BeginContext(3326, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3350, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d46871da7306ebda29adf79499f3614b0367e30626698", async() => {
                BeginContext(3400, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 97 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
                                                 WriteLiteral(item.Usdot);

#line default
#line hidden
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
            EndContext();
            BeginContext(3410, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 98 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3435, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 101 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\LiquidatedCompanys\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3488, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Indiana.Models.LiquidatedCompanys>> Html { get; private set; }
    }
}
#pragma warning restore 1591
