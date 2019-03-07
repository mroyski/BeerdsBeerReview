using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSites.Migrations
{
    public partial class MoreBeer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Beers",
                columns: new[] { "BeerId", "Abv", "Brewery", "CategoryId", "Description", "ImgPath", "Name", "Rating" },
                values: new object[] { 4, 4.3f, "Diageo", 2, "Guinness is an Irish dry stout that originated in the brewery of Arthur Guinness at St. James's Gate, Dublin, Ireland, in 1759. It is one of the most successful beer brands worldwide, brewed in almost 50 countries and available in over 120. Sales in 2011 amounted to 850 million litres", "/Images/Gusiness.png", "Guinness", 4.6f });

            migrationBuilder.InsertData(
                table: "Beers",
                columns: new[] { "BeerId", "Abv", "Brewery", "CategoryId", "Description", "ImgPath", "Name", "Rating" },
                values: new object[] { 5, 10.3f, "Surly Brewing Co", 2, "Russian Imperial Stout contains waves of chocolate, coffee, cherry, raisin, and toffee, plus a non-traditional dose of aromatic hops.", "/Images/DarknessStout.png", "Darkness Russian Stout", 4.5f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 5);
        }
    }
}
