using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngredientRecommender.Models
{
    public class IngredientModel
    {
        // Ingredient Name
        public string Name { get; set; }
        // Ingredient Id
        public int Id { get; set; }
        // Recommendation Score
        public double Score { get; set; }

        // Constructor
        public IngredientModel()
        {
            Name = "";
            Id = -1;
            Score = 0;
        }
        // Constructor: pass in Name and Data Model
        public IngredientModel(string Name, DataModel dataModel)
        {
            this.Name = Name;
            // search for id
            Id = dataModel.UniqueIngredients.Where(t => t.Name == Name).Select(t => t.Id).FirstOrDefault();
            Score = 0;
        }
        // Constructor: pass in Name and Id
        public IngredientModel(string Name, int Id)
        {
            this.Name = Name;
            this.Id = Id;
            Score = 0;
        }
    }
}
