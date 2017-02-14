using CookingWebCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CookingWebCore.ViewModels
{
    public class RecipieEditViewModel
    {
        [Required]
        public string RecipieName { get; set; }

        //public string CurrentIngredient { get; set; }
        public string Preparation { get; set; }
        public FoodType FoodType { get; set; }
        public CuisineType CuisineType { get; set; }
        //public int IngredientId { get; set; }
        //public string IngredientName { get; set; }
        //public int Ingredient { get; set; }
        public bool Fast { get; set; }
        //public Recipie Recipie { get; set; }

        public List<Ingredient> Ingredients { get; set; }



    }
}
