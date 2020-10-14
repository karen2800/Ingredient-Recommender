using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngredientRecommender.Models
{
    public class DisplayViewModel
    {
        // Recommendations -- specific to my recipe
        public RecommendationViewModel mine { get; set; }
        // Recipes -- found in search
        public RecipesViewModel search { get; set; }

        private static volatile DisplayViewModel instance;
        private static object syncRoot = new Object();

        public static DisplayViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new DisplayViewModel();
                        }
                    }
                }

                return instance;
            }
        }
        public DisplayViewModel()
        {
            mine = new RecommendationViewModel();
            search = new RecipesViewModel();
        }
        public void ResetMine()
        {
            instance.mine = new RecommendationViewModel();
        }
        public void ResetSearch()
        {
            instance.search = new RecipesViewModel();
        }
        public void Reset()
        {
            ResetMine();
            ResetSearch();
        }
    }
}
