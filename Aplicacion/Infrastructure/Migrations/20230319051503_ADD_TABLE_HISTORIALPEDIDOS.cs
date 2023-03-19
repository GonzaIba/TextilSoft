using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ADD_TABLE_HISTORIALPEDIDOS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistorialPedidos",
                columns: table => new
                {
                    ID_HistorialPedidos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Pedido = table.Column<int>(type: "int", nullable: false),
                    ID_EstadoPedido = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialPedidos", x => x.ID_HistorialPedidos);
                    table.ForeignKey(
                        name: "FK_HistorialPedidos_EstadoPedido_ID_EstadoPedido",
                        column: x => x.ID_EstadoPedido,
                        principalTable: "EstadoPedido",
                        principalColumn: "ID_EstadoPedido",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistorialPedidos_Pedidos_ID_Pedido",
                        column: x => x.ID_Pedido,
                        principalTable: "Pedidos",
                        principalColumn: "ID_Pedido",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistorialPedidos_ID_EstadoPedido",
                table: "HistorialPedidos",
                column: "ID_EstadoPedido");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialPedidos_ID_Pedido",
                table: "HistorialPedidos",
                column: "ID_Pedido");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistorialPedidos");
        }
    }
}
