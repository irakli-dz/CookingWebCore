using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CookingWebCore.Models;

namespace CookingWebCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CookingWebCore.Models.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IngredientName");

                    b.HasKey("IngredientId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("CookingWebCore.Models.Recipie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cuisine");

                    b.Property<bool>("Fast");

                    b.Property<string>("Name");

                    b.Property<string>("Preparation");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Recipies");
                });

            modelBuilder.Entity("CookingWebCore.Models.RecipieIngredient", b =>
                {
                    b.Property<int>("RecipieId");

                    b.Property<int>("IngredientId");

                    b.HasKey("RecipieId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("RecipieIngredient");
                });

            modelBuilder.Entity("CookingWebCore.Models.RecipieIngredient", b =>
                {
                    b.HasOne("CookingWebCore.Models.Ingredient", "Ingredient")
                        .WithMany("RecipieIngredient")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CookingWebCore.Models.Recipie", "Recipie")
                        .WithMany("RecipieIngredient")
                        .HasForeignKey("RecipieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
