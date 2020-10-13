using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngredientRecommender.Models
{
    public class RecommendationModel
    {
        // Ingredient
        public IngredientModel Ingredient { get; set; }
        // Recommendation Score
        public double Score { get; set; }

        // Constructor
        public RecommendationModel()
        {
            Ingredient = new IngredientModel();
            Score = 0.0;
        }
        // Constructor: pass in Ingredient
        public RecommendationModel(IngredientModel Ingredient)
        {
            this.Ingredient = Ingredient;
            Score = 0.0;
        }
        // Constructor: pass in Ingredient and Score
        public RecommendationModel(IngredientModel Ingredient, double Score)
        {
            this.Ingredient = Ingredient;
            this.Score = Score;
        }
    }
}
