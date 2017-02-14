using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CookingWebCore.Models;

namespace CookingWebCore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20170208072740_initial3")]
    partial class initial3
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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cuisine");

                    b.Property<bool>("Fast");

                    b.Property<int>("IngredientId");

                    b.Property<string>("Name");

                    b.Property<string>("Preparation");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.ToTable("Recipies");
                });

            modelBuilder.Entity("CookingWebCore.Models.Recipie", b =>
                {
                    b.HasOne("CookingWebCore.Models.Ingredient", "Ingredient")
                        .WithMany("Recipies")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
