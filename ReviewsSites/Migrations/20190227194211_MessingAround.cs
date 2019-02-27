using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReviewsSites.Migrations
{
    public partial class MessingAround : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Style",
                table: "Review");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Review",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Style = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Style" },
                values: new object[] { 2, "IPA" });

            migrationBuilder.CreateIndex(
                name: "IX_Review_CategoryId",
                table: "Review",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Categories_CategoryId",
                table: "Review",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Categories_CategoryId",
                table: "Review");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Review_CategoryId",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Review");

            migrationBuilder.AddColumn<string>(
                name: "Style",
                table: "Review",
                nullable: true);
        }
    }
}
