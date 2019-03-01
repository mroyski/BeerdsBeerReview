using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSites.Migrations
{
    public partial class AddedDetailDescrip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DetailDescription",
                table: "Categories",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "DetailDescription",
                value: "Characterized by floral, fruity, citrus-like, piney or resinous American-variety hop character, the IPA beer style is all about hop flavor, aroma and bitterness. This has been the most-entered category at the Great American Beer Festival for more than a decade, and is the top-selling craft beer style in supermarkets and liquor stores across the U.S.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailDescription",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 2,
                column: "CategoryId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 3,
                column: "CategoryId",
                value: 0);
        }
    }
}
