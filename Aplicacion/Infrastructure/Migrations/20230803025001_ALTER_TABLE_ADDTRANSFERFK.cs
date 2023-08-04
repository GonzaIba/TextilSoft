using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ALTER_TABLE_ADDTRANSFERFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "DetallePedidoFabricas",
                type: "varchar(500)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ID_Transfer",
                table: "DetallePedidoFabricas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedidoFabricas_ID_Transfer",
                table: "DetallePedidoFabricas",
                column: "ID_Transfer");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedidoFabricas_Transfer_ID_Transfer",
                table: "DetallePedidoFabricas",
                column: "ID_Transfer",
                principalTable: "Transfer",
                principalColumn: "ID_Transfer",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedidoFabricas_Transfer_ID_Transfer",
                table: "DetallePedidoFabricas");

            migrationBuilder.DropIndex(
                name: "IX_DetallePedidoFabricas_ID_Transfer",
                table: "DetallePedidoFabricas");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "DetallePedidoFabricas");

            migrationBuilder.DropColumn(
                name: "ID_Transfer",
                table: "DetallePedidoFabricas");
        }
    }
}
