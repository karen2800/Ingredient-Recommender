#pragma checksum "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\FindRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de2e9c113ef2144f959d0a884c939aeb3f9b301b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FindRecipe), @"mvc.1.0.view", @"/Views/Home/FindRecipe.cshtml")]
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
#line 1 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\_ViewImports.cshtml"
using IngredientRecommender;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\_ViewImports.cshtml"
using IngredientRecommender.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de2e9c113ef2144f959d0a884c939aeb3f9b301b", @"/Views/Home/FindRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1109c3dc7473b4dc323b5a22f7f9982e680073c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FindRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchRecipes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("background"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\FindRecipe.cshtml"
  
    ViewData["Title"] = "Find Recipe";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de2e9c113ef2144f959d0a884c939aeb3f9b301b5959", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de2e9c113ef2144f959d0a884c939aeb3f9b301b6933", async() => {
                WriteLiteral("\r\n    <div class=\"text-center\">\r\n");
#nullable restore
#line 12 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\FindRecipe.cshtml"
         if (Model != null)
        {
            if (Model.Index == -1)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h1 class=\"display-4\">Find a Recipe</h1>\r\n");
                WriteLiteral("                <h3>Type in an ingredient</h3>\r\n                <br />\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de2e9c113ef2144f959d0a884c939aeb3f9b301b7731", async() => {
                    WriteLiteral("\r\n                    <input class=\"input\" name=\"IngredientName\" />\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de2e9c113ef2144f959d0a884c939aeb3f9b301b8090", async() => {
                        WriteLiteral("Find Recipe");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <br />\r\n");
#nullable restore
#line 26 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\FindRecipe.cshtml"

                for (int i = 0; i < Model.Recipes.Count && i < 20; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <h5 type=\"submit\"");
                BeginWriteAttribute("onclick", " onclick=\"", 901, "\"", 982, 3);
                WriteAttributeValue("", 911, "location.href=\'", 911, 15, true);
#nullable restore
#line 29 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\FindRecipe.cshtml"
WriteAttributeValue("", 926, Url.Action("DisplayRecipe", "Home", new { Index = i }), 926, 55, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 981, "\'", 981, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        ");
#nullable restore
#line 30 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\FindRecipe.cshtml"
                   Write(Html.DisplayFor(model => Model.Recipes[i].Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </h5>\r\n");
#nullable restore
#line 32 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\FindRecipe.cshtml"
                }
            }

            else
            {
                

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h1 class=\"display-4\">");
#nullable restore
#line 38 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\FindRecipe.cshtml"
                                 Write(Model.Recipes[Model.Index].Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(": ");
#nullable restore
#line 38 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\FindRecipe.cshtml"
                                                                    Write(Model.Recipes[Model.Index].Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n                <br />\r\n");
                WriteLiteral("                <button class=\"btn btn-dark\" type=\"submit\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1395, "\"", 1453, 3);
                WriteAttributeValue("", 1405, "location.href=\'", 1405, 15, true);
#nullable restore
#line 41 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\FindRecipe.cshtml"
WriteAttributeValue("", 1420, Url.Action("SeeTitles", "Home"), 1420, 32, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1452, "\'", 1452, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    Back\r\n                </button>\r\n                <br />\r\n");
#nullable restore
#line 46 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\FindRecipe.cshtml"
                 foreach (IngredientModel Ingredient in Model.Recipes[Model.Index].Ingredients)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <br />\r\n                    <button class=\"btn btn-light btn-ingr\" type=\"submit\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1752, "\"", 1856, 3);
                WriteAttributeValue("", 1762, "location.href=\'", 1762, 15, true);
#nullable restore
#line 49 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\FindRecipe.cshtml"
WriteAttributeValue("", 1777, Url.Action("AddIngredient", "Home", new { IngredientName = Ingredient.Name }), 1777, 78, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1855, "\'", 1855, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        ");
#nullable restore
#line 50 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\FindRecipe.cshtml"
                   Write(Ingredient.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </button>\r\n");
#nullable restore
#line 52 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\FindRecipe.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\FindRecipe.cshtml"
                 
            }
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
