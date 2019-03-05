using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSites.Migrations
{
    public partial class addedMoreCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "DetailDescription", "ImgPath", "Style" },
                values: new object[] { 2, "A stout beer is a dark, sometimes bitter beer that was first commercially produced in the 1730s. The first versions of this drink were from Ireland, where the still most popular stout is produced by Guinness. Yet Guinness is only one of the many companies that produce and market stouts.", "/Images/Stout.png", "Stout" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "DetailDescription", "ImgPath", "Style" },
                values: new object[] { 3, "Pale lager is a very pale-to-golden-colored lager beer with a well attenuated body and a varying degree of noble hop bitterness.", "/Images/lager.png", "Pale Lager" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
