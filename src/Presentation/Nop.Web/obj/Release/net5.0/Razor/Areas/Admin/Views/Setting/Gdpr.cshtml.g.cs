#pragma checksum "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/Setting/Gdpr.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd89a809d5042c9132a6b13f7cc1a972e420316f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Setting_Gdpr), @"mvc.1.0.view", @"/Areas/Admin/Views/Setting/Gdpr.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 9 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Core.Domain.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Core.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Core.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Services.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using static Nop.Services.Common.NopLinksDefaults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Affiliates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Directory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Discounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ExternalAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Forums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.MultiFactorAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Payments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins.Marketplace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Reports;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Shipping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Templates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Vendors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Models.DataTables;

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd89a809d5042c9132a6b13f7cc1a972e420316f", @"/Areas/Admin/Views/Setting/Gdpr.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181066c519b5e3a88fbfc1b430cb86e3463f4c97", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Setting_Gdpr : Nop.Web.Framework.Mvc.Razor.NopRazorPage<GdprSettingsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-name", "gdprsettings-common", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-icon", "fas fa-info", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-name", "gdprsettings-consents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-icon", "fas fa-thumbs-o-up", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("gdprsettings-cards"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Setting", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GDPR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopCardsTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopCardsTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopCardTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/Setting/Gdpr.cshtml"
  
    //page title
    ViewBag.PageTitle = T("Admin.Configuration.Settings.Gdpr").Text;
    //active menu item (system name)
    Html.SetActiveMenuItemSystemName("GDPR settings");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/Setting/Gdpr.cshtml"
  
    const string hideCommonBlockAttributeName = "GdprSettingsPage.HideCommonBlock";
    var hideCommonBlock = await genericAttributeService.GetAttributeAsync<bool>(await workContext.GetCurrentCustomerAsync(), hideCommonBlockAttributeName);

    const string hideConsentsBlockAttributeName = "GdprSettingsPage.HideConsentsBlock";
    var hideConsentsBlock = await genericAttributeService.GetAttributeAsync<bool>(await workContext.GetCurrentCustomerAsync(), hideConsentsBlockAttributeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd89a809d5042c9132a6b13f7cc1a972e420316f17693", async() => {
                WriteLiteral("\r\n    <div class=\"content-header clearfix\">\r\n        <h1 class=\"float-left\">\r\n            ");
#nullable restore
#line 22 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/Setting/Gdpr.cshtml"
       Write(T("Admin.Configuration.Settings.GDPR"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </h1>\r\n        <div class=\"float-right\">\r\n            <button type=\"submit\" name=\"save\" class=\"btn btn-primary\">\r\n                <i class=\"far fa-save\"></i>\r\n                ");
#nullable restore
#line 27 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/Setting/Gdpr.cshtml"
           Write(T("Admin.Common.Save"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </button>\r\n            ");
#nullable restore
#line 29 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/Setting/Gdpr.cshtml"
       Write(await Component.InvokeAsync("AdminWidget", new { widgetZone = AdminWidgetZones.GdprSettingsButtons }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <section class=\"content\">\r\n        <div class=\"container-fluid\">\r\n            <div class=\"form-horizontal\">\r\n                ");
#nullable restore
#line 36 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/Setting/Gdpr.cshtml"
           Write(await Component.InvokeAsync("StoreScopeConfiguration"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 37 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/Setting/Gdpr.cshtml"
           Write(await Component.InvokeAsync("SettingMode"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd89a809d5042c9132a6b13f7cc1a972e420316f19842", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 38 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/Setting/Gdpr.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-cards", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd89a809d5042c9132a6b13f7cc1a972e420316f21423", async() => {
                    WriteLiteral("\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-card", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd89a809d5042c9132a6b13f7cc1a972e420316f21713", async() => {
#nullable restore
#line 41 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/Setting/Gdpr.cshtml"
                                                                                                                                                                                                                                                                    Write(await Html.PartialAsync("_Gdpr.Common", Model));

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopCardTagHelper>();
                    __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper);
                    __Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper.CardIconIsAdvanced = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/Setting/Gdpr.cshtml"
                                                                                   WriteLiteral(T("Admin.Configuration.Settings.Gdpr.BlockTitle.Common"));

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper.Title = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-title", __Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper.Title, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/Setting/Gdpr.cshtml"
                                                                                                                                                                             WriteLiteral(hideCommonBlockAttributeName);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper.HideBlockAttributeName = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-hide-block-attribute-name", __Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper.HideBlockAttributeName, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 41 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/Setting/Gdpr.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper.IsHide = hideCommonBlock;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-hide", __Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper.IsHide, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 41 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/Setting/Gdpr.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper.IsAdvanced = false;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-advanced", __Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper.IsAdvanced, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-card", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd89a809d5042c9132a6b13f7cc1a972e420316f26305", async() => {
#nullable restore
#line 42 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/Setting/Gdpr.cshtml"
                                                                                                                                                                                                                                                                                  Write(await Html.PartialAsync("_Gdpr.Consents", Model));

#line default
#line hidden
#nullable disable
                    }
                    );
                    __Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopCardTagHelper>();
                    __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper);
                    __Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper.CardIconIsAdvanced = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/Setting/Gdpr.cshtml"
                                                                                            WriteLiteral(T("Admin.Configuration.Settings.Gdpr.BlockTitle.Consents"));

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper.Title = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-title", __Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper.Title, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/Setting/Gdpr.cshtml"
                                                                                                                                                                                        WriteLiteral(hideConsentsBlockAttributeName);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper.HideBlockAttributeName = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-hide-block-attribute-name", __Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper.HideBlockAttributeName, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 42 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/Setting/Gdpr.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper.IsHide = hideConsentsBlock;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-hide", __Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper.IsHide, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 42 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/Setting/Gdpr.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper.IsAdvanced = true;

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-advanced", __Nop_Web_Framework_TagHelpers_Admin_NopCardTagHelper.IsAdvanced, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n\r\n                    ");
#nullable restore
#line 44 "/Volumes/Data/venusshop/src/Presentation/Nop.Web/Areas/Admin/Views/Setting/Gdpr.cshtml"
               Write(await Component.InvokeAsync("AdminWidget", new { widgetZone = AdminWidgetZones.GdprSettingsDetailsBlock, additionalData = Model }));

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                ");
                }
                );
                __Nop_Web_Framework_TagHelpers_Admin_NopCardsTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopCardsTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopCardsTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWorkContext workContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IGenericAttributeService genericAttributeService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GdprSettingsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
