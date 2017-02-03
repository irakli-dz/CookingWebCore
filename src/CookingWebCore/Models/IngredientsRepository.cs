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

        public IEnumerable<Ingredient> Ingredients => _appDbContext.Ingredients;
    }
}
