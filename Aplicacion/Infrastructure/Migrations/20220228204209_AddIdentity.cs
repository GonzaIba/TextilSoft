using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class AddIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ID_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DNI = table.Column<string>(type: "varchar(50)", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    Apellido = table.Column<string>(type: "varchar(50)", nullable: true),
                    EstadoCliente = table.Column<string>(type: "varchar(50)", nullable: true),
                    FechaNac = table.Column<DateTime>(type: "datetime", nullable: true),
                    Mail = table.Column<string>(type: "varchar(50)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: true),
                    Residencia = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ID_Cliente);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    ID_Empleados = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellido = table.Column<string>(type: "varchar(50)", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    Residencia = table.Column<string>(type: "varchar(50)", nullable: true),
                    Legajo = table.Column<string>(type: "varchar(50)", nullable: true),
                    DNI = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.ID_Empleados);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    ID_Producto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoProducto = table.Column<string>(type: "varchar(50)", nullable: true),
                    Color = table.Column<string>(type: "varchar(50)", nullable: true),
                    Composicion = table.Column<string>(type: "varchar(50)", nullable: true),
                    Estampa = table.Column<string>(type: "varchar(50)", nullable: true),
                    NombreProducto = table.Column<string>(type: "varchar(50)", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Tejido = table.Column<string>(type: "varchar(50)", nullable: true),
                    TallePrenda = table.Column<string>(type: "varchar(50)", nullable: true),
                    TipoProducto = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.ID_Producto);
                });

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    ID_Proveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DNI = table.Column<string>(type: "varchar(50)", nullable: false),
                    EstadoProveedor = table.Column<string>(type: "varchar(50)", nullable: true),
                    FechaNac = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LugarEmpresa = table.Column<string>(type: "varchar(50)", nullable: true),
                    Mail = table.Column<string>(type: "varchar(50)", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.ID_Proveedor);
                });

            migrationBuilder.CreateTable(
                name: "Sector",
                columns: table => new
                {
                    ID_Sector = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreSector = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sector", x => x.ID_Sector);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    ID_Pedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroPedido = table.Column<int>(type: "int", nullable: false),
                    EstadoPedido = table.Column<string>(type: "varchar(50)", nullable: false),
                    TotalPago = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ID_Cliente = table.Column<int>(type: "int", nullable: false),
                    ID_Empleados = table.Column<int>(type: "int", nullable: false),
                    Seña = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    ClienteID_Cliente = table.Column<int>(type: "int", nullable: true),
                    EmpleadosID_Empleados = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.ID_Pedido);
                    table.ForeignKey(
                        name: "FK_Pedidos_Cliente_ClienteID_Cliente",
                        column: x => x.ClienteID_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "ID_Cliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Empleados_EmpleadosID_Empleados",
                        column: x => x.EmpleadosID_Empleados,
                        principalTable: "Empleados",
                        principalColumn: "ID_Empleados",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Venta",
                columns: table => new
                {
                    ID_Venta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Producto = table.Column<int>(type: "int", nullable: false),
                    CapitalRecibido = table.Column<string>(type: "varchar(50)", nullable: true),
                    FechaVenta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venta", x => x.ID_Venta);
                    table.ForeignKey(
                        name: "FK_Venta_Producto_ID_Producto",
                        column: x => x.ID_Producto,
                        principalTable: "Producto",
                        principalColumn: "ID_Producto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductoProveedor",
                columns: table => new
                {
                    ID_ProductoProveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoProducto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreProducto = table.Column<string>(type: "varchar(50)", nullable: true),
                    TipoTela = table.Column<string>(type: "varchar(50)", nullable: true),
                    CantidadRollos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MarcaTela = table.Column<string>(type: "varchar(50)", nullable: true),
                    Precio = table.Column<string>(type: "varchar(50)", nullable: true),
                    ID_Proveedor = table.Column<int>(type: "int", nullable: false),
                    EmpleadosModelID_Empleados = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoProveedor", x => x.ID_ProductoProveedor);
                    table.ForeignKey(
                        name: "FK_ProductoProveedor_Empleados_EmpleadosModelID_Empleados",
                        column: x => x.EmpleadosModelID_Empleados,
                        principalTable: "Empleados",
                        principalColumn: "ID_Empleados",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductoProveedor_Proveedor_ID_Proveedor",
                        column: x => x.ID_Proveedor,
                        principalTable: "Proveedor",
                        principalColumn: "ID_Proveedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallePedido",
                columns: table => new
                {
                    ID_DetallePedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Pedido = table.Column<int>(type: "int", nullable: false),
                    ID_Producto = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallePedido", x => x.ID_DetallePedido);
                    table.ForeignKey(
                        name: "FK_DetallePedido_Pedidos_ID_Pedido",
                        column: x => x.ID_Pedido,
                        principalTable: "Pedidos",
                        principalColumn: "ID_Pedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallePedido_Producto_ID_Producto",
                        column: x => x.ID_Producto,
                        principalTable: "Producto",
                        principalColumn: "ID_Producto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    ID_Factura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroFactura = table.Column<int>(type: "int", nullable: true),
                    NumeroPedido = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalAbonado = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    TotalAPagar = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    ID_Pedido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.ID_Factura);
                    table.ForeignKey(
                        name: "FK_Factura_Pedidos_ID_Pedido",
                        column: x => x.ID_Pedido,
                        principalTable: "Pedidos",
                        principalColumn: "ID_Pedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdenDeTrabajo",
                columns: table => new
                {
                    ID_OrdenDeTrabajo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ID_Pedido = table.Column<int>(type: "int", nullable: false),
                    ID_Sector = table.Column<int>(type: "int", nullable: false),
                    EstadoOrden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCerrado = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EsPedido = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenDeTrabajo", x => x.ID_OrdenDeTrabajo);
                    table.ForeignKey(
                        name: "FK_OrdenDeTrabajo_Pedidos_ID_Pedido",
                        column: x => x.ID_Pedido,
                        principalTable: "Pedidos",
                        principalColumn: "ID_Pedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenDeTrabajo_Sector_ID_Sector",
                        column: x => x.ID_Sector,
                        principalTable: "Sector",
                        principalColumn: "ID_Sector",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_ID_Pedido",
                table: "DetallePedido",
                column: "ID_Pedido");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_ID_Producto",
                table: "DetallePedido",
                column: "ID_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_ID_Pedido",
                table: "Factura",
                column: "ID_Pedido");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenDeTrabajo_ID_Pedido",
                table: "OrdenDeTrabajo",
                column: "ID_Pedido");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenDeTrabajo_ID_Sector",
                table: "OrdenDeTrabajo",
                column: "ID_Sector");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteID_Cliente",
                table: "Pedidos",
                column: "ClienteID_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_EmpleadosID_Empleados",
                table: "Pedidos",
                column: "EmpleadosID_Empleados");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoProveedor_EmpleadosModelID_Empleados",
                table: "ProductoProveedor",
                column: "EmpleadosModelID_Empleados");

            migrationBuilder.CreateIndex(
                name: "IX_ProductoProveedor_ID_Proveedor",
                table: "ProductoProveedor",
                column: "ID_Proveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Venta_ID_Producto",
                table: "Venta",
                column: "ID_Producto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DetallePedido");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "OrdenDeTrabajo");

            migrationBuilder.DropTable(
                name: "ProductoProveedor");

            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Sector");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
