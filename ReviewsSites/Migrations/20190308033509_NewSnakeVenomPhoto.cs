using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSites.Migrations
{
    public partial class NewSnakeVenomPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 9,
                column: "ImgPath",
                value: "/Images/Snake-Venom.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 9,
                column: "ImgPath",
                value: "/Images/SnakeVenom.png");
        }
    }
}
