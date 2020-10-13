using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngredientRecommender.Models
{
    public class RecipesViewModel
    {
        // Current Recipe Index
        public int Index { get; set; }
        // Recipes
        public List<RecipeModel> Recipes { get; set; }

        private static volatile RecipesViewModel instance;
        private static object syncRoot = new Object();

        public static RecipesViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new RecipesViewModel();
                        }
                    }
                }

                return instance;
            }
        }

        public RecipesViewModel()
        {
            Index = -1;
            Recipes = new List<RecipeModel>();
        }
        public RecipesViewModel(List<RecipeModel> Recipes)
        {
            Index = -1;
            this.Recipes = Recipes;
        }
        // Update Recipes
        public List<RecipeModel> UpdateRecipes(List<RecipeModel> Recipes)
        {
            instance.Recipes = Recipes;
            return Recipes;
        }
        // Update Index
        public int UpdateIndex(int Index)
        {
            instance.Index = Index;
            return Index;
        }
    }
}
