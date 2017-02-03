using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CookingWebCore.Models;

namespace CookingWebCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20170201160640_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CookingWebCore.Models.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IngredientName");

                    b.HasKey("IngredientId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("CookingWebCore.Models.Recipie", b =>
                {
                    b.Property<int>("RecipieId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cuisine");

                    b.Property<bool>("Fast");

                    b.Property<int?>("IngredientId");

                    b.Property<string>("Preparation");

                    b.Property<string>("RecipieName");

                    b.Property<int>("Type");

                    b.HasKey("RecipieId");

                    b.HasIndex("IngredientId");

                    b.ToTable("Recipies");
                });

            modelBuilder.Entity("CookingWebCore.Models.Recipie", b =>
                {
                    b.HasOne("CookingWebCore.Models.Ingredient", "Ingredient")
                        .WithMany("Recipies")
                        .HasForeignKey("IngredientId");
                });
        }
    }
}
