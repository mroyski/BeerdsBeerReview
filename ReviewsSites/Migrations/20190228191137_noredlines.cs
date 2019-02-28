using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSites.Migrations
{
    public partial class noredlines : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beers_Categories_CategoryId",
                table: "Beers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Beers",
                newName: "CategoryId1");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Beers",
                newName: "BeerId");

            migrationBuilder.RenameIndex(
                name: "IX_Beers_CategoryId",
                table: "Beers",
                newName: "IX_Beers_CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Beers_Categories_CategoryId1",
                table: "Beers",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beers_Categories_CategoryId1",
                table: "Beers");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CategoryId1",
                table: "Beers",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "BeerId",
                table: "Beers",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Beers_CategoryId1",
                table: "Beers",
                newName: "IX_Beers_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beers_Categories_CategoryId",
                table: "Beers",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
