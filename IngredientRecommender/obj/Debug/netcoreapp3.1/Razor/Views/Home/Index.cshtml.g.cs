#pragma checksum "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddbda7397cf8e16f5bf74ad140bcf3dbb29282b2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddbda7397cf8e16f5bf74ad140bcf3dbb29282b2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1109c3dc7473b4dc323b5a22f7f9982e680073c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DisplayViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddbda7397cf8e16f5bf74ad140bcf3dbb29282b25953", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddbda7397cf8e16f5bf74ad140bcf3dbb29282b27052", async() => {
                WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h3 class=\"display-4\">Build Your Recipe</h3>\r\n        <p>Get recommendations for which ingredients to add to or remove from your recipe.</p>\r\n\r\n");
                WriteLiteral("        <br />\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddbda7397cf8e16f5bf74ad140bcf3dbb29282b27566", async() => {
                    WriteLiteral("\r\n            <input class=\"input\" name=\"IngredientName\" />\r\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddbda7397cf8e16f5bf74ad140bcf3dbb29282b27909", async() => {
                        WriteLiteral("Add Ingredient to Your Recipe");
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
                WriteLiteral("            <h5 class=\"ingr-justify\">\r\n                My Recipe\r\n                <br />\r\n            </h5>\r\n");
                WriteLiteral("            <div class=\"ingr-justify\">\r\n");
#nullable restore
#line 36 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                     foreach (IngredientModel Ingredient in Model.mine.MyRecipe.Ingredients)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button name=\"IngredientName\" type=\"submit\" class=\"btn btn-ingr\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1304, "\"", 1411, 3);
                WriteAttributeValue("", 1314, "location.href=\'", 1314, 15, true);
#nullable restore
#line 38 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
WriteAttributeValue("", 1329, Url.Action("RemoveIngredient", "Home", new { IngredientName = Ingredient.Name }), 1329, 81, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1410, "\'", 1410, 1, true);
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
                WriteLiteral("            </div>\r\n            <button type=\"submit\" class=\"btn btn-outline-dark\" style=\"margin-top: 10px; margin-bottom: 20px;\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1674, "\"", 1732, 3);
                WriteAttributeValue("", 1684, "location.href=\'", 1684, 15, true);
#nullable restore
#line 43 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
WriteAttributeValue("", 1699, Url.Action("ResetMine", "Home"), 1699, 32, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1731, "\'", 1731, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                Clear\r\n            </button>\r\n            <br />\r\n");
#nullable restore
#line 47 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
        }

        

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col\">\r\n");
                WriteLiteral("                <h5 class=\"ingr-justify\">Recommendations</h5>\r\n                <div class=\"ingr-justify\">\r\n");
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
                WriteLiteral("                            <button name=\"IngredientName\" type=\"submit\" class=\"btn btn-ingr\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2329, "\"", 2463, 3);
                WriteAttributeValue("", 2339, "location.href=\'", 2339, 15, true);
#nullable restore
#line 59 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
WriteAttributeValue("", 2354, Url.Action("AddIngredient", "Home", new { IngredientName = Model.mine.Recommendations[i].Ingredient.Name }), 2354, 108, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2462, "\'", 2462, 1, true);
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
                WriteLiteral("                        <div class=\"col\">\r\n                            <h5 class=\"ingr-justify\">\r\n                                Similar Recipe: ");
#nullable restore
#line 75 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                                           Write(Model.mine.SimilarRecipe.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <br />\r\n                            </h5>\r\n                            <div class=\"ingr-justify\">\r\n");
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
                BeginWriteAttribute("onclick", " onclick=\"", 3694, "\"", 3798, 3);
                WriteAttributeValue("", 3704, "location.href=\'", 3704, 15, true);
#nullable restore
#line 83 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
WriteAttributeValue("", 3719, Url.Action("AddIngredient", "Home", new { IngredientName = Ingredient.Name }), 3719, 78, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3797, "\'", 3797, 1, true);
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
                WriteLiteral("        <div class=\"col\">\r\n            <h5 class=\"ingr-justify\">\r\n                Search Recipe\r\n                <br />\r\n            </h5>\r\n            <div class=\"ingr-justify\">\r\n");
#nullable restore
#line 100 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                 if (Model != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                     foreach (IngredientModel Ingredient in Model.search.RecipeChoice.Ingredients)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button name=\"IngredientName\" type=\"submit\" class=\"btn btn-ingr\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4687, "\"", 4791, 3);
                WriteAttributeValue("", 4697, "location.href=\'", 4697, 15, true);
#nullable restore
#line 104 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
WriteAttributeValue("", 4712, Url.Action("AddIngredient", "Home", new { IngredientName = Ingredient.Name }), 4712, 78, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4790, "\'", 4790, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            ");
#nullable restore
#line 105 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(model => Ingredient.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </button>\r\n");
#nullable restore
#line 107 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n            <button type=\"submit\" class=\"btn btn-outline-dark\" style=\"margin-top: 10px;\"");
                BeginWriteAttribute("onclick", " onclick=\"", 5052, "\"", 5112, 3);
                WriteAttributeValue("", 5062, "location.href=\'", 5062, 15, true);
#nullable restore
#line 110 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
WriteAttributeValue("", 5077, Url.Action("ResetSearch", "Home"), 5077, 34, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5111, "\'", 5111, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                Clear\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 114 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
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
#nullable restore
#line 115 "C:\Users\karen\source\repos\Ingredient-Recommender-WebApp\IngredientRecommender\Views\Home\Index.cshtml"
                 
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
