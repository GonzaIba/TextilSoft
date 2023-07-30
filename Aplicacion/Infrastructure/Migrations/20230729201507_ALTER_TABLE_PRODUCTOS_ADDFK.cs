using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ALTER_TABLE_PRODUCTOS_ADDFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ID_CinturaInterior",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_Collareta",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_Forreria",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ID_CinturaInterior",
                table: "Producto",
                column: "ID_CinturaInterior");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ID_Collareta",
                table: "Producto",
                column: "ID_Collareta");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ID_Forreria",
                table: "Producto",
                column: "ID_Forreria");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_CinturaInterior_ID_CinturaInterior",
                table: "Producto",
                column: "ID_CinturaInterior",
                principalTable: "CinturaInterior",
                principalColumn: "ID_CinturaInterior",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Collareta_ID_Collareta",
                table: "Producto",
                column: "ID_Collareta",
                principalTable: "Collareta",
                principalColumn: "ID_Collareta",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Forreria_ID_Forreria",
                table: "Producto",
                column: "ID_Forreria",
                principalTable: "Forreria",
                principalColumn: "ID_Forreria",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_CinturaInterior_ID_CinturaInterior",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Collareta_ID_Collareta",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Forreria_ID_Forreria",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_ID_CinturaInterior",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_ID_Collareta",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_ID_Forreria",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "ID_CinturaInterior",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "ID_Collareta",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "ID_Forreria",
                table: "Producto");
        }
    }
}
