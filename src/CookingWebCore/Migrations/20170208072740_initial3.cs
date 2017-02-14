using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CookingWebCore.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RecipieName",
                table: "Recipies",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "RecipieId",
                table: "Recipies",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Recipies",
                newName: "RecipieName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Recipies",
                newName: "RecipieId");
        }
    }
}
