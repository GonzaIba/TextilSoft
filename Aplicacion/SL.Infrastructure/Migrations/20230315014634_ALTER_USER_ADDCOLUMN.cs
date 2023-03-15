using Microsoft.EntityFrameworkCore.Migrations;

namespace SL.Infrastructure.Migrations
{
    public partial class ALTER_USER_ADDCOLUMN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdiomaSeleccionado",
                table: "usuarios",
                type: "varchar(10)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdiomaSeleccionado",
                table: "usuarios");
        }
    }
}
