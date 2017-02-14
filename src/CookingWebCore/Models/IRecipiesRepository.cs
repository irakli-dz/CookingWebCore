using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingWebCore.Models
{
    public interface IRecipiesRepository
    {
        IEnumerable<Recipie> Recipies { get; }
        Recipie GetRecipieById(int id);
        Recipie Add(Recipie newRecipie);
        
    }
}
