#pragma checksum "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Pizza\PizzaDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "089b428439f6c333d4884628f3e44d3e4ddd132f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_PizzaDetails), @"mvc.1.0.view", @"/Views/Pizza/PizzaDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pizza/PizzaDetails.cshtml", typeof(AspNetCore.Views_Pizza_PizzaDetails))]
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
#line 1 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\_ViewImports.cshtml"
using PizzaApp;

#line default
#line hidden
#line 2 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\_ViewImports.cshtml"
using PizzaApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"089b428439f6c333d4884628f3e44d3e4ddd132f", @"/Views/Pizza/PizzaDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc15dd9ac112cec217320a8152f12002a6eb2028", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_PizzaDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaApp.Models.ViewModels.PizzaVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Pizza\PizzaDetails.cshtml"
  
    ViewData["Title"] = "PizzaDetails";

#line default
#line hidden
            BeginContext(93, 105, true);
            WriteLiteral("\r\n<h2>Pizza Details</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(199, 40, false);
#line 13 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Pizza\PizzaDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(239, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(283, 36, false);
#line 16 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Pizza\PizzaDetails.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(319, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(363, 40, false);
#line 19 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Pizza\PizzaDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(403, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(447, 36, false);
#line 22 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Pizza\PizzaDetails.cshtml"
       Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(483, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(527, 47, false);
#line 25 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Pizza\PizzaDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Ingredients));

#line default
#line hidden
            EndContext();
            BeginContext(574, 31, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 28 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Pizza\PizzaDetails.cshtml"
             foreach (var ingredient in Model.Ingredients)
            {
                if (Model.Ingredients[Model.Ingredients.Count - 1] == ingredient)
                {

#line default
#line hidden
            BeginContext(782, 25, true);
            WriteLiteral("                    <div>");
            EndContext();
            BeginContext(808, 10, false);
#line 32 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Pizza\PizzaDetails.cshtml"
                    Write(ingredient);

#line default
#line hidden
            EndContext();
            BeginContext(818, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 33 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Pizza\PizzaDetails.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(886, 25, true);
            WriteLiteral("                    <div>");
            EndContext();
            BeginContext(912, 10, false);
#line 36 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Pizza\PizzaDetails.cshtml"
                    Write(ingredient);

#line default
#line hidden
            EndContext();
            BeginContext(922, 9, true);
            WriteLiteral(",</div>\r\n");
            EndContext();
#line 37 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Pizza\PizzaDetails.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(965, 41, true);
            WriteLiteral("        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1007, 41, false);
#line 41 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Pizza\PizzaDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1092, 37, false);
#line 44 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Pizza\PizzaDetails.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1129, 48, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div> \r\n    ");
            EndContext();
            BeginContext(1177, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5674510b555e4cbd9ee31f1d7ef64e10", async() => {
                BeginContext(1199, 12, true);
                WriteLiteral("Back to List");
                EndContext();
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
            EndContext();
            BeginContext(1215, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaApp.Models.ViewModels.PizzaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
