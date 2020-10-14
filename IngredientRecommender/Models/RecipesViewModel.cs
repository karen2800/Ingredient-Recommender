using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngredientRecommender.Models
{
    public class RecipesViewModel
    {
        // Current Recipe Index
        public RecipeModel RecipeChoice { get; set; }
        // Recipes
        public List<RecipeModel> Recipes { get; set; }
        // Show Recipe Titles
        public bool ShowTitles { get; set; }

        public RecipesViewModel()
        {
            RecipeChoice = new RecipeModel();
            Recipes = new List<RecipeModel>();
            ShowTitles = true;
        }
        public RecipesViewModel(List<RecipeModel> Recipes)
        {
            RecipeChoice = new RecipeModel();
            this.Recipes = Recipes;
            ShowTitles = true;
        }
    }
}
