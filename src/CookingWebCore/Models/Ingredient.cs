using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CookingWebCore.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientId { get; set; }

        public string IngredientName { get; set; }

        public IEnumerable<RecipieIngredient> RecipieIngredient { get; set; }

        [NotMapped]
        public bool checkBoxAnswer { get; set; }
        // public List<Recipie> Recipies { get; set; }
    }
}
