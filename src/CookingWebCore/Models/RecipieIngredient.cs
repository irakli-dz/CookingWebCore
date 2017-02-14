using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingWebCore.Models
{
    public class RecipieIngredient
    {
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public int RecipieId { get; set; }
        public Recipie Recipie { get; set; }
    }
}
