#pragma checksum "E:\IDB-BISEW\NEW PROJECT\ASP.NET Core\OnlineNewspaper\OnlineNewspaper\Views\NewsDetails\ManageNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7c526ee9f9a66fe5fff470094731b9e571ba87f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewsDetails_ManageNews), @"mvc.1.0.view", @"/Views/NewsDetails/ManageNews.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NewsDetails/ManageNews.cshtml", typeof(AspNetCore.Views_NewsDetails_ManageNews))]
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
#line 1 "E:\IDB-BISEW\NEW PROJECT\ASP.NET Core\OnlineNewspaper\OnlineNewspaper\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "E:\IDB-BISEW\NEW PROJECT\ASP.NET Core\OnlineNewspaper\OnlineNewspaper\Views\_ViewImports.cshtml"
using OnlineNewspaper;

#line default
#line hidden
#line 3 "E:\IDB-BISEW\NEW PROJECT\ASP.NET Core\OnlineNewspaper\OnlineNewspaper\Views\_ViewImports.cshtml"
using OnlineNewspaper.Models;

#line default
#line hidden
#line 4 "E:\IDB-BISEW\NEW PROJECT\ASP.NET Core\OnlineNewspaper\OnlineNewspaper\Views\_ViewImports.cshtml"
using OnlineNewspaper.Models.AccountViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7c526ee9f9a66fe5fff470094731b9e571ba87f", @"/Views/NewsDetails/ManageNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f21e94b023ed79c46a80081b643422dd49081ba", @"/Views/_ViewImports.cshtml")]
    public class Views_NewsDetails_ManageNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineNewspaper.Models.NewsDetails>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\IDB-BISEW\NEW PROJECT\ASP.NET Core\OnlineNewspaper\OnlineNewspaper\Views\NewsDetails\ManageNews.cshtml"
  
    ViewData["Title"] = "ManageNews";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(156, 118, true);
            WriteLiteral("\r\n<h1>সংবাদ ম্যানেজ  করুন</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(275, 41, false);
#line 14 "E:\IDB-BISEW\NEW PROJECT\ASP.NET Core\OnlineNewspaper\OnlineNewspaper\Views\NewsDetails\ManageNews.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(316, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(372, 44, false);
#line 17 "E:\IDB-BISEW\NEW PROJECT\ASP.NET Core\OnlineNewspaper\OnlineNewspaper\Views\NewsDetails\ManageNews.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsBody));

#line default
#line hidden
            EndContext();
            BeginContext(416, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(472, 41, false);
#line 20 "E:\IDB-BISEW\NEW PROJECT\ASP.NET Core\OnlineNewspaper\OnlineNewspaper\Views\NewsDetails\ManageNews.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(513, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(569, 48, false);
#line 23 "E:\IDB-BISEW\NEW PROJECT\ASP.NET Core\OnlineNewspaper\OnlineNewspaper\Views\NewsDetails\ManageNews.cshtml"
           Write(Html.DisplayNameFor(model => model.NewsCategory));

#line default
#line hidden
            EndContext();
            BeginContext(617, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 29 "E:\IDB-BISEW\NEW PROJECT\ASP.NET Core\OnlineNewspaper\OnlineNewspaper\Views\NewsDetails\ManageNews.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(735, 66, true);
            WriteLiteral("        <tr>\r\n            <td style=\"width:15%\">\r\n                ");
            EndContext();
            BeginContext(802, 40, false);
#line 32 "E:\IDB-BISEW\NEW PROJECT\ASP.NET Core\OnlineNewspaper\OnlineNewspaper\Views\NewsDetails\ManageNews.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(842, 223, true);
            WriteLiteral("\r\n            </td>\r\n            <td style=\"width:35%\">\r\n                <p style=\"overflow: hidden; text-overflow: ellipsis; display: -webkit-box; -webkit-line-clamp: 2;-webkit-box-orient: vertical;\">\r\n                    ");
            EndContext();
            BeginContext(1066, 43, false);
#line 36 "E:\IDB-BISEW\NEW PROJECT\ASP.NET Core\OnlineNewspaper\OnlineNewspaper\Views\NewsDetails\ManageNews.cshtml"
               Write(Html.DisplayFor(modelItem => item.NewsBody));

#line default
#line hidden
            EndContext();
            BeginContext(1109, 95, true);
            WriteLiteral("\r\n                </p>\r\n            </td>\r\n            <td style=\"width:20%\">\r\n                ");
            EndContext();
            BeginContext(1205, 40, false);
#line 40 "E:\IDB-BISEW\NEW PROJECT\ASP.NET Core\OnlineNewspaper\OnlineNewspaper\Views\NewsDetails\ManageNews.cshtml"
           Write(Html.DisplayFor(modelItem => item.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1245, 72, true);
            WriteLiteral("\r\n            </td>\r\n            <td style=\"width:5%\">\r\n                ");
            EndContext();
            BeginContext(1318, 62, false);
#line 43 "E:\IDB-BISEW\NEW PROJECT\ASP.NET Core\OnlineNewspaper\OnlineNewspaper\Views\NewsDetails\ManageNews.cshtml"
           Write(Html.DisplayFor(modelItem => item.NewsCategory.NewsCategoryID));

#line default
#line hidden
            EndContext();
            BeginContext(1380, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1435, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7c526ee9f9a66fe5fff470094731b9e571ba87f10050", async() => {
                BeginContext(1533, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "E:\IDB-BISEW\NEW PROJECT\ASP.NET Core\OnlineNewspaper\OnlineNewspaper\Views\NewsDetails\ManageNews.cshtml"
                                                                                 WriteLiteral(item.NewsDetailsID);

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
            BeginContext(1541, 19, true);
            WriteLiteral(" \r\n                ");
            EndContext();
            BeginContext(1560, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7c526ee9f9a66fe5fff470094731b9e571ba87f12641", async() => {
                BeginContext(1658, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "E:\IDB-BISEW\NEW PROJECT\ASP.NET Core\OnlineNewspaper\OnlineNewspaper\Views\NewsDetails\ManageNews.cshtml"
                                                                                 WriteLiteral(item.NewsDetailsID);

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
            BeginContext(1668, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 50 "E:\IDB-BISEW\NEW PROJECT\ASP.NET Core\OnlineNewspaper\OnlineNewspaper\Views\NewsDetails\ManageNews.cshtml"
}

#line default
#line hidden
            BeginContext(1707, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineNewspaper.Models.NewsDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591