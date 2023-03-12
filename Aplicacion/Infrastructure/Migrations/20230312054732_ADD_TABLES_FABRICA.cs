using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ADD_TABLES_FABRICA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EsPedido",
                table: "OrdenDeTrabajo");

            migrationBuilder.DropColumn(
                name: "NumeroPedido",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "TotalAPagar",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "DetallePedido");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "DetallePedido");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "DetallePedido");

            migrationBuilder.RenameColumn(
                name: "TotalAbonado",
                table: "Factura",
                newName: "TotalPago");

            migrationBuilder.AlterColumn<int>(
                name: "Cantidad",
                table: "DetallePedido",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PedidosFabrica",
                columns: table => new
                {
                    ID_PedidosFabrica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Empleados = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Detalle = table.Column<string>(type: "varchar(100)", nullable: true),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosFabrica", x => x.ID_PedidosFabrica);
                    table.ForeignKey(
                        name: "FK_PedidosFabrica_Empleados_ID_Empleados",
                        column: x => x.ID_Empleados,
                        principalTable: "Empleados",
                        principalColumn: "ID_Empleados",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallePedidoFabricas",
                columns: table => new
                {
                    ID_DetallePedidosFabrica = table.Column<int>(type: "int", nullable: false),
                    ID_PedidosFabrica = table.Column<int>(type: "int", nullable: false),
                    ID_Producto = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallePedidoFabricas", x => x.ID_DetallePedidosFabrica);
                    table.ForeignKey(
                        name: "FK_DetallePedidoFabricas_PedidosFabrica_ID_DetallePedidosFabrica",
                        column: x => x.ID_DetallePedidosFabrica,
                        principalTable: "PedidosFabrica",
                        principalColumn: "ID_PedidosFabrica",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallePedidoFabricas_Producto_ID_Producto",
                        column: x => x.ID_Producto,
                        principalTable: "Producto",
                        principalColumn: "ID_Producto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdenDeTrabajoFabrica",
                columns: table => new
                {
                    ID_OrdenDeTrabajoFabrica = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ID_PedidoFabrica = table.Column<int>(type: "int", nullable: false),
                    ID_Sector = table.Column<int>(type: "int", nullable: false),
                    EstadoOrden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCerrado = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenDeTrabajoFabrica", x => x.ID_OrdenDeTrabajoFabrica);
                    table.ForeignKey(
                        name: "FK_OrdenDeTrabajoFabrica_PedidosFabrica_ID_OrdenDeTrabajoFabrica",
                        column: x => x.ID_OrdenDeTrabajoFabrica,
                        principalTable: "PedidosFabrica",
                        principalColumn: "ID_PedidosFabrica",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenDeTrabajoFabrica_Sector_ID_Sector",
                        column: x => x.ID_Sector,
                        principalTable: "Sector",
                        principalColumn: "ID_Sector",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedidoFabricas_ID_Producto",
                table: "DetallePedidoFabricas",
                column: "ID_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenDeTrabajoFabrica_ID_Sector",
                table: "OrdenDeTrabajoFabrica",
                column: "ID_Sector");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosFabrica_ID_Empleados",
                table: "PedidosFabrica",
                column: "ID_Empleados");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallePedidoFabricas");

            migrationBuilder.DropTable(
                name: "OrdenDeTrabajoFabrica");

            migrationBuilder.DropTable(
                name: "PedidosFabrica");

            migrationBuilder.RenameColumn(
                name: "TotalPago",
                table: "Factura",
                newName: "TotalAbonado");

            migrationBuilder.AddColumn<bool>(
                name: "EsPedido",
                table: "OrdenDeTrabajo",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumeroPedido",
                table: "Factura",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAPagar",
                table: "Factura",
                type: "decimal(18,0)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cantidad",
                table: "DetallePedido",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "DetallePedido",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "DetallePedido",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "DetallePedido",
                type: "datetime2",
                nullable: true);
        }
    }
}
