using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSites.Migrations
{
    public partial class AddedMoreReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "UserReviewId",
                keyValue: 1,
                columns: new[] { "UserRating", "UserText" },
                values: new object[] { 4, "This rocks...nuff said ya dig it." });

            migrationBuilder.InsertData(
                table: "UserReviews",
                columns: new[] { "UserReviewId", "BeerId", "UserRating", "UserText" },
                values: new object[,]
                {
                    { 2, 1, 5, "A very creative beer with a unique, beautiful, and delicious hops profile. Nice dry, balanced base beer with enough malt backbone to support but not crowd the hops, interesting hops profile that showcases both piney, resinous, dank flavors with classic American citrus notes and tropical fruit hops flavors, and a very clean fermentation profile to boot. Extremely drinkable thanks to lower bitterness but no doubt about it, the hops are the belle of the ball. Buy by the case—it’s an excellent example of the style." },
                    { 3, 2, 3, "Caramel background, the smallest hint of tropical fruit, lots of pine and citrus. A good example of what it is, but what it is is still a boring, rather one-note IPA." },
                    { 4, 2, 4, "Slammed me like a hibbidy bibiddy hop" },
                    { 5, 3, 1, "So that's what a hobo tastes like..." },
                    { 6, 3, 3, "This is a full-bodied rendition of the style with carbonation at the lower end of the style spectrum, while the alcohol content was quite evident -- contributing to this beer's warming presence. Very true to form, this Double IPA stands tall and should be considered for consumption as a fine example of the style." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserReviews",
                keyColumn: "UserReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserReviews",
                keyColumn: "UserReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserReviews",
                keyColumn: "UserReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserReviews",
                keyColumn: "UserReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserReviews",
                keyColumn: "UserReviewId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "UserReviews",
                keyColumn: "UserReviewId",
                keyValue: 1,
                columns: new[] { "UserRating", "UserText" },
                values: new object[] { 3, "This rocks" });
        }
    }
}
