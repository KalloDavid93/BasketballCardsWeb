#pragma checksum "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6428cc1ac1f1e250aa43d12b93a11c6fd84a055"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BasketBallCardTrackerWeb.Pages.Pages_Cards), @"mvc.1.0.razor-page", @"/Pages/Cards.cshtml")]
namespace BasketBallCardTrackerWeb.Pages
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
#line 1 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\_ViewImports.cshtml"
using BasketBallCardTrackerWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\_ViewImports.cshtml"
using BasketBallCardTrackerWeb.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6428cc1ac1f1e250aa43d12b93a11c6fd84a055", @"/Pages/Cards.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6f69ceec3290825624fb76e098c79d41545a71e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cards : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
  
    ViewData["Title"] = "Cards";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Cards</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6428cc1ac1f1e250aa43d12b93a11c6fd84a0555002", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayNameFor(model => model.Card[0].CollectionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayNameFor(model => model.Card[0].Season));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayNameFor(model => model.Card[0].Box));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayNameFor(model => model.Card[0].Insert));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayNameFor(model => model.Card[0].Player));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayNameFor(model => model.Card[0].Serial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayNameFor(model => model.Card[0].Parallel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayNameFor(model => model.Card[0].NumberedTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayNameFor(model => model.Card[0].ActualNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayNameFor(model => model.Card[0].Seller));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayNameFor(model => model.Card[0].Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayNameFor(model => model.Card[0].IMGUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 56 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
 foreach (var item in Model.Card) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayFor(modelItem => item.CollectionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayFor(modelItem => item.Season));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayFor(modelItem => item.Box));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayFor(modelItem => item.Insert));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayFor(modelItem => item.Player));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayFor(modelItem => item.Serial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayFor(modelItem => item.Parallel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumberedTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayFor(modelItem => item.ActualNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 86 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayFor(modelItem => item.Seller));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 89 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 92 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
           Write(Html.DisplayFor(modelItem => item.IMGUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6428cc1ac1f1e250aa43d12b93a11c6fd84a05515331", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
                                       WriteLiteral(item.CardId);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6428cc1ac1f1e250aa43d12b93a11c6fd84a05517541", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
                                          WriteLiteral(item.CardId);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6428cc1ac1f1e250aa43d12b93a11c6fd84a05519757", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
                                         WriteLiteral(item.CardId);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 100 "C:\Codecool\jobhunt\BasketBallWeb\BasketballCardsWeb\BasketBallCardTrackerWeb\BasketBallCardTrackerWeb\Pages\Cards.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasketBallCardTrackerWeb.Pages.CardsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BasketBallCardTrackerWeb.Pages.CardsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BasketBallCardTrackerWeb.Pages.CardsModel>)PageContext?.ViewData;
        public BasketBallCardTrackerWeb.Pages.CardsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591