#pragma checksum "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Shared\_PizzaCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8b2ecea92db48f0a3fa9e61f5917c90d8691378"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PizzaCard), @"mvc.1.0.view", @"/Views/Shared/_PizzaCard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PizzaCard.cshtml", typeof(AspNetCore.Views_Shared__PizzaCard))]
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
#line 3 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\_ViewImports.cshtml"
using PizzaApp.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8b2ecea92db48f0a3fa9e61f5917c90d8691378", @"/Views/Shared/_PizzaCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cc5019f45d343a09d5d2644a5f206a0e1a412f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PizzaCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Shared\_PizzaCard.cshtml"
  
    ViewData["Title"] = "_PizzaCard";

#line default
#line hidden
            BeginContext(62, 50, true);
            WriteLiteral("<div class=\"card\" style=\"width: 18rem;\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 112, "", 130, 1);
#line 6 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Shared\_PizzaCard.cshtml"
WriteAttributeValue("", 117, Model.ImgUrl, 117, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(130, 119, true);
            WriteLiteral(" width=\"180\" height=\"135\" class=\"card-img-top\" alt=\"...\">\r\n    <div class=\"card-body\">\r\n        <h3 class=\"card-title\">");
            EndContext();
            BeginContext(250, 28, false);
#line 8 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Shared\_PizzaCard.cshtml"
                          Write(Html.DisplayFor(p => p.Name));

#line default
#line hidden
            EndContext();
            BeginContext(278, 44, true);
            WriteLiteral("</h3><hr />\r\n        <div class=\"card-text\">");
            EndContext();
            BeginContext(323, 26, false);
#line 9 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Shared\_PizzaCard.cshtml"
                          Write(Html.LabelFor(p => p.Size));

#line default
#line hidden
            EndContext();
            BeginContext(349, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(351, 28, false);
#line 9 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Shared\_PizzaCard.cshtml"
                                                      Write(Html.DisplayFor(p => p.Size));

#line default
#line hidden
            EndContext();
            BeginContext(379, 46, true);
            WriteLiteral("</div><hr />\r\n        <div class=\"card-text\"> ");
            EndContext();
            BeginContext(426, 27, false);
#line 10 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Shared\_PizzaCard.cshtml"
                           Write(Html.LabelFor(p => p.Price));

#line default
#line hidden
            EndContext();
            BeginContext(453, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(455, 29, false);
#line 10 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Shared\_PizzaCard.cshtml"
                                                        Write(Html.DisplayFor(p => p.Price));

#line default
#line hidden
            EndContext();
            BeginContext(484, 59, true);
            WriteLiteral("</div><hr />\r\n        <div class=\"card-text\">\r\n            ");
            EndContext();
            BeginContext(544, 33, false);
#line 12 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Shared\_PizzaCard.cshtml"
       Write(Html.LabelFor(p => p.Ingredients));

#line default
#line hidden
            EndContext();
            BeginContext(577, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Shared\_PizzaCard.cshtml"
             foreach (var ingredient in Model.Ingredients)
            {
                if (Model.Ingredients[Model.Ingredients.Count - 1] == ingredient)
                {

#line default
#line hidden
            BeginContext(756, 25, true);
            WriteLiteral("                    <div>");
            EndContext();
            BeginContext(782, 10, false);
#line 17 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Shared\_PizzaCard.cshtml"
                    Write(ingredient);

#line default
#line hidden
            EndContext();
            BeginContext(792, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 18 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Shared\_PizzaCard.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(860, 25, true);
            WriteLiteral("                    <div>");
            EndContext();
            BeginContext(886, 10, false);
#line 21 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Shared\_PizzaCard.cshtml"
                    Write(ingredient);

#line default
#line hidden
            EndContext();
            BeginContext(896, 9, true);
            WriteLiteral(",</div>\r\n");
            EndContext();
#line 22 "D:\WEB DEVELOPER\SEDC Code Academy\8. MVC\HOMEWORK\MVC\PizzaApp\PizzaApp\Views\Shared\_PizzaCard.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(939, 61, true);
            WriteLiteral("        </div>\r\n        <div class=\"btn-align\">\r\n            ");
            EndContext();
            BeginContext(1000, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48020f1ae585425a863ec6fa6f0e9324", async() => {
                BeginContext(1071, 11, true);
                WriteLiteral("Order Pizza");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(",", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1086, 375, true);
            WriteLiteral(@"
        </div>
    </div>
</div>
<style>
    .card {
        background-color: rgba(233, 241, 242, 0.4);
    }
    .card-title {
        text-align: center;
        color: #abc6c9;
    }
    .btn-align {
        text-align: center;
        padding-top: 10px;
        padding-bottom: 10px;
    }
    .card-text{
        margin-left: 30px;
    }
</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
