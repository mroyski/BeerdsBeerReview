using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSites.Migrations
{
    public partial class AddedWheatBeer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DetailDescription", "ImgPath", "Style" },
                values: new object[] { "Wheat beer is a beer, usually top-fermented, which is brewed with a large proportion of wheat relative to the amount of malted barley. The two main varieties are Weissbier and Witbier; minor types include Lambic, Berliner Weisse and Gose", "/Images/Wheat-Beer.png", "Wheat" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DetailDescription", "ImgPath", "Style" },
                values: new object[] { "Pale lager is a very pale - to - golden - colored lager beer with a well attenuated body and a varying degree of noble hop bitterness.", "/Images/lager.png", "Lager" });
        }
    }
}
