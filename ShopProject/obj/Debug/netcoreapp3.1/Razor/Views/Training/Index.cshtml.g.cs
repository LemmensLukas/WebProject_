#pragma checksum "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\Training\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7af7e68050986a2925546ac20b05a0b1d75b83b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Training_Index), @"mvc.1.0.view", @"/Views/Training/Index.cshtml")]
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
#line 1 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\_ViewImports.cshtml"
using ShopProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\_ViewImports.cshtml"
using ShopProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7af7e68050986a2925546ac20b05a0b1d75b83b8", @"/Views/Training/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ab9dd8f6a7b5e92355807c4f7c958220aa37b51", @"/Views/_ViewImports.cshtml")]
    public class Views_Training_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopProject.ViewModel.TrainingListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/TrainingPageFoto.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:32rem; height:18rem;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\Training\Index.cshtml"
  
    ViewData["Title"] = "Trainingen";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container bg-white justify-content-center font-italic\">\r\n    <div class=\"row mt-5\">\r\n        <div class=\"col\">\r\n            <div class=\"text-center text-dark font-italic font-weight-bold\" style=\"font-size: 20px\">\r\n                <p");
            BeginWriteAttribute("class", " class=\"", 346, "\"", 354, 0);
            EndWriteAttribute();
            WriteLiteral(@">Geïnteresseerd in badmitonnen bij onze badmintonclub?</p>
                Hieronder kan u alle informatie vinden rond de trainingsagenda.
            </div>
        </div>
    </div>

    <h2 class=""text-center mt-4"">Vaste Trainingen</h2>

    <p class=""text-center"">
");
#nullable restore
#line 20 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\Training\Index.cshtml"
         if (this.User.IsInRole("Admin"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7af7e68050986a2925546ac20b05a0b1d75b83b86923", async() => {
                WriteLiteral("Create New Training");
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
            WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\Training\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </p>\r\n    <table class=\"mb-5\">\r\n        <thead>\r\n            <tr>\r\n");
            WriteLiteral("                <th class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 33 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\Training\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Trainingen[0].Datum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 36 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\Training\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Trainingen[0].TrainingsDuur));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 39 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\Training\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Trainingen[0].Locatie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"col-md-4\">\r\n                    ");
#nullable restore
#line 42 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\Training\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Trainingen[0].AantalBeschikbareVelden));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody class=\"justify-content-center\">\r\n");
#nullable restore
#line 47 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\Training\Index.cshtml"
             foreach (var item in Model.Trainingen)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
            WriteLiteral("                    <td class=\"col-md-4\">\r\n                        ");
#nullable restore
#line 54 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\Training\Index.cshtml"
                   Write(item.Datum);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"col-md-4\">\r\n                        ");
#nullable restore
#line 57 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\Training\Index.cshtml"
                   Write(item.TrainingsDuur);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"col-md-4\">\r\n                        ");
#nullable restore
#line 60 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\Training\Index.cshtml"
                   Write(item.Locatie);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"col-md-4 text-center\">\r\n                        ");
#nullable restore
#line 63 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\Training\Index.cshtml"
                   Write(item.AantalBeschikbareVelden);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"col-md-4\">\r\n");
#nullable restore
#line 66 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\Training\Index.cshtml"
                         if (this.User.IsInRole("Admin"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7af7e68050986a2925546ac20b05a0b1d75b83b812418", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\Training\Index.cshtml"
                                                   WriteLiteral(item.ID);

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
            WriteLiteral("\r\n");
#nullable restore
#line 69 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\Training\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td class=\"col-md-4\">\r\n");
#nullable restore
#line 73 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\Training\Index.cshtml"
                         if (this.User.IsInRole("Admin"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7af7e68050986a2925546ac20b05a0b1d75b83b815286", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\Training\Index.cshtml"
                                                     WriteLiteral(item.ID);

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
            WriteLiteral("\r\n");
#nullable restore
#line 76 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\Training\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 80 "C:\Users\Lukas\Documents\vakken school 2de jaar\WebApplicaties\ShopProject\ShopProject\Views\Training\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>

    <div class=""row mt-5"">
        <div class=""col"">
            <div class=""text-center text-dark font-italic ml-5 mr-5"" style=""font-size: 20px"">
                <p class=""font-weight-bold"">Nieuwkomer?</p>
                Ben je nog geen lid bij onze club?
                Weet u niet zeker of badminton iets voor jou is?
                Bij ons kan u twee keer een gratis training volgen.
                Hierdoor kan u al eens kennismaken met onze leden en trainers?
                Wilt u na deze twee traningen nog altijd lid worden dan kan dat bij een van onze trainers!
            </div>
        </div>
    </div>

    <div class=""row text-center mt-5 bg-white"">
        <div class=""col mt-2"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7af7e68050986a2925546ac20b05a0b1d75b83b818817", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col mt-2\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7af7e68050986a2925546ac20b05a0b1d75b83b820164", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"col bg-white mt-5 mb-5\">\r\n        <div class=\"row\"></div>\r\n    </div>\r\n</div>\r\n    \r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopProject.ViewModel.TrainingListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
