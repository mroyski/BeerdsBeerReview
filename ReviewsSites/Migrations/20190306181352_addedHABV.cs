using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSites.Migrations
{
    public partial class addedHABV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DetailDescription", "ImgPath", "Style" },
                values: new object[] { "Strong beers have a special place in many people's hearts, primarily because they involve the delicious fizz of beer with a very powerful alcoholic punch. They get you blitzed without requiring six or more of them per sitting, and that makes them amazing. ", "/Images/SnakeVenom.png", "High ABV" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "DetailDescription", "ImgPath", "Style" },
                values: new object[] { "Pale lager is a very pale-to-golden-colored lager beer with a well attenuated body and a varying degree of noble hop bitterness.", "/Images/PaleAle.png", "Pale Ale" });
        }
    }
}
