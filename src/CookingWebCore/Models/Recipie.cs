using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingWebCore.Models
{
    public enum CuisineType
    {
        None,
        Italian,
        French,
        Japanese,
        Chinese,
        Asian,
        Georgian,
        Misc
    }

    public enum FoodType
    {
        None,
        Vegitarian,
        Beef,
        Pork,
        Fish,
        Seafood,
        Misc
    }

    public class Recipie
    {
        public int RecipieId { get; set; }
        public string RecipieName { get; set; }
        public CuisineType Cuisine { get; set; }
        public FoodType Type { get; set; }
        public string Preparation { get; set; }
        public bool Fast { get; set; }
        public virtual Ingredient Ingredient { get; set; }
    }
}
