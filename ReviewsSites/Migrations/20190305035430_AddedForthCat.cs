using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSites.Migrations
{
    public partial class AddedForthCat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DetailDescription", "Style" },
                values: new object[] { "Pale lager is a very pale - to - golden - colored lager beer with a well attenuated body and a varying degree of noble hop bitterness.", "Lager" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "DetailDescription", "ImgPath", "Style" },
                values: new object[] { 4, "Pale lager is a very pale-to-golden-colored lager beer with a well attenuated body and a varying degree of noble hop bitterness.", "/Images/PaleAle.png", "Pale Ale" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "DetailDescription", "Style" },
                values: new object[] { "Pale lager is a very pale-to-golden-colored lager beer with a well attenuated body and a varying degree of noble hop bitterness.", "Pale Lager" });
        }
    }
}
