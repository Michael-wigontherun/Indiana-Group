#pragma checksum "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d27364f66aa0ba7bd882e6e1ab099f6ce015d96d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TruckingCompanies_Delete), @"mvc.1.0.view", @"/Views/TruckingCompanies/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TruckingCompanies/Delete.cshtml", typeof(AspNetCore.Views_TruckingCompanies_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d27364f66aa0ba7bd882e6e1ab099f6ce015d96d", @"/Views/TruckingCompanies/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac064a92acf5a4afadc4d0f453fe79576e450585", @"/Views/_ViewImports.cshtml")]
    public class Views_TruckingCompanies_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Indiana.Models.TruckingCompanies>
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(85, 293, true);
            WriteLiteral(@"
<h1 style=""background-color: lightgray"">Delete</h1>

<h3 style=""background-color: lightgray"">Are you sure you want to delete this?</h3>
<div style=""background-color: lightgray"">
    <h4>TruckingCompanies</h4>
    <hr />
    <dl class=""row"">
        <dt class=""col-sm-2"">
            ");
            EndContext();
            BeginContext(379, 45, false);
#line 15 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LegalName));

#line default
#line hidden
            EndContext();
            BeginContext(424, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(486, 41, false);
#line 18 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LegalName));

#line default
#line hidden
            EndContext();
            BeginContext(527, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(588, 43, false);
#line 21 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Dbaname));

#line default
#line hidden
            EndContext();
            BeginContext(631, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(693, 39, false);
#line 24 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Dbaname));

#line default
#line hidden
            EndContext();
            BeginContext(732, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(793, 54, false);
#line 27 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CARRIER_OPERATION_));

#line default
#line hidden
            EndContext();
            BeginContext(847, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(909, 50, false);
#line 30 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CARRIER_OPERATION_));

#line default
#line hidden
            EndContext();
            BeginContext(959, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1020, 44, false);
#line 33 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HM_FLAG_));

#line default
#line hidden
            EndContext();
            BeginContext(1064, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1126, 40, false);
#line 36 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HM_FLAG_));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1227, 44, false);
#line 39 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PC_FLAG_));

#line default
#line hidden
            EndContext();
            BeginContext(1271, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1333, 40, false);
#line 42 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PC_FLAG_));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1434, 47, false);
#line 45 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PHY_STREET_));

#line default
#line hidden
            EndContext();
            BeginContext(1481, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1543, 43, false);
#line 48 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PHY_STREET_));

#line default
#line hidden
            EndContext();
            BeginContext(1586, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1647, 45, false);
#line 51 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PHY_CITY_));

#line default
#line hidden
            EndContext();
            BeginContext(1692, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1754, 41, false);
#line 54 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PHY_CITY_));

#line default
#line hidden
            EndContext();
            BeginContext(1795, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1856, 46, false);
#line 57 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PHY_STATE_));

#line default
#line hidden
            EndContext();
            BeginContext(1902, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1964, 42, false);
#line 60 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PHY_STATE_));

#line default
#line hidden
            EndContext();
            BeginContext(2006, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2067, 44, false);
#line 63 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PHY_ZIP_));

#line default
#line hidden
            EndContext();
            BeginContext(2111, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2173, 40, false);
#line 66 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PHY_ZIP_));

#line default
#line hidden
            EndContext();
            BeginContext(2213, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2274, 48, false);
#line 69 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PHY_COUNTRY_));

#line default
#line hidden
            EndContext();
            BeginContext(2322, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2384, 44, false);
#line 72 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PHY_COUNTRY_));

#line default
#line hidden
            EndContext();
            BeginContext(2428, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2489, 51, false);
#line 75 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MAILING_STREET_));

#line default
#line hidden
            EndContext();
            BeginContext(2540, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2602, 47, false);
#line 78 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MAILING_STREET_));

#line default
#line hidden
            EndContext();
            BeginContext(2649, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2710, 49, false);
#line 81 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MAILING_CITY_));

#line default
#line hidden
            EndContext();
            BeginContext(2759, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2821, 45, false);
#line 84 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MAILING_CITY_));

#line default
#line hidden
            EndContext();
            BeginContext(2866, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2927, 50, false);
#line 87 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MAILING_STATE_));

#line default
#line hidden
            EndContext();
            BeginContext(2977, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3039, 46, false);
#line 90 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MAILING_STATE_));

#line default
#line hidden
            EndContext();
            BeginContext(3085, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3146, 48, false);
#line 93 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MAILING_ZIP_));

#line default
#line hidden
            EndContext();
            BeginContext(3194, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3256, 44, false);
#line 96 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MAILING_ZIP_));

#line default
#line hidden
            EndContext();
            BeginContext(3300, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3361, 52, false);
#line 99 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MAILING_COUNTRY_));

#line default
#line hidden
            EndContext();
            BeginContext(3413, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3475, 48, false);
#line 102 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MAILING_COUNTRY_));

#line default
#line hidden
            EndContext();
            BeginContext(3523, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3584, 46, false);
#line 105 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TELEPHONE_));

#line default
#line hidden
            EndContext();
            BeginContext(3630, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3692, 42, false);
#line 108 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TELEPHONE_));

#line default
#line hidden
            EndContext();
            BeginContext(3734, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3795, 40, false);
#line 111 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FAX_));

#line default
#line hidden
            EndContext();
            BeginContext(3835, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3897, 36, false);
#line 114 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FAX_));

#line default
#line hidden
            EndContext();
            BeginContext(3933, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3994, 50, false);
#line 117 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EMAIL_ADDRESS_));

#line default
#line hidden
            EndContext();
            BeginContext(4044, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4106, 46, false);
#line 120 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EMAIL_ADDRESS_));

#line default
#line hidden
            EndContext();
            BeginContext(4152, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4213, 48, false);
#line 123 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MCS150_DATE_));

#line default
#line hidden
            EndContext();
            BeginContext(4261, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4323, 44, false);
#line 126 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MCS150_DATE_));

#line default
#line hidden
            EndContext();
            BeginContext(4367, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4428, 51, false);
#line 129 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MCS150_MILEAGE_));

#line default
#line hidden
            EndContext();
            BeginContext(4479, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4541, 47, false);
#line 132 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MCS150_MILEAGE_));

#line default
#line hidden
            EndContext();
            BeginContext(4588, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4649, 56, false);
#line 135 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MCS150_MILEAGE_YEAR_));

#line default
#line hidden
            EndContext();
            BeginContext(4705, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4767, 52, false);
#line 138 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MCS150_MILEAGE_YEAR_));

#line default
#line hidden
            EndContext();
            BeginContext(4819, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4880, 45, false);
#line 141 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ADD_DATE_));

#line default
#line hidden
            EndContext();
            BeginContext(4925, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4987, 41, false);
#line 144 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ADD_DATE_));

#line default
#line hidden
            EndContext();
            BeginContext(5028, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5089, 46, false);
#line 147 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OIC_STATE_));

#line default
#line hidden
            EndContext();
            BeginContext(5135, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5197, 42, false);
#line 150 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OIC_STATE_));

#line default
#line hidden
            EndContext();
            BeginContext(5239, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5300, 51, false);
#line 153 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NBR_POWER_UNIT_));

#line default
#line hidden
            EndContext();
            BeginContext(5351, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5413, 47, false);
#line 156 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NBR_POWER_UNIT_));

#line default
#line hidden
            EndContext();
            BeginContext(5460, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5521, 49, false);
#line 159 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DRIVER_TOTAL_));

#line default
#line hidden
            EndContext();
            BeginContext(5570, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5632, 45, false);
#line 162 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DRIVER_TOTAL_));

#line default
#line hidden
            EndContext();
            BeginContext(5677, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5738, 47, false);
#line 165 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GeoLocation));

#line default
#line hidden
            EndContext();
            BeginContext(5785, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5847, 43, false);
#line 168 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GeoLocation));

#line default
#line hidden
            EndContext();
            BeginContext(5890, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5951, 44, false);
#line 171 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.addminID));

#line default
#line hidden
            EndContext();
            BeginContext(5995, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(6057, 40, false);
#line 174 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
       Write(Html.DisplayFor(model => model.addminID));

#line default
#line hidden
            EndContext();
            BeginContext(6097, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(6131, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d27364f66aa0ba7bd882e6e1ab099f6ce015d96d29275", async() => {
                BeginContext(6157, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(6167, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d27364f66aa0ba7bd882e6e1ab099f6ce015d96d29668", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 179 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Michael\Indiana\Views\TruckingCompanies\Delete.cshtml"
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
                BeginContext(6206, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(6289, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d27364f66aa0ba7bd882e6e1ab099f6ce015d96d31598", async() => {
                    BeginContext(6311, 12, true);
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
                BeginContext(6327, 6, true);
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
            BeginContext(6340, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Indiana.Models.TruckingCompanies> Html { get; private set; }
    }
}
#pragma warning restore 1591
