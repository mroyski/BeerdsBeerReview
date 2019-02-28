using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSites.Migrations
{
    public partial class RemoveNavigation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beers_Categories_CategoryId",
                table: "Beers");

            migrationBuilder.DropIndex(
                name: "IX_Beers_CategoryId",
                table: "Beers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Beers_CategoryId",
                table: "Beers",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beers_Categories_CategoryId",
                table: "Beers",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
