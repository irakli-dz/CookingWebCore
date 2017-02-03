using CookingWebCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingWebCore.ViewModels
{
    public class RecipiesListViewModel
    {

        public IEnumerable<Recipie> Recipies { get; set; }

        public string CurrentIngredient { get; set; }



    }
}
