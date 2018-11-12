using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace pmcrr.Migrations
{
    public partial class outfitwearingusertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clothes");

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
                });

            migrationBuilder.CreateTable(
                name: "OutfitAndWearing",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    outfitid = table.Column<int>(nullable: true),
                    wearingid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutfitAndWearing", x => x.id);
                    table.ForeignKey(
                        name: "FK_OutfitAndWearing_Outfit_outfitid",
                        column: x => x.outfitid,
                        principalTable: "Outfit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OutfitAndWearing_Wearing_wearingid",
                        column: x => x.wearingid,
                        principalTable: "Wearing",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OutfitAndWearing_outfitid",
                table: "OutfitAndWearing",
                column: "outfitid");

            migrationBuilder.CreateIndex(
                name: "IX_OutfitAndWearing_wearingid",
                table: "OutfitAndWearing",
                column: "wearingid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OutfitAndWearing");

            migrationBuilder.DropTable(
                name: "Outfit");

            migrationBuilder.DropTable(
                name: "Wearing");

            migrationBuilder.CreateTable(
                name: "Clothes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    category = table.Column<int>(nullable: false),
                    userid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clothes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Clothes_User_userid",
                        column: x => x.userid,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_userid",
                table: "Clothes",
                column: "userid");
        }
    }
}
