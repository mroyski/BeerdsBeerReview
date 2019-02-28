using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSites.Migrations
{
    public partial class changedToBeer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.CreateTable(
                name: "Beers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Abv = table.Column<float>(nullable: false),
                    Rating = table.Column<float>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Brewery = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Beers_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Beers",
                columns: new[] { "Id", "Abv", "Brewery", "CategoryId", "Description", "ImgPath", "Name", "Rating" },
                values: new object[] { 1, 6.2f, "Three Floyds", null, "This intensely hopped and gushing undead Pale Ale will be one’s only respite after the zombie apocalypse. Created with our marvelous friends in the comic industry.", "/Images/Zombiedust.png", "Zombie Dust", 4.8f });

            migrationBuilder.InsertData(
                table: "Beers",
                columns: new[] { "Id", "Abv", "Brewery", "CategoryId", "Description", "ImgPath", "Name", "Rating" },
                values: new object[] { 2, 10f, "Bells", null, "Starting with six different hop varietals added to the brew kettle & culminating with a massive dry-hop addition of Simcoe hops, Bell's Hopslam Ale possesses the most complex hopping schedule in the Bell's repertoire. Selected specifically because of their aromatic qualities, these Pacific Northwest varieties contribute a pungent blend of grapefruit, stone fruit and floral notes. A generous malt bill and a solid dollop of honey provide just enough body to keep the balance in check, resulting in a remarkably drinkable rendition of the Double India Pale Ale style.", "/Images/Hopslam.png", "Hopslam", 4.6f });

            migrationBuilder.InsertData(
                table: "Beers",
                columns: new[] { "Id", "Abv", "Brewery", "CategoryId", "Description", "ImgPath", "Name", "Rating" },
                values: new object[] { 3, 7.8f, "Lord Hobo", null, "Our flagship IPA features six hop varietals and a blend of spelt, oat and wheat. A late hop addition of Mosaic, Falconer’s Flight and Amarillo delivers a notable citrus and tropical fruit finish.", "/Images/Boomsauce.png", "Boomsauce", 3f });

            migrationBuilder.CreateIndex(
                name: "IX_Beers_CategoryId",
                table: "Beers",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beers");

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Abv = table.Column<float>(nullable: false),
                    Beer = table.Column<string>(nullable: true),
                    Brewery = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImgPath = table.Column<string>(nullable: true),
                    Rating = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Abv", "Beer", "Brewery", "CategoryId", "Description", "ImgPath", "Rating" },
                values: new object[] { 1, 6.2f, "Zombie Dust", "Three Floyds", null, "This intensely hopped and gushing undead Pale Ale will be one’s only respite after the zombie apocalypse. Created with our marvelous friends in the comic industry.", "/Images/Zombiedust.png", 4.8f });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Abv", "Beer", "Brewery", "CategoryId", "Description", "ImgPath", "Rating" },
                values: new object[] { 2, 10f, "Hopslam", "Bells", null, "Starting with six different hop varietals added to the brew kettle & culminating with a massive dry-hop addition of Simcoe hops, Bell's Hopslam Ale possesses the most complex hopping schedule in the Bell's repertoire. Selected specifically because of their aromatic qualities, these Pacific Northwest varieties contribute a pungent blend of grapefruit, stone fruit and floral notes. A generous malt bill and a solid dollop of honey provide just enough body to keep the balance in check, resulting in a remarkably drinkable rendition of the Double India Pale Ale style.", "/Images/Hopslam.png", 4.6f });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Abv", "Beer", "Brewery", "CategoryId", "Description", "ImgPath", "Rating" },
                values: new object[] { 3, 7.8f, "Boomsauce", "Lord Hobo", null, "Our flagship IPA features six hop varietals and a blend of spelt, oat and wheat. A late hop addition of Mosaic, Falconer’s Flight and Amarillo delivers a notable citrus and tropical fruit finish.", "/Images/Boomsauce.png", 3f });

            migrationBuilder.CreateIndex(
                name: "IX_Review_CategoryId",
                table: "Review",
                column: "CategoryId");
        }
    }
}
