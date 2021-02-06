using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopApp.DataAccess.Migrations
{
    public partial class migra57 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Product_Locale",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullDescription",
                table: "Product_Locale",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Product_Locale",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Product_Locale",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Product_Locale",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Product_Locale");

            migrationBuilder.DropColumn(
                name: "FullDescription",
                table: "Product_Locale");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Product_Locale");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Product_Locale");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Product_Locale");
        }
    }
}
