using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeSite.Migrations
{
    public partial class RecipeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Recipes");

            migrationBuilder.AddColumn<string>(
                name: "createdBy",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "equipment",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "images",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ingredients",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "instructionSteps",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "rating",
                table: "Recipes",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "tags",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "Recipes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "createdBy",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "description",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "equipment",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "images",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "ingredients",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "instructionSteps",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "rating",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "tags",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "title",
                table: "Recipes");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Recipes",
                type: "nvarchar(55)",
                maxLength: 55,
                nullable: false,
                defaultValue: "");
        }
    }
}
