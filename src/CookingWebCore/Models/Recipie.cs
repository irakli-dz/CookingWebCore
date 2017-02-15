using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        Vegetarian,
        meat,
        Seafood,
        Misc
    }

    public class Recipie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        
        public string Name { get; set; }

        public CuisineType Cuisine { get; set; }
        public FoodType Type { get; set; }
        public string Preparation { get; set; }
        public bool Fast { get; set; }

        //[Required]
        //public int IngredientId { get; set; }

        //public Ingredient Ingredient { get; set; }

        public List<RecipieIngredient> RecipieIngredient { get; set; }


    }
}
