using Microsoft.EntityFrameworkCore.Migrations;

namespace pmcrr.Migrations
{
    public partial class add_foreignkey_owner_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ownerId",
                table: "Wearing",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Wearing_ownerId",
                table: "Wearing",
                column: "ownerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wearing_User_ownerId",
                table: "Wearing",
                column: "ownerId",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wearing_User_ownerId",
                table: "Wearing");

            migrationBuilder.DropIndex(
                name: "IX_Wearing_ownerId",
                table: "Wearing");

            migrationBuilder.DropColumn(
                name: "ownerId",
                table: "Wearing");
        }
    }
}
