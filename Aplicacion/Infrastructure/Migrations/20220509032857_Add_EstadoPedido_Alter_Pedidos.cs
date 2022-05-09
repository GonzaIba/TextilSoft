using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Add_EstadoPedido_Alter_Pedidos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Cliente_ClienteID_Cliente",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Empleados_EmpleadosID_Empleados",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_ClienteID_Cliente",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_EmpleadosID_Empleados",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "ClienteID_Cliente",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "EmpleadosID_Empleados",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "EstadoPedido",
                table: "Pedidos");

            migrationBuilder.AddColumn<int>(
                name: "ID_EstadoPedido",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EstadoPedido",
                columns: table => new
                {
                    ID_EstadoPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "varchar(50)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPedido", x => x.ID_EstadoPedido);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ID_Cliente",
                table: "Pedidos",
                column: "ID_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ID_Empleados",
                table: "Pedidos",
                column: "ID_Empleados");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ID_EstadoPedido",
                table: "Pedidos",
                column: "ID_EstadoPedido");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Cliente_ID_Cliente",
                table: "Pedidos",
                column: "ID_Cliente",
                principalTable: "Cliente",
                principalColumn: "ID_Cliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Empleados_ID_Empleados",
                table: "Pedidos",
                column: "ID_Empleados",
                principalTable: "Empleados",
                principalColumn: "ID_Empleados",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_EstadoPedido_ID_EstadoPedido",
                table: "Pedidos",
                column: "ID_EstadoPedido",
                principalTable: "EstadoPedido",
                principalColumn: "ID_EstadoPedido",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Cliente_ID_Cliente",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Empleados_ID_Empleados",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_EstadoPedido_ID_EstadoPedido",
                table: "Pedidos");

            migrationBuilder.DropTable(
                name: "EstadoPedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_ID_Cliente",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_ID_Empleados",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_ID_EstadoPedido",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "ID_EstadoPedido",
                table: "Pedidos");

            migrationBuilder.AddColumn<int>(
                name: "ClienteID_Cliente",
                table: "Pedidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EmpleadosID_Empleados",
                table: "Pedidos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstadoPedido",
                table: "Pedidos",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteID_Cliente",
                table: "Pedidos",
                column: "ClienteID_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_EmpleadosID_Empleados",
                table: "Pedidos",
                column: "EmpleadosID_Empleados");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Cliente_ClienteID_Cliente",
                table: "Pedidos",
                column: "ClienteID_Cliente",
                principalTable: "Cliente",
                principalColumn: "ID_Cliente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Empleados_EmpleadosID_Empleados",
                table: "Pedidos",
                column: "EmpleadosID_Empleados",
                principalTable: "Empleados",
                principalColumn: "ID_Empleados",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
