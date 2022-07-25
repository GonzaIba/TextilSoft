using Microsoft.EntityFrameworkCore.Migrations;

namespace SL.Infrastructure.Migrations
{
    public partial class ADD_COMPANYCUSTOMIZE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyApiKey",
                table: "Company",
                type: "varchar(64)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CompanyCustomize",
                columns: table => new
                {
                    CompanyCustomizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CompanyLogo = table.Column<string>(type: "varchar(max)", nullable: true),
                    CompanyColor = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyCustomize", x => x.CompanyCustomizeId);
                    table.ForeignKey(
                        name: "FK_CompanyCustomize_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyCustomize_CompanyId",
                table: "CompanyCustomize",
                column: "CompanyId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyCustomize");

            migrationBuilder.DropColumn(
                name: "CompanyApiKey",
                table: "Company");
        }
    }
}
