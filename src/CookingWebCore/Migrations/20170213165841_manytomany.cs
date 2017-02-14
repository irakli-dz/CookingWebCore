using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CookingWebCore.Migrations
{
    public partial class manytomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipies_Ingredients_IngredientId",
                table: "Recipies");

            migrationBuilder.DropIndex(
                name: "IX_Recipies_IngredientId",
                table: "Recipies");

            migrationBuilder.DropColumn(
                name: "IngredientId",
                table: "Recipies");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Recipies",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateTable(
                name: "RecipieIngredient",
                columns: table => new
                {
                    RecipieId = table.Column<int>(nullable: false),
                    IngredientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipieIngredient", x => new { x.RecipieId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_RecipieIngredient_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipieIngredient_Recipies_RecipieId",
                        column: x => x.RecipieId,
                        principalTable: "Recipies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipieIngredient_IngredientId",
                table: "RecipieIngredient",
                column: "IngredientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipieIngredient");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Recipies",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IngredientId",
                table: "Recipies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Recipies_IngredientId",
                table: "Recipies",
                column: "IngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipies_Ingredients_IngredientId",
                table: "Recipies",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "IngredientId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
