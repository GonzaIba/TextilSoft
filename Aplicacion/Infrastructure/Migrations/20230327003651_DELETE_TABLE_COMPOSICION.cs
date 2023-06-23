using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class DELETE_TABLE_COMPOSICION : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Composicion_ID_Composicion",
                table: "Producto");

            migrationBuilder.DropTable(
                name: "Composicion");

            migrationBuilder.DropColumn(
                name: "TipoPrenda",
                table: "Producto");

            migrationBuilder.RenameColumn(
                name: "ID_Composicion",
                table: "Producto",
                newName: "ID_TipoPrenda");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_ID_Composicion",
                table: "Producto",
                newName: "IX_Producto_ID_TipoPrenda");

            migrationBuilder.AddColumn<string>(
                name: "Composicion",
                table: "Producto",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "TipoPrenda",
                columns: table => new
                {
                    ID_TipoPrenda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoPrenda = table.Column<string>(type: "varchar(100)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPrenda", x => x.ID_TipoPrenda);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_TipoPrenda_ID_TipoPrenda",
                table: "Producto",
                column: "ID_TipoPrenda",
                principalTable: "TipoPrenda",
                principalColumn: "ID_TipoPrenda",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_TipoPrenda_ID_TipoPrenda",
                table: "Producto");

            migrationBuilder.DropTable(
                name: "TipoPrenda");

            migrationBuilder.DropColumn(
                name: "Composicion",
                table: "Producto");

            migrationBuilder.RenameColumn(
                name: "ID_TipoPrenda",
                table: "Producto",
                newName: "ID_Composicion");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_ID_TipoPrenda",
                table: "Producto",
                newName: "IX_Producto_ID_Composicion");

            migrationBuilder.AddColumn<string>(
                name: "TipoPrenda",
                table: "Producto",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Composicion",
                columns: table => new
                {
                    ID_Composicion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Codigo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Composicion", x => x.ID_Composicion);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Composicion_ID_Composicion",
                table: "Producto",
                column: "ID_Composicion",
                principalTable: "Composicion",
                principalColumn: "ID_Composicion",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
