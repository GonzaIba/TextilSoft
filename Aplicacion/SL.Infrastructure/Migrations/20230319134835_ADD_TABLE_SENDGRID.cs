using Microsoft.EntityFrameworkCore.Migrations;

namespace SL.Infrastructure.Migrations
{
    public partial class ADD_TABLE_SENDGRID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanySendGridConfiguration",
                columns: table => new
                {
                    CompanySendGridConfigId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    ApiKey = table.Column<string>(type: "varchar(500)", nullable: false),
                    From = table.Column<string>(type: "varchar(100)", nullable: false),
                    DisplayName = table.Column<string>(type: "varchar(50)", nullable: false),
                    ApiKeyId = table.Column<string>(type: "varchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySendGridConfiguration", x => x.CompanySendGridConfigId);
                    table.ForeignKey(
                        name: "FK_CompanySendGridConfiguration_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanySendGridConfiguration_CompanyId",
                table: "CompanySendGridConfiguration",
                column: "CompanyId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanySendGridConfiguration");
        }
    }
}
