using Microsoft.EntityFrameworkCore.Migrations;

namespace pmcrr.Migrations
{
    public partial class add_clothes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "User",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
