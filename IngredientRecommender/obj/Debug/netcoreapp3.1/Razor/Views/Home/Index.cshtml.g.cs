#pragma checksum "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "850e269f77026a87ff8cbcb0d1b9b4304cb9459f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"850e269f77026a87ff8cbcb0d1b9b4304cb9459f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1109c3dc7473b4dc323b5a22f7f9982e680073c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DisplayViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddIngredient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    int maxDisplay = 20;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "850e269f77026a87ff8cbcb0d1b9b4304cb9459f5945", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <style type=\"text/css\">\r\n    </style>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "850e269f77026a87ff8cbcb0d1b9b4304cb9459f7044", async() => {
                WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h3 class=\"display-4 text-white ingr-justify\">Build Your Recipe</h3>\r\n        <p class=\"text-white ingr-justify\">Get recommendations for which ingredients to add to or remove from your recipe.</p>\r\n\r\n");
                WriteLiteral("        <br />\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "850e269f77026a87ff8cbcb0d1b9b4304cb9459f7616", async() => {
                    WriteLiteral("\r\n            <input class=\"input\" name=\"IngredientName\" />\r\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "850e269f77026a87ff8cbcb0d1b9b4304cb9459f7959", async() => {
                        WriteLiteral("Add");
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
                    WriteLiteral("\r\n        ");
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
                WriteLiteral("\r\n        <br />\r\n        <br />\r\n\r\n");
#nullable restore
#line 28 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
         if (Model.mine.MyRecipe.Ingredients.Count > 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h2 class=\"ingr-justify text-white display-4\" style=\"font-size: 40px;\">\r\n                My Ingredients\r\n                <br />\r\n            </h2>\r\n");
                WriteLiteral("            <div class=\"ingr-justify\">\r\n");
#nullable restore
#line 36 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                     foreach (IngredientModel Ingredient in Model.mine.MyRecipe.Ingredients)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button name=\"IngredientName\" type=\"submit\" class=\"btn btn-ingr\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1377, "\"", 1484, 3);
                WriteAttributeValue("", 1387, "location.href=\'", 1387, 15, true);
#nullable restore
#line 38 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
WriteAttributeValue("", 1402, Url.Action("RemoveIngredient", "Home", new { IngredientName = Ingredient.Name }), 1402, 81, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1483, "\'", 1483, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            ");
#nullable restore
#line 39 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(model => Ingredient.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </button>\r\n");
#nullable restore
#line 41 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n            <button type=\"submit\" class=\"btn btn-dark\" style=\"margin-top: 10px; margin-bottom: 20px;\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1739, "\"", 1797, 3);
                WriteAttributeValue("", 1749, "location.href=\'", 1749, 15, true);
#nullable restore
#line 43 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
WriteAttributeValue("", 1764, Url.Action("ResetMine", "Home"), 1764, 32, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1796, "\'", 1796, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                Clear\r\n            </button>\r\n            <br />\r\n");
#nullable restore
#line 47 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
        }

        

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col\">\r\n");
                WriteLiteral("                <h1 class=\"ingr-justify text-white display-4\" style=\"font-size: 40px;\">Recommendations</h1>\r\n                <div class=\"ingr-justify\">\r\n");
#nullable restore
#line 55 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                     if (Model != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                         for (int i = 0; i < maxDisplay; i++)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <button name=\"IngredientName\" type=\"submit\" class=\"btn btn-dark btn-ingr\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2449, "\"", 2583, 3);
                WriteAttributeValue("", 2459, "location.href=\'", 2459, 15, true);
#nullable restore
#line 59 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
WriteAttributeValue("", 2474, Url.Action("AddIngredient", "Home", new { IngredientName = Model.mine.Recommendations[i].Ingredient.Name }), 2474, 108, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2582, "\'", 2582, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                ");
#nullable restore
#line 60 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(model => Model.mine.Recommendations[i].Ingredient.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </button>\r\n");
#nullable restore
#line 62 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 66 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
             if (Model.mine.MyRecipe.Ingredients.Count > 0 || Model.search.RecipeChoice.Ingredients.Count > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                 if (Model != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                     if (Model.mine.MyRecipe.Ingredients.Count > 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""col"">
                            <h1 class=""ingr-justify text-white display-4"" style=""font-size: 40px;"">
                                Similar Recipe
                            </h1>
                            <p class=""text-white ingr-justify"">");
#nullable restore
#line 77 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                                                          Write(Model.mine.SimilarRecipe.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <div class=\"ingr-justify\">\r\n");
#nullable restore
#line 79 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                                 if (Model != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                                     foreach (IngredientModel Ingredient in Model.mine.SimilarRecipe.Ingredients)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <button name=\"IngredientName\" type=\"submit\" class=\"btn btn-ingr\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3888, "\"", 3992, 3);
                WriteAttributeValue("", 3898, "location.href=\'", 3898, 15, true);
#nullable restore
#line 83 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
WriteAttributeValue("", 3913, Url.Action("AddIngredient", "Home", new { IngredientName = Ingredient.Name }), 3913, 78, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3991, "\'", 3991, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            ");
#nullable restore
#line 84 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                                       Write(Html.DisplayFor(model => Ingredient.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </button>\r\n");
#nullable restore
#line 86 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n                            <br />\r\n                        </div>\r\n");
#nullable restore
#line 91 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                     if (Model.search.RecipeChoice.Ingredients.Count > 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"col\">\r\n            <h5 class=\"ingr-justify text-white display-4\" style=\"font-size: 40px;\">\r\n                Search Recipe\r\n            </h5>\r\n            <div class=\"ingr-justify\">\r\n");
#nullable restore
#line 99 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                 if (Model != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                     foreach (IngredientModel Ingredient in Model.search.RecipeChoice.Ingredients)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button name=\"IngredientName\" type=\"submit\" class=\"btn btn-ingr\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4903, "\"", 5007, 3);
                WriteAttributeValue("", 4913, "location.href=\'", 4913, 15, true);
#nullable restore
#line 103 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
WriteAttributeValue("", 4928, Url.Action("AddIngredient", "Home", new { IngredientName = Ingredient.Name }), 4928, 78, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5006, "\'", 5006, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            ");
#nullable restore
#line 104 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(model => Ingredient.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </button>\r\n");
#nullable restore
#line 106 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n            <button type=\"submit\" class=\"btn btn-dark\" style=\"margin-top: 10px;\"");
                BeginWriteAttribute("onclick", " onclick=\"", 5260, "\"", 5320, 3);
                WriteAttributeValue("", 5270, "location.href=\'", 5270, 15, true);
#nullable restore
#line 109 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
WriteAttributeValue("", 5285, Url.Action("ResetSearch", "Home"), 5285, 34, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5319, "\'", 5319, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                Clear\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 113 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n\r\n    </div>\r\n");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DisplayViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
