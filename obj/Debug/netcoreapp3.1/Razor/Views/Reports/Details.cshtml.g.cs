#pragma checksum "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9fd6951cd78bb2b05ea425ea935d422613b30b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_Details), @"mvc.1.0.view", @"/Views/Reports/Details.cshtml")]
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
#line 1 "E:\Repos\Metrict\Metrict\Views\_ViewImports.cshtml"
using Metrict;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Repos\Metrict\Metrict\Views\_ViewImports.cshtml"
using Metrict.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9fd6951cd78bb2b05ea425ea935d422613b30b5", @"/Views/Reports/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99945052b75fd5138d85b542a997bbae47015463", @"/Views/_ViewImports.cshtml")]
    public class Views_Reports_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Metrict.Models.ReportViewModels.CampaignReportData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container vh100\">\r\n    <main role=\"main\" class=\"pb-3\">\r\n        <h1>Details</h1>\r\n\r\n        <div>\r\n            <h4>Report</h4>\r\n            <hr />\r\n            <dl class=\"row\">\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 16 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Reports.ApplicationUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 19 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
               Write(Html.DisplayFor(model => model.Reports.ApplicationUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 22 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Campaigns.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 25 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
               Write(Html.DisplayFor(model => model.Reports.CampaignName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n");
            WriteLiteral("                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 34 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Reports.SubmissionDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 37 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
               Write(Html.DisplayFor(model => model.Reports.SubmissionDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 40 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Reports.LastEditDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 43 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
               Write(Html.DisplayFor(model => model.Reports.LastEditDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n");
#nullable restore
#line 45 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                 if (Model.Campaigns.DataColumnNumber1Title != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 48 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Campaigns.DataColumnNumber1Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 51 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reports.DataColumnNumber1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 53 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 55 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                 if (Model.Campaigns.DataColumnNumber2Title != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 58 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Campaigns.DataColumnNumber2Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 61 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reports.DataColumnNumber2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 63 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                 if (Model.Campaigns.DataColumnNumber3Title != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 67 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Campaigns.DataColumnNumber3Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 70 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reports.DataColumnNumber3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 72 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                 if (Model.Campaigns.DataColumnNumber4Title != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 76 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Campaigns.DataColumnNumber4Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 79 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reports.DataColumnNumber4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 81 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                 if (Model.Campaigns.DataColumnNumber5Title != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 85 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Campaigns.DataColumnNumber5Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 88 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reports.DataColumnNumber5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 90 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                 if (Model.Campaigns.DataColumnNumber6Title != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 94 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Campaigns.DataColumnNumber6Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 97 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reports.DataColumnNumber6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 99 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                 if (Model.Campaigns.DataColumnNumber7Title != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 103 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Campaigns.DataColumnNumber7Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 106 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reports.DataColumnNumber7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 108 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                 if (Model.Campaigns.DataColumnNumber8Title != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 112 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Campaigns.DataColumnNumber8Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 115 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reports.DataColumnNumber8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 117 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                 if (Model.Campaigns.DataColumnNumber9Title != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 121 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Campaigns.DataColumnNumber9Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 124 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reports.DataColumnNumber9));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 126 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                 if (Model.Campaigns.DataColumnNumber10Title != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 130 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Campaigns.DataColumnNumber10Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 133 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reports.DataColumnNumber10));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 135 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                 if (Model.Campaigns.DataColumnTextATitle != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 139 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Campaigns.DataColumnTextATitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 142 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reports.DataColumnTextA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 144 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                 if (Model.Campaigns.DataColumnTextBTitle != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 148 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Campaigns.DataColumnTextBTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 151 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reports.DataColumnTextB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 153 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 154 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                 if (Model.Campaigns.DataColumnTextCTitle != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 157 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Campaigns.DataColumnTextCTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 160 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reports.DataColumnTextC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 162 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 163 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                 if (Model.Campaigns.DataColumnTextDTitle != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 166 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Campaigns.DataColumnTextDTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 169 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reports.DataColumnTextD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 171 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 172 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                 if (Model.Campaigns.DataColumnTextETitle != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 175 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Campaigns.DataColumnTextETitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 178 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reports.DataColumnTextE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 180 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 181 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                 if (Model.Campaigns.DataColumnTextFTitle != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 184 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Campaigns.DataColumnTextFTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 187 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reports.DataColumnTextF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 189 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 190 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                 if (Model.Campaigns.DataColumnTextGTitle != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 193 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Campaigns.DataColumnTextGTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 196 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reports.DataColumnTextG));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 198 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 199 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                 if (Model.Campaigns.DataColumnTextHTitle != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 202 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Campaigns.DataColumnTextHTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 205 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reports.DataColumnTextH));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 207 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 208 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                 if (Model.Campaigns.DataColumnTextITitle != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 211 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Campaigns.DataColumnTextITitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 214 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reports.DataColumnTextI));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 216 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 217 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                 if (Model.Campaigns.DataColumnTextJTitle != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 220 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Campaigns.DataColumnTextJTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 223 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Reports.DataColumnTextJ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n");
#nullable restore
#line 225 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </dl>\r\n        </div>\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9fd6951cd78bb2b05ea425ea935d422613b30b529532", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 241 "E:\Repos\Metrict\Metrict\Views\Reports\Details.cshtml"
                                   WriteLiteral(Model.Reports.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9fd6951cd78bb2b05ea425ea935d422613b30b531674", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n        </div>\r\n    </main>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Metrict.Models.ReportViewModels.CampaignReportData> Html { get; private set; }
    }
}
#pragma warning restore 1591
