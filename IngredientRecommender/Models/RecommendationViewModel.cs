using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngredientRecommender.Models
{
    public class RecommendationViewModel
    {
        // Recommendations
        public List<RecommendationModel> Recommendations { get; set; }
        // Recipe
        public RecipeModel MyRecipe { get; set; }
        public RecipeModel SimilarRecipe { get; set; }

        // Constructor
        public RecommendationViewModel()
        {
            Recommendations = new List<RecommendationModel>();
            MyRecipe = new RecipeModel();
            SimilarRecipe = new RecipeModel();
        }

        // Add Ingredient
        public void AddIngredient(string IngredientName, DataModel dataModel, bool similar)
        {
            if (similar == false)
            {
                MyRecipe.Add(new IngredientModel(IngredientName, dataModel));
            } 
            else
            {
                SimilarRecipe.Add(new IngredientModel(IngredientName, dataModel));
            }
            
        }
        public void AddIngredient(IngredientModel Ingredient, bool similar)
        {
            if (similar == false)
            {
                MyRecipe.Add(Ingredient);
            }
            else
            {
                SimilarRecipe.Add(Ingredient);
            }
        }
        // Remove Ingredient
        public void RemoveIngredient(string IngredientName, DataModel dataModel, bool similar)
        {
            if (similar == false)
            {
                MyRecipe.Remove(new IngredientModel(IngredientName, dataModel));
            }
            else
            {
                SimilarRecipe.Remove(new IngredientModel(IngredientName, dataModel));
            }
        }
        public void RemoveIngredient(IngredientModel Ingredient, bool similar)
        {
            if (similar == false)
            {
                MyRecipe.Remove(Ingredient);
            }
            else
            {
                SimilarRecipe.Remove(Ingredient);
            }
        }
    }
}
