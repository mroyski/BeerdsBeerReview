using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSites.Migrations
{
    public partial class AddCategoryId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beers_Categories_CategoryId1",
                table: "Beers");

            migrationBuilder.DropIndex(
                name: "IX_Beers_CategoryId1",
                table: "Beers");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Beers");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Beers",
                nullable: false,
                defaultValue: 0);

             migrationBuilder.UpdateData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 1,
                column: "CategoryId",
                value: 1); 

             migrationBuilder.UpdateData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 2,
                column: "CategoryId",
                value: 1);

             migrationBuilder.UpdateData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 3,
                column: "CategoryId",
                value: 1);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beers_Categories_CategoryId",
                table: "Beers");

            migrationBuilder.DropIndex(
                name: "IX_Beers_CategoryId",
                table: "Beers");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Beers");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "Beers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Beers_CategoryId1",
                table: "Beers",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Beers_Categories_CategoryId1",
                table: "Beers",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
