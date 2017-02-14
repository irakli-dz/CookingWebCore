using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingWebCore.Models
{
    public class IngredientsRepository : IIngredientsRepository
    {
        private readonly AppDbContext _appDbContext;

        public IngredientsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Ingredient> Ingredients
        {
            get
            {
                return _appDbContext.Ingredients.Include(ir => ir.RecipieIngredient).ThenInclude(x => x.Ingredient).ToList();
                // return _appDbContext.Recipies.Include(ir => ir.RecipieIngredient.Select(x => x.Ingredient));
            }
        }

    }
}
