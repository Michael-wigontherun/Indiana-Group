#pragma checksum "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed65a37afb026117e6257f8110c229418a87f474"
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
#line 1 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\_ViewImports.cshtml"
using Indiana;

#line default
#line hidden
#line 2 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\_ViewImports.cshtml"
using Indiana.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed65a37afb026117e6257f8110c229418a87f474", @"/Views/TruckingCompanies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac064a92acf5a4afadc4d0f453fe79576e450585", @"/Views/_ViewImports.cshtml")]
    public class Views_TruckingCompanies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Indiana.Models.TruckingCompanies>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(86, 140, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>TruckingCompanies</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(227, 45, false);
#line 14 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LegalName));

#line default
#line hidden
            EndContext();
            BeginContext(272, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(336, 41, false);
#line 17 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.LegalName));

#line default
#line hidden
            EndContext();
            BeginContext(377, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(440, 43, false);
#line 20 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Dbaname));

#line default
#line hidden
            EndContext();
            BeginContext(483, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(547, 39, false);
#line 23 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.Dbaname));

#line default
#line hidden
            EndContext();
            BeginContext(586, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(649, 54, false);
#line 26 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CARRIER_OPERATION_));

#line default
#line hidden
            EndContext();
            BeginContext(703, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(767, 50, false);
#line 29 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.CARRIER_OPERATION_));

#line default
#line hidden
            EndContext();
            BeginContext(817, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(880, 44, false);
#line 32 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HM_FLAG_));

#line default
#line hidden
            EndContext();
            BeginContext(924, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(988, 40, false);
#line 35 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.HM_FLAG_));

#line default
#line hidden
            EndContext();
            BeginContext(1028, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1091, 44, false);
#line 38 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PC_FLAG_));

#line default
#line hidden
            EndContext();
            BeginContext(1135, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1199, 40, false);
#line 41 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.PC_FLAG_));

#line default
#line hidden
            EndContext();
            BeginContext(1239, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1302, 47, false);
#line 44 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PHY_STREET_));

#line default
#line hidden
            EndContext();
            BeginContext(1349, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1413, 43, false);
#line 47 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.PHY_STREET_));

#line default
#line hidden
            EndContext();
            BeginContext(1456, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1519, 45, false);
#line 50 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PHY_CITY_));

#line default
#line hidden
            EndContext();
            BeginContext(1564, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1628, 41, false);
#line 53 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.PHY_CITY_));

#line default
#line hidden
            EndContext();
            BeginContext(1669, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1732, 46, false);
#line 56 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PHY_STATE_));

#line default
#line hidden
            EndContext();
            BeginContext(1778, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1842, 42, false);
#line 59 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.PHY_STATE_));

#line default
#line hidden
            EndContext();
            BeginContext(1884, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1947, 44, false);
#line 62 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PHY_ZIP_));

#line default
#line hidden
            EndContext();
            BeginContext(1991, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2055, 40, false);
#line 65 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.PHY_ZIP_));

#line default
#line hidden
            EndContext();
            BeginContext(2095, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2158, 48, false);
#line 68 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PHY_COUNTRY_));

#line default
#line hidden
            EndContext();
            BeginContext(2206, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2270, 44, false);
#line 71 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.PHY_COUNTRY_));

#line default
#line hidden
            EndContext();
            BeginContext(2314, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2377, 51, false);
#line 74 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MAILING_STREET_));

#line default
#line hidden
            EndContext();
            BeginContext(2428, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2492, 47, false);
#line 77 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.MAILING_STREET_));

#line default
#line hidden
            EndContext();
            BeginContext(2539, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2602, 49, false);
#line 80 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MAILING_CITY_));

#line default
#line hidden
            EndContext();
            BeginContext(2651, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2715, 45, false);
#line 83 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.MAILING_CITY_));

#line default
#line hidden
            EndContext();
            BeginContext(2760, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2823, 50, false);
#line 86 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MAILING_STATE_));

#line default
#line hidden
            EndContext();
            BeginContext(2873, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2937, 46, false);
#line 89 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.MAILING_STATE_));

#line default
#line hidden
            EndContext();
            BeginContext(2983, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3046, 48, false);
#line 92 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MAILING_ZIP_));

#line default
#line hidden
            EndContext();
            BeginContext(3094, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3158, 44, false);
#line 95 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.MAILING_ZIP_));

#line default
#line hidden
            EndContext();
            BeginContext(3202, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3265, 52, false);
#line 98 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MAILING_COUNTRY_));

#line default
#line hidden
            EndContext();
            BeginContext(3317, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3381, 48, false);
#line 101 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.MAILING_COUNTRY_));

#line default
#line hidden
            EndContext();
            BeginContext(3429, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3492, 46, false);
#line 104 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TELEPHONE_));

#line default
#line hidden
            EndContext();
            BeginContext(3538, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3602, 42, false);
#line 107 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.TELEPHONE_));

#line default
#line hidden
            EndContext();
            BeginContext(3644, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3707, 40, false);
#line 110 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FAX_));

#line default
#line hidden
            EndContext();
            BeginContext(3747, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3811, 36, false);
#line 113 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.FAX_));

#line default
#line hidden
            EndContext();
            BeginContext(3847, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3910, 50, false);
#line 116 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EMAIL_ADDRESS_));

#line default
#line hidden
            EndContext();
            BeginContext(3960, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4024, 46, false);
#line 119 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.EMAIL_ADDRESS_));

#line default
#line hidden
            EndContext();
            BeginContext(4070, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4133, 48, false);
#line 122 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MCS150_DATE_));

#line default
#line hidden
            EndContext();
            BeginContext(4181, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4245, 44, false);
#line 125 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.MCS150_DATE_));

#line default
#line hidden
            EndContext();
            BeginContext(4289, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4352, 51, false);
#line 128 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MCS150_MILEAGE_));

#line default
#line hidden
            EndContext();
            BeginContext(4403, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4467, 47, false);
#line 131 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.MCS150_MILEAGE_));

#line default
#line hidden
            EndContext();
            BeginContext(4514, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4577, 56, false);
#line 134 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MCS150_MILEAGE_YEAR_));

#line default
#line hidden
            EndContext();
            BeginContext(4633, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4697, 52, false);
#line 137 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.MCS150_MILEAGE_YEAR_));

#line default
#line hidden
            EndContext();
            BeginContext(4749, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(4812, 45, false);
#line 140 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ADD_DATE_));

#line default
#line hidden
            EndContext();
            BeginContext(4857, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(4921, 41, false);
#line 143 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.ADD_DATE_));

#line default
#line hidden
            EndContext();
            BeginContext(4962, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5025, 46, false);
#line 146 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OIC_STATE_));

#line default
#line hidden
            EndContext();
            BeginContext(5071, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5135, 42, false);
#line 149 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.OIC_STATE_));

#line default
#line hidden
            EndContext();
            BeginContext(5177, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5240, 51, false);
#line 152 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NBR_POWER_UNIT_));

#line default
#line hidden
            EndContext();
            BeginContext(5291, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5355, 47, false);
#line 155 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.NBR_POWER_UNIT_));

#line default
#line hidden
            EndContext();
            BeginContext(5402, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5465, 49, false);
#line 158 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DRIVER_TOTAL_));

#line default
#line hidden
            EndContext();
            BeginContext(5514, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5578, 45, false);
#line 161 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.DRIVER_TOTAL_));

#line default
#line hidden
            EndContext();
            BeginContext(5623, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5686, 47, false);
#line 164 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GeoLocation));

#line default
#line hidden
            EndContext();
            BeginContext(5733, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(5797, 43, false);
#line 167 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.GeoLocation));

#line default
#line hidden
            EndContext();
            BeginContext(5840, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(5903, 44, false);
#line 170 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.addminID));

#line default
#line hidden
            EndContext();
            BeginContext(5947, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(6011, 40, false);
#line 173 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
       Write(Html.DisplayFor(model => model.addminID));

#line default
#line hidden
            EndContext();
            BeginContext(6051, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(6098, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed65a37afb026117e6257f8110c229418a87f47428370", async() => {
                BeginContext(6147, 4, true);
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
#line 178 "F:\IndianaGroup\Indiana-Group\Seth\Indiana - Copy\Indiana\Views\TruckingCompanies\Details.cshtml"
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
            BeginContext(6155, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(6163, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed65a37afb026117e6257f8110c229418a87f47430713", async() => {
                BeginContext(6185, 12, true);
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
            BeginContext(6201, 10, true);
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
