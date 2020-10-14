using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IngredientRecommender.Models;

namespace IngredientRecommender.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DataModel dataModel = DataModel.Instance;
        private DisplayViewModel Display = DisplayViewModel.Instance;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (ModelState.IsValid)
            {
                Display.mine.Recommendations = dataModel.GetRecommendations(Display.mine.MyRecipe);

                // Remove ingredients already in recipe
                foreach (IngredientModel Ingredient in Display.mine.MyRecipe.Ingredients)
                {
                    RecommendationModel toRemove = Display.mine.Recommendations.Where(t => t.Ingredient.Name == Ingredient.Name).FirstOrDefault();
                    Ingredient.Score = toRemove.Score;
                    Display.mine.Recommendations.Remove(toRemove);
                }
                // Sort by Score
                Display.mine.MyRecipe.Ingredients = Display.mine.MyRecipe.Ingredients.OrderByDescending(t => t.Score).ToList();

                return View(Display);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
        // Add Ingredient to My Recipe
        public IActionResult AddIngredient(string IngredientName)
        {
            if (ModelState.IsValid)
            {
                if (Display.mine.MyRecipe.Ingredients.Where(t => t.Name == IngredientName).Any())
                {
                    // Ingredient is already in Recipe
                }
                else
                {
                    Display.mine.AddIngredient(IngredientName, dataModel, false);
                }
                return RedirectToAction("FindSimilarRecipe");
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
        // Remove Ingredient from My Recipe
        public IActionResult RemoveIngredient(string IngredientName)
        {
            if (ModelState.IsValid)
            {
                Display.mine.RemoveIngredient(IngredientName, dataModel, false);
                return RedirectToAction("FindSimilarRecipe");
            }
            else
            {
                return RedirectToAction("Error");
            }
        }

        // Find a Recipe given an ingredient
        public IActionResult FindRecipe()
        {
            if (ModelState.IsValid)
            {
                return View(Display);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
        public IActionResult SearchRecipes(string IngredientName)
        {
            if (ModelState.IsValid)
            {
                List<RecipeModel> recipes = dataModel.GetRecipesByIngr(IngredientName);
                Display.search.Recipes = recipes;
                return RedirectToAction("FindRecipe");
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
        public IActionResult DisplayRecipe(int Id)
        {
            if (ModelState.IsValid)
            {
                RecipeModel found = Display.search.Recipes.Where(t => t.Id == Id).FirstOrDefault();
                if (found != null)
                {
                    Display.search.RecipeChoice = found;
                    Display.search.ShowTitles = false;
                }
                return RedirectToAction("FindRecipe");
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
        // Go back to recipe titles
        public IActionResult SeeTitles()
        {
            Display.search.ShowTitles = true;
            return RedirectToAction("FindRecipe");
        }
        public IActionResult FindSimilarRecipe()
        {
            if (Display.mine.MyRecipe.Ingredients.Count > 0)
            {
                int maxCount = 0;
                foreach (RecipeModel Recipe in dataModel.AllRecipes)
                {
                    int count = 0;
                    foreach (IngredientModel Ingredient in Display.mine.MyRecipe.Ingredients)
                    {
                        var found = Recipe.Ingredients.Where(t => t.Name == Ingredient.Name).FirstOrDefault();
                        if (found != null)
                        {
                            count++;
                        }
                    }
                    if (count > maxCount)
                    {
                        Display.mine.SimilarRecipe = Recipe;
                        maxCount = count;
                        if (maxCount == Display.mine.MyRecipe.Ingredients.Count)
                        {
                            break;
                        }
                    }
                }
            }

            return RedirectToAction("Index");
        }
        public IActionResult ResetMine()
        {
            Display.ResetMine();
            return RedirectToAction("FindSimilarRecipe");
        }
        public IActionResult ResetSearch()
        {
            Display.ResetSearch();
            return RedirectToAction("Index");
        }
        public IActionResult Reset()
        {
            Display.Reset();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
