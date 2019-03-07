using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSites.Migrations
{
    public partial class AddedAllBeers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 5,
                columns: new[] { "Abv", "Brewery", "Description", "ImgPath", "Name", "Rating" },
                values: new object[] { 5.8f, "Sierra Nevada", "Before Sierra Nevada was a reality, our founders brewed beer at home and dreamed of building a brewery one day. Back then, they brewed the beers they wanted to drink—bold and full of flavor. Stouts had always been a favorite, so when we needed a big and rich beer to test out the brewing system at our fledgling brewery, stout was the obvious choice. Thirty years later, not much has changed. We’re still brewing the beers we want to drink and our classic Stout is the same as it’s ever been—big, rich, bold, black as night and filled with the wild-eyed passion of which dreams are made.", "/Images/Sierra_Nevada_Stout.png", "Sierra Nevada Stout", 4f });

            migrationBuilder.InsertData(
                table: "Beers",
                columns: new[] { "BeerId", "Abv", "Brewery", "CategoryId", "Description", "ImgPath", "Name", "Rating" },
                values: new object[,]
                {
                    { 6, 10.3f, "Surly Brewing Co", 2, "Russian Imperial Stout contains waves of chocolate, coffee, cherry, raisin, and toffee, plus a non-traditional dose of aromatic hops.", "/Images/DarknessStout.png", "Darkness Russian Stout", 4.5f },
                    { 7, 5.4f, "Coors Brewing Co", 3, "In addition to Coor's refreshingly unique Blue Moon® Belgian White Belgian-Style Wheat Ale, we also offer our collection of flavorful seasonal and limited release beers that reflect Blue Moon’s twist on various beer styles. An appreciation for the creative process and a passion for brewing enable us at Blue Moon Brewing Company® to offer a welcome twist of flavor in our beers that everyone can enjoy.", "/Images/Wheat-Beer.png", "Blue Moon Mango Wheat", 3.57f },
                    { 8, 5.6f, "3 Floyds Brewing Co", 3, "An American wheat beer with a refreshing, crisp citrus finish. This delicious session beer is brewed with boatloads of Amarillo hops", "/Images/GummballHeadWheat.png", "GumballHead", 4.2f },
                    { 9, 67.5f, "BrewMeister", 4, "In certain countries, Brewmeister's Snake Venom beer isn't actually a beer because of hits insanely high ABV. This barley beer has an incredibly high proof that makes it rival, if not exceed, many liquors out there. At around $50 per bottle, this insanely powerful beer will burn a hole in your wallet - and possibly your throat.", "/Images/SnakeVenom.png", "Snake Venom", 5f },
                    { 10, 41f, "Brew Dog", 4, "It takes a lot to be called one of Scotland's strongest beers, but this high-ABV Imperial IPA definitely does the trick. BrewDog actually made this beer line as a way of showing their brewing prowess and outdoing competitors in the fight to have one of the strongest beers in the world.", "/Images/SinkBismark.png", "Sink The Bismarck", 5f },
                    { 11, 29f, "Samuel Adams", 4, "Out of all the beers on this list, buying this one is often the easiest and most cost-effective. Sam Adams, after all, is a mainstream beer brand - and it's one of the few mainstream beer brands that's also known for producing special edition batches. ", "/Images/SamAdamsUtopia.png", "Utopias", 5f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Beers",
                keyColumn: "BeerId",
                keyValue: 5,
                columns: new[] { "Abv", "Brewery", "Description", "ImgPath", "Name", "Rating" },
                values: new object[] { 10.3f, "Surly Brewing Co", "Russian Imperial Stout contains waves of chocolate, coffee, cherry, raisin, and toffee, plus a non-traditional dose of aromatic hops.", "/Images/DarknessStout.png", "Darkness Russian Stout", 4.5f });
        }
    }
}
