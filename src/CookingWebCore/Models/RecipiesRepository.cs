using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingWebCore.Models
{
    public class RecipiesRepository : IRecipiesRepository
    {
        private readonly AppDbContext _appDbContext;

        public RecipiesRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Recipie> Recipies
        {
            get
            {
                return _appDbContext.Recipies.Include(i=>i.Ingredient);
            }
        }

        public Recipie GetRecipieById(int id)
        {
            return _appDbContext.Recipies.FirstOrDefault(r => r.RecipieId == id); ;
        }
    }
}
