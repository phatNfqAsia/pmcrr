using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace pmcrr.Migrations
{
    public partial class init_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Outfit",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    purpose = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outfit", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Wearing",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    category = table.Column<int>(nullable: false),
                    ownerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wearing", x => x.id);
                    table.ForeignKey(
                        name: "FK_Wearing_User_ownerId",
                        column: x => x.ownerId,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OutfitAndWearing",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    outfitId = table.Column<int>(nullable: false),
                    wearingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutfitAndWearing", x => x.id);
                    table.ForeignKey(
                        name: "FK_OutfitAndWearing_Outfit_outfitId",
                        column: x => x.outfitId,
                        principalTable: "Outfit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutfitAndWearing_Wearing_wearingId",
                        column: x => x.wearingId,
                        principalTable: "Wearing",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OutfitAndWearing_outfitId",
                table: "OutfitAndWearing",
                column: "outfitId");

            migrationBuilder.CreateIndex(
                name: "IX_OutfitAndWearing_wearingId",
                table: "OutfitAndWearing",
                column: "wearingId");

            migrationBuilder.CreateIndex(
                name: "IX_Wearing_ownerId",
                table: "Wearing",
                column: "ownerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OutfitAndWearing");

            migrationBuilder.DropTable(
                name: "Outfit");

            migrationBuilder.DropTable(
                name: "Wearing");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
