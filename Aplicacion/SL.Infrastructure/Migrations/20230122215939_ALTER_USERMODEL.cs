using Microsoft.EntityFrameworkCore.Migrations;

namespace SL.Infrastructure.Migrations
{
    public partial class ALTER_USERMODEL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAdmin",
                table: "usuarios",
                newName: "IsOwner");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsOwner",
                table: "usuarios",
                newName: "IsAdmin");
        }
    }
}
