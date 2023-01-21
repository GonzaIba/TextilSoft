using Microsoft.EntityFrameworkCore.Migrations;

namespace SL.Infrastructure.Migrations
{
    public partial class ADD_COMPANYAUTHENTICATION_COMPANYPASSWORDCONFIG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CanUseLoginAndRegister",
                table: "CompanyCustomize");

            migrationBuilder.CreateTable(
                name: "CompanyAuthentication",
                columns: table => new
                {
                    CompanyAuthenticationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CanUseLoginAndRegister = table.Column<bool>(type: "bit", nullable: false),
                    UserRequireUniqueEmail = table.Column<bool>(type: "bit", nullable: false),
                    SignInRequireConfirmedAccount = table.Column<bool>(type: "bit", nullable: false),
                    MaxFailedAccessAttempts = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyAuthentication", x => x.CompanyAuthenticationId);
                    table.ForeignKey(
                        name: "FK_CompanyAuthentication_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyPasswordConfig",
                columns: table => new
                {
                    CompanyPasswordConfigId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyAuthenticationId = table.Column<int>(type: "int", nullable: false),
                    CountLength = table.Column<int>(type: "int", nullable: false),
                    RequireNonAlphanumeric = table.Column<bool>(type: "bit", nullable: false),
                    RequireLowercase = table.Column<bool>(type: "bit", nullable: false),
                    RequireUppercase = table.Column<bool>(type: "bit", nullable: false),
                    RequireDigit = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyPasswordConfig", x => x.CompanyPasswordConfigId);
                    table.ForeignKey(
                        name: "FK_CompanyPasswordConfig_CompanyAuthentication_CompanyAuthenticationId",
                        column: x => x.CompanyAuthenticationId,
                        principalTable: "CompanyAuthentication",
                        principalColumn: "CompanyAuthenticationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAuthentication_CompanyId",
                table: "CompanyAuthentication",
                column: "CompanyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompanyPasswordConfig_CompanyAuthenticationId",
                table: "CompanyPasswordConfig",
                column: "CompanyAuthenticationId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyPasswordConfig");

            migrationBuilder.DropTable(
                name: "CompanyAuthentication");

            migrationBuilder.AddColumn<bool>(
                name: "CanUseLoginAndRegister",
                table: "CompanyCustomize",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
