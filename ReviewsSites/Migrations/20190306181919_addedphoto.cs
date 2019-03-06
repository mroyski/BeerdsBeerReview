using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSites.Migrations
{
    public partial class addedphoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "ImgPath",
                value: "/Images/SnakeVenom.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "ImgPath",
                value: "/Images/SnakeVenom.jpg");
        }
    }
}
