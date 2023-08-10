using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ADDALTER_TABLES : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CapitalRecibido",
                table: "Venta");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Venta");

            migrationBuilder.DropColumn(
                name: "FechaVenta",
                table: "Venta");

            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "Venta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProductoDefecto",
                columns: table => new
                {
                    ID_ProductoDefecto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Producto = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Motivo = table.Column<string>(type: "varchar(500)", nullable: false),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoDefecto", x => x.ID_ProductoDefecto);
                    table.ForeignKey(
                        name: "FK_ProductoDefecto_Producto_ID_Producto",
                        column: x => x.ID_Producto,
                        principalTable: "Producto",
                        principalColumn: "ID_Producto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductoDefecto_ID_Producto",
                table: "ProductoDefecto",
                column: "ID_Producto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductoDefecto");

            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "Venta");

            migrationBuilder.AddColumn<string>(
                name: "CapitalRecibido",
                table: "Venta",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Venta",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaVenta",
                table: "Venta",
                type: "datetime2",
                nullable: true);
        }
    }
}
