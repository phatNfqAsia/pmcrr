using Microsoft.EntityFrameworkCore.Migrations;

namespace pmcrr.Migrations
{
    public partial class outfitwearing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "wearingId",
                table: "OutfitAndWearing",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OutfitAndWearing_wearingId",
                table: "OutfitAndWearing",
                column: "wearingId");

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitAndWearing_Wearing_wearingId",
                table: "OutfitAndWearing",
                column: "wearingId",
                principalTable: "Wearing",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddColumn<int>(
                name: "outfitId",
                table: "OutfitAndWearing",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OutfitAndWearing_outfitId",
                table: "OutfitAndWearing",
                column: "outfitId");

            migrationBuilder.AddForeignKey(
                name: "FK_OutfitAndWearing_Outfit_outfitId",
                table: "OutfitAndWearing",
                column: "outfitId",
                principalTable: "Outfit",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OutfitAndWearing_Outfit_outfitId",
                table: "OutfitAndWearing");

            migrationBuilder.DropIndex(
                name: "IX_OutfitAndWearing_outfitId",
                table: "OutfitAndWearing");

            migrationBuilder.DropColumn(
                name: "wearingId",
                table: "OutfitAndWearing");

            migrationBuilder.DropForeignKey(
                name: "FK_OutfitAndWearing_Wearing_wearingId",
                table: "OutfitAndWearing");

            migrationBuilder.DropIndex(
                name: "IX_OutfitAndWearing_wearingId",
                table: "OutfitAndWearing");

            migrationBuilder.DropColumn(
                name: "wearingId",
                table: "OutfitAndWearing");

        }
    }
}
