using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SL.Infrastructure.Migrations
{
    public partial class ADD_COMPANY : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "varchar(50)", nullable: false),
                    CompanyCuil = table.Column<string>(type: "varchar(20)", nullable: false),
                    CompanyPhone = table.Column<string>(type: "varchar(50)", nullable: false),
                    CompanyMail = table.Column<string>(type: "varchar(50)", nullable: false),
                    CompanyLocation = table.Column<string>(type: "varchar(200)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "permiso",
                columns: table => new
                {
                    Id_Permiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Permiso = table.Column<string>(type: "varchar(50)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permiso", x => x.Id_Permiso);
                });

            migrationBuilder.CreateTable(
                name: "permiso_permiso",
                columns: table => new
                {
                    Id_Permiso_Permiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Permiso_Padre = table.Column<int>(type: "int", nullable: true),
                    Id_Permiso_Hijo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permiso_permiso", x => x.Id_Permiso_Permiso);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(100)", nullable: false),
                    Contraseña = table.Column<string>(type: "varchar(200)", nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", nullable: true),
                    DNI = table.Column<int>(type: "int", nullable: false),
                    AccesFailed = table.Column<int>(type: "int", nullable: false),
                    EmailConfirmado = table.Column<bool>(type: "bit", nullable: false),
                    DateTimeEmail = table.Column<DateTime>(type: "datetime", nullable: true),
                    NumeroTeléfono = table.Column<string>(type: "varchar(50)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DateDisabledUser = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.Id_Usuario);
                    table.ForeignKey(
                        name: "FK_usuarios_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "usuarios_permisos",
                columns: table => new
                {
                    Id_Usuario = table.Column<int>(type: "int", nullable: false),
                    Id_Permiso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios_permisos", x => new { x.Id_Permiso, x.Id_Usuario });
                    table.ForeignKey(
                        name: "FK_usuarios_permisos_permiso_Id_Permiso",
                        column: x => x.Id_Permiso,
                        principalTable: "permiso",
                        principalColumn: "Id_Permiso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_usuarios_permisos_usuarios_Id_Usuario",
                        column: x => x.Id_Usuario,
                        principalTable: "usuarios",
                        principalColumn: "Id_Usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_CompanyId",
                table: "usuarios",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_permisos_Id_Usuario",
                table: "usuarios_permisos",
                column: "Id_Usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "permiso_permiso");

            migrationBuilder.DropTable(
                name: "usuarios_permisos");

            migrationBuilder.DropTable(
                name: "permiso");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
