using Microsoft.EntityFrameworkCore.Migrations;

namespace BasketBallCardTrackerWeb.Migrations
{
    public partial class CreateCardTrackerDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    CardCollectionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.CardCollectionId);
                    table.ForeignKey(
                        name: "FK_Collections_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    CardId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollectionId = table.Column<int>(nullable: false),
                    Season = table.Column<string>(nullable: true),
                    Box = table.Column<string>(nullable: true),
                    Insert = table.Column<string>(nullable: true),
                    Player = table.Column<string>(nullable: true),
                    Serial = table.Column<string>(nullable: true),
                    Parallel = table.Column<string>(nullable: true),
                    NumberedTo = table.Column<int>(nullable: true),
                    ActualNumber = table.Column<int>(nullable: true),
                    Seller = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    IMGUrl = table.Column<string>(nullable: true),
                    CardCollectionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.CardId);
                    table.ForeignKey(
                        name: "FK_Cards_Collections_CardCollectionId",
                        column: x => x.CardCollectionId,
                        principalTable: "Collections",
                        principalColumn: "CardCollectionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardCollectionId",
                table: "Cards",
                column: "CardCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Collections_UserId",
                table: "Collections",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Collections");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
