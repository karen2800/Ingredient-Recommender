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
        private RecommendationViewModel Display = RecommendationViewModel.Instance;
        private RecipesViewModel Recipes = RecipesViewModel.Instance;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (ModelState.IsValid)
            {
                Display.Recommendations = dataModel.GetRecommendations(Display.Recipe);

                // Remove ingredients already in recipe
                foreach (IngredientModel Ingredient in Display.Recipe.Ingredients)
                {
                    RecommendationModel toRemove = Display.Recommendations.Where(t => t.Ingredient.Name == Ingredient.Name).FirstOrDefault();
                    Ingredient.Score = toRemove.Score;
                    Display.Recommendations.Remove(toRemove);
                }
                // Sort by Score
                Display.Recipe.Ingredients = Display.Recipe.Ingredients.OrderByDescending(t => t.Score).ToList();

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
                if (Display.Recipe.Ingredients.Where(t => t.Name == IngredientName).Any())
                {
                    // Ingredient is already in Recipe
                }
                else
                {
                    Display.AddIngredient(IngredientName, dataModel);
                }
                return RedirectToAction("Index");
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
                Display.RemoveIngredient(IngredientName, dataModel);
                return RedirectToAction("Index");
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
                return View(Recipes);
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
                Recipes.UpdateRecipes(recipes);
                return RedirectToAction("FindRecipe");
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
        public IActionResult DisplayRecipe(int Index)
        {
            if (ModelState.IsValid)
            {
                Recipes.UpdateIndex(Index);
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
            Recipes.UpdateIndex(-1);
            return RedirectToAction("FindRecipe");
        }

        public IActionResult Reset()
        {
            Display = Display.Reset();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
