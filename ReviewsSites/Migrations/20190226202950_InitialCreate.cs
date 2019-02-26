using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSites.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Abv = table.Column<float>(nullable: false),
                    Rating = table.Column<float>(nullable: false),
                    Beer = table.Column<string>(nullable: true),
                    Brewery = table.Column<string>(nullable: true),
                    Style = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Abv", "Beer", "Brewery", "Description", "ImgPath", "Rating", "Style" },
                values: new object[] { 1, 6.2f, "Zombie Dust", "Three Floyds", "This intensely hopped and gushing undead Pale Ale will be one’s only respite after the zombie apocalypse. Created with our marvelous friends in the comic industry.", "/Images/Zombiedust.png", 4.8f, null });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Abv", "Beer", "Brewery", "Description", "ImgPath", "Rating", "Style" },
                values: new object[] { 2, 10f, "Hopslam", "Bells", "Starting with six different hop varietals added to the brew kettle & culminating with a massive dry-hop addition of Simcoe hops, Bell's Hopslam Ale possesses the most complex hopping schedule in the Bell's repertoire. Selected specifically because of their aromatic qualities, these Pacific Northwest varieties contribute a pungent blend of grapefruit, stone fruit and floral notes. A generous malt bill and a solid dollop of honey provide just enough body to keep the balance in check, resulting in a remarkably drinkable rendition of the Double India Pale Ale style.", "/Images/Hopslam.png", 4.6f, null });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Abv", "Beer", "Brewery", "Description", "ImgPath", "Rating", "Style" },
                values: new object[] { 3, 7.8f, "Boomsauce", "Lord Hobo", "Our flagship IPA features six hop varietals and a blend of spelt, oat and wheat. A late hop addition of Mosaic, Falconer’s Flight and Amarillo delivers a notable citrus and tropical fruit finish.", "/Images/Boomsauce.png", 3f, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review");
        }
    }
}
