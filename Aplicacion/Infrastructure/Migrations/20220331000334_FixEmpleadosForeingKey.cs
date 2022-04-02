using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class FixEmpleadosForeingKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductoProveedor_Empleados_EmpleadosModelID_Empleados",
                table: "ProductoProveedor");

            migrationBuilder.DropIndex(
                name: "IX_ProductoProveedor_EmpleadosModelID_Empleados",
                table: "ProductoProveedor");

            migrationBuilder.DropColumn(
                name: "EmpleadosModelID_Empleados",
                table: "ProductoProveedor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpleadosModelID_Empleados",
                table: "ProductoProveedor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductoProveedor_EmpleadosModelID_Empleados",
                table: "ProductoProveedor",
                column: "EmpleadosModelID_Empleados");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoProveedor_Empleados_EmpleadosModelID_Empleados",
                table: "ProductoProveedor",
                column: "EmpleadosModelID_Empleados",
                principalTable: "Empleados",
                principalColumn: "ID_Empleados",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
