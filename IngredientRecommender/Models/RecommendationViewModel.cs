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
        public RecipeModel Recipe { get; set; }

        private static volatile RecommendationViewModel instance;
        private static object syncRoot = new Object();

        public static RecommendationViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new RecommendationViewModel();
                        }
                    }
                }

                return instance;
            }
        }

        // Constructor
        public RecommendationViewModel()
        {
            Recommendations = new List<RecommendationModel>();
            Recipe = new RecipeModel();
        }
        // Constructor: passing in Recommendations and Recipe
        public RecommendationViewModel(List<RecommendationModel> Recommendations, RecipeModel Recipe)
        {
            this.Recommendations = Recommendations;
            this.Recipe = Recipe;
        }

        // Add Ingredient
        public void AddIngredient(string IngredientName, DataModel dataModel)
        {
            instance.Recipe.Add(new IngredientModel(IngredientName, dataModel));
        }
        public void AddIngredient(IngredientModel Ingredient)
        {
            instance.Recipe.Add(Ingredient);
        }
        // Remove Ingredient
        public void RemoveIngredient(string IngredientName, DataModel dataModel)
        {
            instance.Recipe.Remove(new IngredientModel(IngredientName, dataModel));
        }
        public void RemoveIngredient(IngredientModel Ingredient)
        {
            instance.Recipe.Remove(Ingredient);
        }
        public RecommendationViewModel Reset()
        {
            instance = new RecommendationViewModel();
            return instance;
        }
    }
}
