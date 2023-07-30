using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ALTER_TABLE_PRODUCTO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Transfer_ID_Transfer",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_ID_Transfer",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "ID_Transfer",
                table: "Producto");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "DetallePedido",
                type: "varchar(500)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ID_Transfer",
                table: "DetallePedido",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_ID_Transfer",
                table: "DetallePedido",
                column: "ID_Transfer");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedido_Transfer_ID_Transfer",
                table: "DetallePedido",
                column: "ID_Transfer",
                principalTable: "Transfer",
                principalColumn: "ID_Transfer",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedido_Transfer_ID_Transfer",
                table: "DetallePedido");

            migrationBuilder.DropIndex(
                name: "IX_DetallePedido_ID_Transfer",
                table: "DetallePedido");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "DetallePedido");

            migrationBuilder.DropColumn(
                name: "ID_Transfer",
                table: "DetallePedido");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Producto",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ID_Transfer",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ID_Transfer",
                table: "Producto",
                column: "ID_Transfer");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Transfer_ID_Transfer",
                table: "Producto",
                column: "ID_Transfer",
                principalTable: "Transfer",
                principalColumn: "ID_Transfer",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
