using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace IngredientRecommender.Models
{
    public class DataModel
    {
        // List of Unique Ingredients
        public List<IngredientModel> UniqueIngredients { get; set; }
        // List of Recipes
        public List<RecipeModel> AllRecipes { get; set; }

        // Co-occurrence Matrix of Ingredients
        private Dictionary<(int, int), int> CoOccurrences;
        // Data Path
        private string PATH = Directory.GetCurrentDirectory() + "\\Data\\AllRecipes-cleaned.csv";

        private static volatile DataModel instance;
        private static object syncRoot = new Object();

        public static DataModel Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new DataModel();
                        }
                    }
                }

                return instance;
            }
        }

        // Constructor
        public DataModel() 
        {
            UniqueIngredients = new List<IngredientModel>();
            AllRecipes = new List<RecipeModel>();

            GetAllRecipes();
            TrackCoOccurrences();
        }
        // Get a specific recipe: given id
        public List<RecipeModel> GetRecipesById(int Id)
        {
            return instance.AllRecipes.Where(t => t.Id == Id).ToList();
        }
        // Get a specific recipe: containing given ingredient
        public List<RecipeModel> GetRecipesByIngr(string IngredientName)
        {
            return AllRecipes.Where(t => t.Ingredients.Select(t => t.Name).ToList().Contains(IngredientName)).ToList();
        }
        // Get All Recipes and keep track of unique ingredients
        private void GetAllRecipes()
        {
            // read data
            string[] lines = File.ReadLines(@PATH).Skip(1).ToArray();

            var query = from line in lines
                        let data = line.Split(',')
                        select new
                        {
                            RecipeId = int.Parse(data[0]),
                            Ingredient = new IngredientModel(data[2], int.Parse(data[1])),
                            RecipeTitle = data[3]
                        };

            int currentRecipeId = 0;
            RecipeModel Recipe = new RecipeModel();

            foreach (var item in query)
            {
                // assume data is ordered by recipe id
                if (currentRecipeId != item.RecipeId)
                {
                    // add recipe to list of all recipes
                    AllRecipes.Add(Recipe);

                    // update current recipe marker
                    currentRecipeId = item.RecipeId;
                    Recipe = new RecipeModel();
                }

                Recipe.Id = item.RecipeId;
                Recipe.Title = item.RecipeTitle;
                Recipe.Ingredients.Add(item.Ingredient);
            }
            // add last recipe
            AllRecipes.Add(Recipe);

            // store unique ingredients
            UniqueIngredients = query.Select(t => t.Ingredient).GroupBy(t => t.Id).Select(t => t.First()).ToList();
        }
        // Track and calculate Co-occurrences
        private void TrackCoOccurrences()
        {
            // key: (Ingr1, Ingr2)  -- ingredient pair
            // value: Count         -- number of recipes seen together
            CoOccurrences = new Dictionary<(int, int), int>();

            // iterate through all recipes
            foreach (RecipeModel Recipe in AllRecipes)
            {
                // Keep track of co-occurrences of ingredients
                foreach (IngredientModel Ingr1 in Recipe.Ingredients)
                {
                    foreach (IngredientModel Ingr2 in Recipe.Ingredients)
                    {
                        if (CoOccurrences.ContainsKey((Ingr1.Id, Ingr2.Id)))
                        {
                            CoOccurrences[(Ingr1.Id, Ingr2.Id)] += 1;
                        }
                        else if (CoOccurrences.ContainsKey((Ingr2.Id, Ingr1.Id)))
                        {
                            CoOccurrences[(Ingr2.Id, Ingr1.Id)] += 1;
                        }
                        else
                        {
                            CoOccurrences[(Ingr1.Id, Ingr2.Id)] = 1;
                        }
                    }
                }
            }
        }
        // Get Co-occurence Count
        private int TryGetCount(int First, int Second)
        {
            int together;
            bool success = CoOccurrences.TryGetValue((First, Second), out together);
            if (success == false)
            {
                success = CoOccurrences.TryGetValue((Second, First), out together);
                if (success == false)
                {
                    // Error: could not find at least one of the ingredients
                    // Mark as not seen together
                    return 0;
                }
            }
            return together;
        }

        // Get Recommendation Scores
        public List<RecommendationModel> GetRecommendations(RecipeModel Recipe)
        {
            List<RecommendationModel> Recommendations = new List<RecommendationModel>();

            if (Recipe == null)
            {
                // get popular ingredients
                foreach (IngredientModel Feature in instance.UniqueIngredients)
                {
                    Recommendations.Add(new RecommendationModel(Feature, TryGetCount(Feature.Id, Feature.Id)));
                }
                // sort by score
                Recommendations = Recommendations.OrderByDescending(t => t.Score).ToList();
                return Recommendations;
            }

            int numFeatures = instance.UniqueIngredients.Count;
            int numRecipeIngrs = Recipe.Ingredients.Count;

            // Naive Bayes
            // iterate through all reatures (unique ingredients)
            foreach (IngredientModel Feature in instance.UniqueIngredients)
            {
                double likelihood = 1.0;
                int featureCount = TryGetCount(Feature.Id, Feature.Id);

                // iterate through all ingredients in recipe
                foreach (IngredientModel RecipeIngr in Recipe.Ingredients)
                {
                    // ignore matching ingredients in calculation
                    if (!Feature.Equals(RecipeIngr))
                    {
                        int togetherCount = TryGetCount(Feature.Id, RecipeIngr.Id);
                        int recipeIngrCount = TryGetCount(RecipeIngr.Id, RecipeIngr.Id);

                        likelihood *= (togetherCount + 1.0) / (featureCount + numFeatures);
                        likelihood /= recipeIngrCount;

                    }
                }

                RecommendationModel recommendation = new RecommendationModel(Feature, likelihood);
                Recommendations.Add(recommendation);
            }
            // sort recommendations by score
            Recommendations = Recommendations.OrderByDescending(t => t.Score).ToList();

            return Recommendations;
        }
    }
}
