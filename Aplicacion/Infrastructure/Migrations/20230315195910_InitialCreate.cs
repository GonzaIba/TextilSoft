using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Residencia = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ID_Cliente);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    ID_Empleados = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Apellido = table.Column<string>(type: "varchar(50)", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    Residencia = table.Column<string>(type: "varchar(50)", nullable: true),
                    Legajo = table.Column<string>(type: "varchar(50)", nullable: true),
                    DNI = table.Column<string>(type: "varchar(50)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.ID_Empleados);
                });

            migrationBuilder.CreateTable(
                name: "EstadoPedido",
                columns: table => new
                {
                    ID_EstadoPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "varchar(50)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPedido", x => x.ID_EstadoPedido);
                });

            migrationBuilder.CreateTable(
                name: "EstadoPedidoFabrica",
                columns: table => new
                {
                    ID_EstadoPedidoFabrica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "varchar(50)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoPedidoFabrica", x => x.ID_EstadoPedidoFabrica);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    ID_Producto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoProducto = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Color = table.Column<string>(type: "varchar(100)", nullable: false),
                    Composicion = table.Column<string>(type: "varchar(50)", nullable: false),
                    Estampa = table.Column<string>(type: "varchar(50)", nullable: false),
                    NombreProducto = table.Column<string>(type: "varchar(50)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Tejido = table.Column<string>(type: "varchar(50)", nullable: false),
                    TallePrenda = table.Column<string>(type: "varchar(50)", nullable: false),
                    TipoProducto = table.Column<string>(type: "varchar(50)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
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
                    Nombre = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
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
                    NombreSector = table.Column<string>(type: "varchar(50)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sector", x => x.ID_Sector);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    ID_Pedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Cliente = table.Column<int>(type: "int", nullable: false),
                    ID_Empleados = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_EstadoPedido = table.Column<int>(type: "int", nullable: false),
                    NumeroPedido = table.Column<int>(type: "int", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Seña = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.ID_Pedido);
                    table.ForeignKey(
                        name: "FK_Pedidos_Cliente_ID_Cliente",
                        column: x => x.ID_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "ID_Cliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_Empleados_ID_Empleados",
                        column: x => x.ID_Empleados,
                        principalTable: "Empleados",
                        principalColumn: "ID_Empleados",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_EstadoPedido_ID_EstadoPedido",
                        column: x => x.ID_EstadoPedido,
                        principalTable: "EstadoPedido",
                        principalColumn: "ID_EstadoPedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PedidosFabrica",
                columns: table => new
                {
                    ID_PedidosFabrica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Empleados = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_EstadoPedidoFabrica = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Detalle = table.Column<string>(type: "varchar(100)", nullable: true),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosFabrica", x => x.ID_PedidosFabrica);
                    table.ForeignKey(
                        name: "FK_PedidosFabrica_Empleados_ID_Empleados",
                        column: x => x.ID_Empleados,
                        principalTable: "Empleados",
                        principalColumn: "ID_Empleados",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosFabrica_EstadoPedidoFabrica_ID_EstadoPedidoFabrica",
                        column: x => x.ID_EstadoPedidoFabrica,
                        principalTable: "EstadoPedidoFabrica",
                        principalColumn: "ID_EstadoPedidoFabrica",
                        onDelete: ReferentialAction.Cascade);
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
                    Descripcion = table.Column<string>(type: "varchar(50)", nullable: true),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
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
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductoProveedor", x => x.ID_ProductoProveedor);
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
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Detalle = table.Column<string>(type: "varchar(500)", nullable: true)
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
                    ID_Factura = table.Column<int>(type: "int", nullable: false),
                    NumeroFactura = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalPago = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    ID_Pedido = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.ID_Factura);
                    table.ForeignKey(
                        name: "FK_Factura_Pedidos_ID_Factura",
                        column: x => x.ID_Factura,
                        principalTable: "Pedidos",
                        principalColumn: "ID_Pedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdenDeTrabajo",
                columns: table => new
                {
                    ID_OrdenDeTrabajo = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ID_Pedido = table.Column<int>(type: "int", nullable: false),
                    ID_Sector = table.Column<int>(type: "int", nullable: false),
                    EstadoOrden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCerrado = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenDeTrabajo", x => x.ID_OrdenDeTrabajo);
                    table.ForeignKey(
                        name: "FK_OrdenDeTrabajo_Pedidos_ID_OrdenDeTrabajo",
                        column: x => x.ID_OrdenDeTrabajo,
                        principalTable: "Pedidos",
                        principalColumn: "ID_Pedido",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenDeTrabajo_Sector_ID_OrdenDeTrabajo",
                        column: x => x.ID_OrdenDeTrabajo,
                        principalTable: "Sector",
                        principalColumn: "ID_Sector",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallePedidoFabricas",
                columns: table => new
                {
                    ID_DetallePedidosFabrica = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_PedidosFabrica = table.Column<int>(type: "int", nullable: false),
                    ID_Producto = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Detalle = table.Column<string>(type: "varchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallePedidoFabricas", x => x.ID_DetallePedidosFabrica);
                    table.ForeignKey(
                        name: "FK_DetallePedidoFabricas_PedidosFabrica_ID_PedidosFabrica",
                        column: x => x.ID_PedidosFabrica,
                        principalTable: "PedidosFabrica",
                        principalColumn: "ID_PedidosFabrica",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallePedidoFabricas_Producto_ID_Producto",
                        column: x => x.ID_Producto,
                        principalTable: "Producto",
                        principalColumn: "ID_Producto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdenDeTrabajoFabrica",
                columns: table => new
                {
                    ID_OrdenDeTrabajoFabrica = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ID_PedidoFabrica = table.Column<int>(type: "int", nullable: false),
                    ID_Sector = table.Column<int>(type: "int", nullable: false),
                    EstadoOrden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaCerrado = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenDeTrabajoFabrica", x => x.ID_OrdenDeTrabajoFabrica);
                    table.ForeignKey(
                        name: "FK_OrdenDeTrabajoFabrica_PedidosFabrica_ID_OrdenDeTrabajoFabrica",
                        column: x => x.ID_OrdenDeTrabajoFabrica,
                        principalTable: "PedidosFabrica",
                        principalColumn: "ID_PedidosFabrica",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenDeTrabajoFabrica_Sector_ID_Sector",
                        column: x => x.ID_Sector,
                        principalTable: "Sector",
                        principalColumn: "ID_Sector",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_ID_Pedido",
                table: "DetallePedido",
                column: "ID_Pedido");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedido_ID_Producto",
                table: "DetallePedido",
                column: "ID_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedidoFabricas_ID_PedidosFabrica",
                table: "DetallePedidoFabricas",
                column: "ID_PedidosFabrica");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedidoFabricas_ID_Producto",
                table: "DetallePedidoFabricas",
                column: "ID_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenDeTrabajoFabrica_ID_Sector",
                table: "OrdenDeTrabajoFabrica",
                column: "ID_Sector");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ID_Cliente",
                table: "Pedidos",
                column: "ID_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ID_Empleados",
                table: "Pedidos",
                column: "ID_Empleados");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ID_EstadoPedido",
                table: "Pedidos",
                column: "ID_EstadoPedido");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosFabrica_ID_Empleados",
                table: "PedidosFabrica",
                column: "ID_Empleados");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosFabrica_ID_EstadoPedidoFabrica",
                table: "PedidosFabrica",
                column: "ID_EstadoPedidoFabrica");

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
                name: "DetallePedido");

            migrationBuilder.DropTable(
                name: "DetallePedidoFabricas");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "OrdenDeTrabajo");

            migrationBuilder.DropTable(
                name: "OrdenDeTrabajoFabrica");

            migrationBuilder.DropTable(
                name: "ProductoProveedor");

            migrationBuilder.DropTable(
                name: "Venta");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "PedidosFabrica");

            migrationBuilder.DropTable(
                name: "Sector");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "EstadoPedido");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "EstadoPedidoFabrica");
        }
    }
}
