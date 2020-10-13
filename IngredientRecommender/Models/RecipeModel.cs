using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngredientRecommender.Models
{
    public class RecipeModel
    {
        // List of Ingredients in Recipe
        public List<IngredientModel> Ingredients { get; set; }
        // Recipe Id
        public int Id { get; set; }
        // Recipe Title
        public string Title { get; set; }

        // Constructor
        public RecipeModel()
        {
            Ingredients = new List<IngredientModel>();
            Id = -1;
            Title = "";
        }
        // Constructor: pass in ingredients
        public RecipeModel(List<IngredientModel> Ingredients)
        {
            this.Ingredients = Ingredients;
            Id = -1;
            Title = "";
        }
        // Constructor: pass in ingredients and ID
        public RecipeModel(List<IngredientModel> Ingredients, int Id)
        {
            this.Ingredients = Ingredients;
            this.Id = Id;
            Title = "";
        }
        // Add Ingredient
        public void Add(IngredientModel Ingredient)
        {
            Ingredients.Add(Ingredient);
        }
        // Remove Ingredient
        public void Remove(IngredientModel Ingredient)
        {
            Ingredients = Ingredients.Where(t => (t.Name != Ingredient.Name)).ToList();
        }
    }
}
