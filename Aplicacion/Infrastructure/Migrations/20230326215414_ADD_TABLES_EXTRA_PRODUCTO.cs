using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class ADD_TABLES_EXTRA_PRODUCTO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Composicion",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "Estampa",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "NombreProducto",
                table: "Producto");

            migrationBuilder.RenameColumn(
                name: "TipoProducto",
                table: "Producto",
                newName: "TipoPrenda");

            migrationBuilder.RenameColumn(
                name: "Tejido",
                table: "Producto",
                newName: "Descripcion");

            migrationBuilder.AddColumn<int>(
                name: "ID_BolsilloInterior",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_Composicion",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_Lazo",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_TelaBase",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_TelaCombinacion",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_Transfer",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID_Vivo",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImagenPrenda",
                table: "Producto",
                type: "varchar(MAX)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "BolsilloInterior",
                columns: table => new
                {
                    ID_BolsilloInterior = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", nullable: true),
                    Codigo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BolsilloInterior", x => x.ID_BolsilloInterior);
                });

            migrationBuilder.CreateTable(
                name: "Composicion",
                columns: table => new
                {
                    ID_Composicion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", nullable: true),
                    Codigo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Composicion", x => x.ID_Composicion);
                });

            migrationBuilder.CreateTable(
                name: "Lazo",
                columns: table => new
                {
                    ID_Lazo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", nullable: true),
                    Codigo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lazo", x => x.ID_Lazo);
                });

            migrationBuilder.CreateTable(
                name: "TelaBase",
                columns: table => new
                {
                    ID_TelaBase = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", nullable: true),
                    Codigo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelaBase", x => x.ID_TelaBase);
                });

            migrationBuilder.CreateTable(
                name: "TelaCombinacion",
                columns: table => new
                {
                    ID_TelaCombinacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", nullable: true),
                    Codigo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelaCombinacion", x => x.ID_TelaCombinacion);
                });

            migrationBuilder.CreateTable(
                name: "Transfer",
                columns: table => new
                {
                    ID_Transfer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "varchar(50)", nullable: false),
                    Imagen = table.Column<string>(type: "varchar(MAX)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfer", x => x.ID_Transfer);
                });

            migrationBuilder.CreateTable(
                name: "Vivo",
                columns: table => new
                {
                    ID_Vivo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", nullable: true),
                    Codigo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vivo", x => x.ID_Vivo);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ID_BolsilloInterior",
                table: "Producto",
                column: "ID_BolsilloInterior");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ID_Composicion",
                table: "Producto",
                column: "ID_Composicion");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ID_Lazo",
                table: "Producto",
                column: "ID_Lazo");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ID_TelaBase",
                table: "Producto",
                column: "ID_TelaBase");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ID_TelaCombinacion",
                table: "Producto",
                column: "ID_TelaCombinacion");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ID_Transfer",
                table: "Producto",
                column: "ID_Transfer");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ID_Vivo",
                table: "Producto",
                column: "ID_Vivo");

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_BolsilloInterior_ID_BolsilloInterior",
                table: "Producto",
                column: "ID_BolsilloInterior",
                principalTable: "BolsilloInterior",
                principalColumn: "ID_BolsilloInterior",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Composicion_ID_Composicion",
                table: "Producto",
                column: "ID_Composicion",
                principalTable: "Composicion",
                principalColumn: "ID_Composicion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Lazo_ID_Lazo",
                table: "Producto",
                column: "ID_Lazo",
                principalTable: "Lazo",
                principalColumn: "ID_Lazo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_TelaBase_ID_TelaBase",
                table: "Producto",
                column: "ID_TelaBase",
                principalTable: "TelaBase",
                principalColumn: "ID_TelaBase",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_TelaCombinacion_ID_TelaCombinacion",
                table: "Producto",
                column: "ID_TelaCombinacion",
                principalTable: "TelaCombinacion",
                principalColumn: "ID_TelaCombinacion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Transfer_ID_Transfer",
                table: "Producto",
                column: "ID_Transfer",
                principalTable: "Transfer",
                principalColumn: "ID_Transfer",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Vivo_ID_Vivo",
                table: "Producto",
                column: "ID_Vivo",
                principalTable: "Vivo",
                principalColumn: "ID_Vivo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producto_BolsilloInterior_ID_BolsilloInterior",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Composicion_ID_Composicion",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Lazo_ID_Lazo",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_TelaBase_ID_TelaBase",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_TelaCombinacion_ID_TelaCombinacion",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Transfer_ID_Transfer",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Vivo_ID_Vivo",
                table: "Producto");

            migrationBuilder.DropTable(
                name: "BolsilloInterior");

            migrationBuilder.DropTable(
                name: "Composicion");

            migrationBuilder.DropTable(
                name: "Lazo");

            migrationBuilder.DropTable(
                name: "TelaBase");

            migrationBuilder.DropTable(
                name: "TelaCombinacion");

            migrationBuilder.DropTable(
                name: "Transfer");

            migrationBuilder.DropTable(
                name: "Vivo");

            migrationBuilder.DropIndex(
                name: "IX_Producto_ID_BolsilloInterior",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_ID_Composicion",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_ID_Lazo",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_ID_TelaBase",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_ID_TelaCombinacion",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_ID_Transfer",
                table: "Producto");

            migrationBuilder.DropIndex(
                name: "IX_Producto_ID_Vivo",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "ID_BolsilloInterior",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "ID_Composicion",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "ID_Lazo",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "ID_TelaBase",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "ID_TelaCombinacion",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "ID_Transfer",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "ID_Vivo",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "ImagenPrenda",
                table: "Producto");

            migrationBuilder.RenameColumn(
                name: "TipoPrenda",
                table: "Producto",
                newName: "TipoProducto");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Producto",
                newName: "Tejido");

            migrationBuilder.AddColumn<string>(
                name: "Composicion",
                table: "Producto",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Estampa",
                table: "Producto",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NombreProducto",
                table: "Producto",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");
        }
    }
}
