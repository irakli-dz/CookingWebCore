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
                return _appDbContext.Recipies.Include(ir => ir.RecipieIngredient).ThenInclude(x => x.Ingredient).ToList();
               // return _appDbContext.Recipies.Include(ir => ir.RecipieIngredient.Select(x => x.Ingredient));
            }
        }

        public Recipie Add(Recipie newRecipie)
        {
            //newRecipie.Id = _appDbContext.Recipies.Max(r => r.Id) + 1;
            _appDbContext.Add(newRecipie);

            //try
            //{
            //    _appDbContext.SaveChanges();
            //}
            //catch (DbUpdateException e)
            //{

            //    Console.WriteLine(e); 
            //}
            _appDbContext.SaveChanges();

            return newRecipie;
        }

        public Recipie GetRecipieById(int id)
        {
            return _appDbContext.Recipies.FirstOrDefault(r => r.Id == id); ;
        }
    }
}
