using Microsoft.EntityFrameworkCore.Migrations;

namespace SL.Infrastructure.Migrations
{
    public partial class ALTER_USER_COMPANYCUSTOMIZE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "VerifyCode",
                table: "usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CanUseLoginAndRegister",
                table: "CompanyCustomize",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "VerifyCode",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "CanUseLoginAndRegister",
                table: "CompanyCustomize");
        }
    }
}
