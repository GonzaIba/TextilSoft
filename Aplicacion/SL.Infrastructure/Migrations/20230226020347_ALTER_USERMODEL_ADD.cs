using Microsoft.EntityFrameworkCore.Migrations;

namespace SL.Infrastructure.Migrations
{
    public partial class ALTER_USERMODEL_ADD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<bool>(
                name: "EnableAnimators",
                table: "usuarios",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "EnableSlicePanel",
                table: "usuarios",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "EnableVolume",
                table: "usuarios",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<int>(
                name: "Volume",
                table: "usuarios",
                type: "int",
                nullable: false,
                defaultValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnableAnimators",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "EnableSlicePanel",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "EnableVolume",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "Volume",
                table: "usuarios");
        }
    }
}
