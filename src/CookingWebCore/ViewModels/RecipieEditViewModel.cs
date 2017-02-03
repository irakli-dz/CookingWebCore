using CookingWebCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingWebCore.ViewModels
{
    public class RecipieEditViewModel
    {
        public string RecipieName { get; set; }
        //public string CurrentIngredient { get; set; }
        public string Preparation { get; set; }
        public FoodType FoodType { get; set; }
        public CuisineType CuisineType { get; set; }
        //public Ingredient Ingredients { get; set; }
        public List<Ingredient> Ingredients { get; set; }


    }
}
