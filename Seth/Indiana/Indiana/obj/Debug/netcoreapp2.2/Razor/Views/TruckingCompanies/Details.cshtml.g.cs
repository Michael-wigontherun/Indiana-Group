#pragma checksum "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "805aeb80f18eb796203ce4e7769fe7dba7e78dd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TruckingCompanies_Details), @"mvc.1.0.view", @"/Views/TruckingCompanies/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TruckingCompanies/Details.cshtml", typeof(AspNetCore.Views_TruckingCompanies_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"805aeb80f18eb796203ce4e7769fe7dba7e78dd7", @"/Views/TruckingCompanies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac064a92acf5a4afadc4d0f453fe79576e450585", @"/Views/_ViewImports.cshtml")]
    public class Views_TruckingCompanies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Indiana.Models.TruckingCompanies>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Map", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(86, 213, true);
            WriteLiteral("\r\n<h1 style=\"background-color: lightgray\">Details</h1>\r\n\r\n<div style=\"background-color: lightgray\">\r\n    <h4>TruckingCompanies</h4>\r\n    <hr />\r\n    <dl class=\"row\" >\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(300, 45, false);
#line 14 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LegalName));

#line default
#line hidden
            EndContext();
            BeginContext(345, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(409, 41, false);
#line 17 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.LegalName));

#line default
#line hidden
            EndContext();
            BeginContext(450, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(513, 43, false);
#line 20 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dbaname));

#line default
#line hidden
            EndContext();
            BeginContext(556, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(620, 39, false);
#line 23 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dbaname));

#line default
#line hidden
            EndContext();
            BeginContext(659, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(722, 54, false);
#line 26 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CARRIER_OPERATION_));

#line default
#line hidden
            EndContext();
            BeginContext(776, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(840, 50, false);
#line 29 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.CARRIER_OPERATION_));

#line default
#line hidden
            EndContext();
            BeginContext(890, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(953, 44, false);
#line 32 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HM_FLAG_));

#line default
#line hidden
            EndContext();
            BeginContext(997, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1061, 40, false);
#line 35 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.HM_FLAG_));

#line default
#line hidden
            EndContext();
            BeginContext(1101, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1164, 44, false);
#line 38 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PC_FLAG_));

#line default
#line hidden
            EndContext();
            BeginContext(1208, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1272, 40, false);
#line 41 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.PC_FLAG_));

#line default
#line hidden
            EndContext();
            BeginContext(1312, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1375, 47, false);
#line 44 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PHY_STREET_));

#line default
#line hidden
            EndContext();
            BeginContext(1422, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1486, 43, false);
#line 47 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.PHY_STREET_));

#line default
#line hidden
            EndContext();
            BeginContext(1529, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1592, 45, false);
#line 50 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PHY_CITY_));

#line default
#line hidden
            EndContext();
            BeginContext(1637, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1701, 41, false);
#line 53 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.PHY_CITY_));

#line default
#line hidden
            EndContext();
            BeginContext(1742, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1805, 46, false);
#line 56 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PHY_STATE_));

#line default
#line hidden
            EndContext();
            BeginContext(1851, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1915, 42, false);
#line 59 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.PHY_STATE_));

#line default
#line hidden
            EndContext();
            BeginContext(1957, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2020, 44, false);
#line 62 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PHY_ZIP_));

#line default
#line hidden
            EndContext();
            BeginContext(2064, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2128, 40, false);
#line 65 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.PHY_ZIP_));

#line default
#line hidden
            EndContext();
            BeginContext(2168, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2231, 48, false);
#line 68 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PHY_COUNTRY_));

#line default
#line hidden
            EndContext();
            BeginContext(2279, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2343, 44, false);
#line 71 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.PHY_COUNTRY_));

#line default
#line hidden
            EndContext();
            BeginContext(2387, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2450, 51, false);
#line 74 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MAILING_STREET_));

#line default
#line hidden
            EndContext();
            BeginContext(2501, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2565, 47, false);
#line 77 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.MAILING_STREET_));

#line default
#line hidden
            EndContext();
            BeginContext(2612, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2675, 49, false);
#line 80 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MAILING_CITY_));

#line default
#line hidden
            EndContext();
            BeginContext(2724, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2788, 45, false);
#line 83 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.MAILING_CITY_));

#line default
#line hidden
            EndContext();
            BeginContext(2833, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2896, 50, false);
#line 86 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MAILING_STATE_));

#line default
#line hidden
            EndContext();
            BeginContext(2946, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3010, 46, false);
#line 89 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.MAILING_STATE_));

#line default
#line hidden
            EndContext();
            BeginContext(3056, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3119, 48, false);
#line 92 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MAILING_ZIP_));

#line default
#line hidden
            EndContext();
            BeginContext(3167, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3231, 44, false);
#line 95 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.MAILING_ZIP_));

#line default
#line hidden
            EndContext();
            BeginContext(3275, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3338, 52, false);
#line 98 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MAILING_COUNTRY_));

#line default
#line hidden
            EndContext();
            BeginContext(3390, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3454, 48, false);
#line 101 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.MAILING_COUNTRY_));

#line default
#line hidden
            EndContext();
            BeginContext(3502, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3565, 46, false);
#line 104 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TELEPHONE_));

#line default
#line hidden
            EndContext();
            BeginContext(3611, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3675, 42, false);
#line 107 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.TELEPHONE_));

#line default
#line hidden
            EndContext();
            BeginContext(3717, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3780, 40, false);
#line 110 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FAX_));

#line default
#line hidden
            EndContext();
            BeginContext(3820, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3884, 36, false);
#line 113 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.FAX_));

#line default
#line hidden
            EndContext();
            BeginContext(3920, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3983, 50, false);
#line 116 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EMAIL_ADDRESS_));

#line default
#line hidden
            EndContext();
            BeginContext(4033, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4097, 46, false);
#line 119 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.EMAIL_ADDRESS_));

#line default
#line hidden
            EndContext();
            BeginContext(4143, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4206, 48, false);
#line 122 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MCS150_DATE_));

#line default
#line hidden
            EndContext();
            BeginContext(4254, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4318, 44, false);
#line 125 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.MCS150_DATE_));

#line default
#line hidden
            EndContext();
            BeginContext(4362, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4425, 51, false);
#line 128 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MCS150_MILEAGE_));

#line default
#line hidden
            EndContext();
            BeginContext(4476, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4540, 47, false);
#line 131 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.MCS150_MILEAGE_));

#line default
#line hidden
            EndContext();
            BeginContext(4587, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4650, 56, false);
#line 134 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MCS150_MILEAGE_YEAR_));

#line default
#line hidden
            EndContext();
            BeginContext(4706, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4770, 52, false);
#line 137 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.MCS150_MILEAGE_YEAR_));

#line default
#line hidden
            EndContext();
            BeginContext(4822, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4885, 45, false);
#line 140 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ADD_DATE_));

#line default
#line hidden
            EndContext();
            BeginContext(4930, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4994, 41, false);
#line 143 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.ADD_DATE_));

#line default
#line hidden
            EndContext();
            BeginContext(5035, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5098, 46, false);
#line 146 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OIC_STATE_));

#line default
#line hidden
            EndContext();
            BeginContext(5144, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5208, 42, false);
#line 149 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.OIC_STATE_));

#line default
#line hidden
            EndContext();
            BeginContext(5250, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5313, 51, false);
#line 152 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NBR_POWER_UNIT_));

#line default
#line hidden
            EndContext();
            BeginContext(5364, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5428, 47, false);
#line 155 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.NBR_POWER_UNIT_));

#line default
#line hidden
            EndContext();
            BeginContext(5475, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5538, 49, false);
#line 158 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DRIVER_TOTAL_));

#line default
#line hidden
            EndContext();
            BeginContext(5587, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5651, 45, false);
#line 161 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.DRIVER_TOTAL_));

#line default
#line hidden
            EndContext();
            BeginContext(5696, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5759, 47, false);
#line 164 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GeoLocation));

#line default
#line hidden
            EndContext();
            BeginContext(5806, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5870, 43, false);
#line 167 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.GeoLocation));

#line default
#line hidden
            EndContext();
            BeginContext(5913, 43, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n");
            EndContext();
#line 172 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
     if (User.IsInRole("Administrator"))
    {

#line default
#line hidden
            BeginContext(6005, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(6013, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "805aeb80f18eb796203ce4e7769fe7dba7e78dd728672", async() => {
                BeginContext(6062, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 174 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
                               WriteLiteral(Model.Usdot);

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
            BeginContext(6070, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 175 "D:\Users\sethd\Documents\GitHub\Indiana-Group\Seth\Indiana\Indiana\Views\TruckingCompanies\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(6079, 11, true);
            WriteLiteral("    |\r\n    ");
            EndContext();
            BeginContext(6090, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "805aeb80f18eb796203ce4e7769fe7dba7e78dd731293", async() => {
                BeginContext(6112, 12, true);
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
            BeginContext(6128, 13, true);
            WriteLiteral("\r\n    |\r\n    ");
            EndContext();
            BeginContext(6141, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "805aeb80f18eb796203ce4e7769fe7dba7e78dd732687", async() => {
                BeginContext(6184, 3, true);
                WriteLiteral("Map");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
            BeginContext(6191, 17, true);
            WriteLiteral("\r\n    |\r\n</div>\r\n");
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
