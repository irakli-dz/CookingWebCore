using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingWebCore.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipie> Recipies { get; set; }
        public DbSet<RecipieIngredient> RecipieIngredient { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipieIngredient>()
                .HasKey(x => new { x.RecipieId, x.IngredientId });


            modelBuilder.Entity<RecipieIngredient>()
                .HasOne(pc => pc.Recipie)
                .WithMany(p => p.RecipieIngredient)
                .HasForeignKey(pc => pc.RecipieId);

            modelBuilder.Entity<RecipieIngredient>()
                .HasOne(pc => pc.Ingredient)
                .WithMany(c => c.RecipieIngredient)
                .HasForeignKey(pc => pc.IngredientId);
        }
    }
}
