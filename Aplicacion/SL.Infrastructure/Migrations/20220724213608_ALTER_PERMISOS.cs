using Microsoft.EntityFrameworkCore.Migrations;

namespace SL.Infrastructure.Migrations
{
    public partial class ALTER_PERMISOS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Permiso",
                table: "permiso",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "permiso",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "permiso",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_permiso_CompanyId",
                table: "permiso",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_permiso_Company_CompanyId",
                table: "permiso",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_permiso_Company_CompanyId",
                table: "permiso");

            migrationBuilder.DropIndex(
                name: "IX_permiso_CompanyId",
                table: "permiso");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "permiso");

            migrationBuilder.AlterColumn<string>(
                name: "Permiso",
                table: "permiso",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "permiso",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");
        }
    }
}
