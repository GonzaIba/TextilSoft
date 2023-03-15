USE [master]
GO
/****** Object:  Database [DBProyectoTextil3]    Script Date: 14/3/2023 22:49:51 ******/
CREATE DATABASE [DBProyectoTextil3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBProyectoTextil3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DBProyectoTextil3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBProyectoTextil3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DBProyectoTextil3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DBProyectoTextil3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBProyectoTextil3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBProyectoTextil3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBProyectoTextil3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBProyectoTextil3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBProyectoTextil3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBProyectoTextil3] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBProyectoTextil3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBProyectoTextil3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBProyectoTextil3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBProyectoTextil3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBProyectoTextil3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBProyectoTextil3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBProyectoTextil3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBProyectoTextil3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBProyectoTextil3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBProyectoTextil3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBProyectoTextil3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBProyectoTextil3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBProyectoTextil3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBProyectoTextil3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBProyectoTextil3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBProyectoTextil3] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [DBProyectoTextil3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBProyectoTextil3] SET RECOVERY FULL 
GO
ALTER DATABASE [DBProyectoTextil3] SET  MULTI_USER 
GO
ALTER DATABASE [DBProyectoTextil3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBProyectoTextil3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBProyectoTextil3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBProyectoTextil3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBProyectoTextil3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBProyectoTextil3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBProyectoTextil3', N'ON'
GO
ALTER DATABASE [DBProyectoTextil3] SET QUERY_STORE = OFF
GO
USE [DBProyectoTextil3]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 14/3/2023 22:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 14/3/2023 22:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[ID_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[DNI] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[EstadoCliente] [varchar](50) NULL,
	[FechaNac] [datetime] NULL,
	[Mail] [varchar](50) NULL,
	[Telefono] [int] NULL,
	[Residencia] [varchar](50) NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallePedido]    Script Date: 14/3/2023 22:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallePedido](
	[ID_DetallePedido] [int] IDENTITY(1,1) NOT NULL,
	[ID_Pedido] [int] NOT NULL,
	[ID_Producto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Detalle] [varchar](500) NULL,
 CONSTRAINT [PK_DetallePedido] PRIMARY KEY CLUSTERED 
(
	[ID_DetallePedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallePedidoFabricas]    Script Date: 14/3/2023 22:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallePedidoFabricas](
	[ID_DetallePedidosFabrica] [int] NOT NULL,
	[ID_PedidosFabrica] [int] NOT NULL,
	[ID_Producto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Detalle] [varchar](500) NULL,
 CONSTRAINT [PK_DetallePedidoFabricas] PRIMARY KEY CLUSTERED 
(
	[ID_DetallePedidosFabrica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 14/3/2023 22:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[ID_Empleados] [uniqueidentifier] NOT NULL,
	[Apellido] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Residencia] [varchar](50) NULL,
	[Legajo] [varchar](50) NULL,
	[DNI] [varchar](50) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[ID_Empleados] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoPedido]    Script Date: 14/3/2023 22:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoPedido](
	[ID_EstadoPedido] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [varchar](50) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_EstadoPedido] PRIMARY KEY CLUSTERED 
(
	[ID_EstadoPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 14/3/2023 22:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[ID_Factura] [int] IDENTITY(1,1) NOT NULL,
	[NumeroFactura] [int] NULL,
	[Fecha] [datetime2](7) NULL,
	[TotalPago] [decimal](18, 0) NULL,
	[ID_Pedido] [int] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[ID_Factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdenDeTrabajo]    Script Date: 14/3/2023 22:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdenDeTrabajo](
	[ID_OrdenDeTrabajo] [int] IDENTITY(1,1) NOT NULL,
	[FechaInicio] [datetime2](7) NOT NULL,
	[ID_Pedido] [int] NOT NULL,
	[ID_Sector] [int] NOT NULL,
	[EstadoOrden] [nvarchar](max) NULL,
	[FechaCerrado] [datetime2](7) NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NULL,
	[Active] [bit] NOT NULL,
	[CreateUser] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_OrdenDeTrabajo] PRIMARY KEY CLUSTERED 
(
	[ID_OrdenDeTrabajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdenDeTrabajoFabrica]    Script Date: 14/3/2023 22:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdenDeTrabajoFabrica](
	[ID_OrdenDeTrabajoFabrica] [int] NOT NULL,
	[FechaInicio] [datetime2](7) NOT NULL,
	[ID_PedidoFabrica] [int] NOT NULL,
	[ID_Sector] [int] NOT NULL,
	[EstadoOrden] [nvarchar](max) NULL,
	[FechaCerrado] [datetime2](7) NULL,
	[CreateUser] [uniqueidentifier] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_OrdenDeTrabajoFabrica] PRIMARY KEY CLUSTERED 
(
	[ID_OrdenDeTrabajoFabrica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedidos]    Script Date: 14/3/2023 22:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidos](
	[ID_Pedido] [int] IDENTITY(1,1) NOT NULL,
	[NumeroPedido] [int] NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[ID_Empleados] [uniqueidentifier] NOT NULL,
	[Seña] [decimal](18, 0) NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NULL,
	[Active] [bit] NOT NULL,
	[ID_EstadoPedido] [int] NOT NULL,
	[CreateUser] [uniqueidentifier] NOT NULL,
	[SubTotal] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Pedidos] PRIMARY KEY CLUSTERED 
(
	[ID_Pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PedidosFabrica]    Script Date: 14/3/2023 22:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PedidosFabrica](
	[ID_PedidosFabrica] [int] IDENTITY(1,1) NOT NULL,
	[ID_Empleados] [uniqueidentifier] NOT NULL,
	[Detalle] [varchar](100) NULL,
	[CreateUser] [uniqueidentifier] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_PedidosFabrica] PRIMARY KEY CLUSTERED 
(
	[ID_PedidosFabrica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 14/3/2023 22:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ID_Producto] [int] IDENTITY(1,1) NOT NULL,
	[CodigoProducto] [uniqueidentifier] NOT NULL,
	[Color] [varchar](100) NOT NULL,
	[Composicion] [varchar](50) NOT NULL,
	[Estampa] [varchar](50) NOT NULL,
	[NombreProducto] [varchar](50) NOT NULL,
	[Precio] [decimal](18, 0) NOT NULL,
	[Tejido] [varchar](50) NOT NULL,
	[TallePrenda] [varchar](50) NOT NULL,
	[TipoProducto] [varchar](50) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NULL,
	[Active] [bit] NOT NULL,
	[Stock] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoProveedor]    Script Date: 14/3/2023 22:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoProveedor](
	[ID_ProductoProveedor] [int] IDENTITY(1,1) NOT NULL,
	[CodigoProducto] [nvarchar](max) NULL,
	[NombreProducto] [varchar](50) NULL,
	[TipoTela] [varchar](50) NULL,
	[CantidadRollos] [nvarchar](max) NULL,
	[MarcaTela] [varchar](50) NULL,
	[Precio] [varchar](50) NULL,
	[ID_Proveedor] [int] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_ProductoProveedor] PRIMARY KEY CLUSTERED 
(
	[ID_ProductoProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 14/3/2023 22:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[ID_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[DNI] [varchar](50) NOT NULL,
	[EstadoProveedor] [varchar](50) NULL,
	[FechaNac] [datetime2](7) NOT NULL,
	[LugarEmpresa] [varchar](50) NULL,
	[Mail] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NULL,
	[Active] [bit] NOT NULL,
	[CreateUser] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[ID_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sector]    Script Date: 14/3/2023 22:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sector](
	[ID_Sector] [int] IDENTITY(1,1) NOT NULL,
	[NombreSector] [varchar](50) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Sector] PRIMARY KEY CLUSTERED 
(
	[ID_Sector] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 14/3/2023 22:49:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[ID_Venta] [int] IDENTITY(1,1) NOT NULL,
	[ID_Producto] [int] NOT NULL,
	[CapitalRecibido] [varchar](50) NULL,
	[FechaVenta] [datetime2](7) NULL,
	[Descripcion] [varchar](50) NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NULL,
	[Active] [bit] NOT NULL,
	[CreateUser] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[ID_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220508000733_InitialCreate_RecreateTables', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220509032857_Add_EstadoPedido_Alter_Pedidos', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220509153109_Add_CreateUser_Property', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220513225341_Alter_Pedidos', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230126034731_ALTER_UPDATEDATE', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230307192842_ALTER_TABLES', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230312054732_ADD_TABLES_FABRICA', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230315004005_ALTER_TABLES_RENAMECOLUMN', N'5.0.11')
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([ID_Cliente], [DNI], [Nombre], [Apellido], [EstadoCliente], [FechaNac], [Mail], [Telefono], [Residencia], [CreateDate], [UpdateDate], [Active]) VALUES (1, N'42886278', N'Julian', N'Molepo', N'Activo', CAST(N'2004-10-28T00:00:00.000' AS DateTime), N'julianMolepo@gmail.com', 1166783421, N'Ballester', CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Cliente] ([ID_Cliente], [DNI], [Nombre], [Apellido], [EstadoCliente], [FechaNac], [Mail], [Telefono], [Residencia], [CreateDate], [UpdateDate], [Active]) VALUES (2, N'30112423', N'Marcos', N'Polo', N'Activo', CAST(N'2001-04-10T00:00:00.000' AS DateTime), N'marcospolo@hotmail.com', 1195464363, N'Olivos', CAST(N'2022-12-31T00:00:00.0000000' AS DateTime2), CAST(N'2022-12-31T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[Cliente] ([ID_Cliente], [DNI], [Nombre], [Apellido], [EstadoCliente], [FechaNac], [Mail], [Telefono], [Residencia], [CreateDate], [UpdateDate], [Active]) VALUES (3, N'36934532', N'Gonzalo', N'Ibañez', N'Activo', CAST(N'2000-08-28T00:00:00.000' AS DateTime), N'gonzaloiba.28.00@gmail.com', 1166932542, N'Ballester', CAST(N'2022-12-31T00:00:00.0000000' AS DateTime2), CAST(N'2022-12-31T00:00:00.0000000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
INSERT [dbo].[Empleados] ([ID_Empleados], [Apellido], [Nombre], [Residencia], [Legajo], [DNI], [CreateDate], [UpdateDate], [Active]) VALUES (N'8ea0949a-98a8-423d-8f7a-5cf58609c3aa', N'PRUEBA', N'PRUEBA', N'Calle falsa 123', N'ASDR-JPT', N'12345678', CAST(N'2023-03-14T21:50:58.8400000' AS DateTime2), NULL, 1)
INSERT [dbo].[Empleados] ([ID_Empleados], [Apellido], [Nombre], [Residencia], [Legajo], [DNI], [CreateDate], [UpdateDate], [Active]) VALUES (N'923ee297-e3c7-4a26-8861-896c522498ad', N'Ibañez', N'Gonzalo', N'Villa Ballester', N'ABDG-1934', N'11111111', CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), 1)
GO
SET IDENTITY_INSERT [dbo].[EstadoPedido] ON 

INSERT [dbo].[EstadoPedido] ([ID_EstadoPedido], [Estado], [Active]) VALUES (1, N'Sin Asignar', 1)
INSERT [dbo].[EstadoPedido] ([ID_EstadoPedido], [Estado], [Active]) VALUES (2, N'En Producción', 1)
INSERT [dbo].[EstadoPedido] ([ID_EstadoPedido], [Estado], [Active]) VALUES (3, N'En Depósito', 1)
INSERT [dbo].[EstadoPedido] ([ID_EstadoPedido], [Estado], [Active]) VALUES (4, N'Entregado', 1)
INSERT [dbo].[EstadoPedido] ([ID_EstadoPedido], [Estado], [Active]) VALUES (5, N'Cancelado', 1)
SET IDENTITY_INSERT [dbo].[EstadoPedido] OFF
GO
SET IDENTITY_INSERT [dbo].[Pedidos] ON 

INSERT [dbo].[Pedidos] ([ID_Pedido], [NumeroPedido], [Fecha], [ID_Cliente], [ID_Empleados], [Seña], [CreateDate], [UpdateDate], [Active], [ID_EstadoPedido], [CreateUser], [SubTotal]) VALUES (33, 1, CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), 2, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(10 AS Decimal(18, 0)), CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), 1, 3, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Pedidos] ([ID_Pedido], [NumeroPedido], [Fecha], [ID_Cliente], [ID_Empleados], [Seña], [CreateDate], [UpdateDate], [Active], [ID_EstadoPedido], [CreateUser], [SubTotal]) VALUES (34, 2, CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), 1, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(1452 AS Decimal(18, 0)), CAST(N'2022-12-31T00:00:00.0000000' AS DateTime2), CAST(N'2022-12-31T00:00:00.0000000' AS DateTime2), 1, 1, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Pedidos] ([ID_Pedido], [NumeroPedido], [Fecha], [ID_Cliente], [ID_Empleados], [Seña], [CreateDate], [UpdateDate], [Active], [ID_EstadoPedido], [CreateUser], [SubTotal]) VALUES (35, 3, CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), 3, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(1421 AS Decimal(18, 0)), CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), 1, 1, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Pedidos] ([ID_Pedido], [NumeroPedido], [Fecha], [ID_Cliente], [ID_Empleados], [Seña], [CreateDate], [UpdateDate], [Active], [ID_EstadoPedido], [CreateUser], [SubTotal]) VALUES (36, 4, CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), 2, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)), CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), 1, 1, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Pedidos] ([ID_Pedido], [NumeroPedido], [Fecha], [ID_Cliente], [ID_Empleados], [Seña], [CreateDate], [UpdateDate], [Active], [ID_EstadoPedido], [CreateUser], [SubTotal]) VALUES (37, 5, CAST(N'2023-02-22T00:00:00.0000000' AS DateTime2), 1, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)), CAST(N'2023-02-22T00:00:00.0000000' AS DateTime2), CAST(N'2023-02-22T00:00:00.0000000' AS DateTime2), 1, 4, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Pedidos] ([ID_Pedido], [NumeroPedido], [Fecha], [ID_Cliente], [ID_Empleados], [Seña], [CreateDate], [UpdateDate], [Active], [ID_EstadoPedido], [CreateUser], [SubTotal]) VALUES (38, 6, CAST(N'2023-02-22T00:00:00.0000000' AS DateTime2), 2, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(10000 AS Decimal(18, 0)), CAST(N'2023-02-22T00:00:00.0000000' AS DateTime2), CAST(N'2023-02-22T00:00:00.0000000' AS DateTime2), 1, 2, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Pedidos] ([ID_Pedido], [NumeroPedido], [Fecha], [ID_Cliente], [ID_Empleados], [Seña], [CreateDate], [UpdateDate], [Active], [ID_EstadoPedido], [CreateUser], [SubTotal]) VALUES (39, 7, CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), 2, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)), CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), 1, 2, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Pedidos] ([ID_Pedido], [NumeroPedido], [Fecha], [ID_Cliente], [ID_Empleados], [Seña], [CreateDate], [UpdateDate], [Active], [ID_EstadoPedido], [CreateUser], [SubTotal]) VALUES (40, 8, CAST(N'2023-02-22T00:00:00.0000000' AS DateTime2), 3, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(5000 AS Decimal(18, 0)), CAST(N'2023-02-22T00:00:00.0000000' AS DateTime2), CAST(N'2023-02-22T00:00:00.0000000' AS DateTime2), 1, 3, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Pedidos] ([ID_Pedido], [NumeroPedido], [Fecha], [ID_Cliente], [ID_Empleados], [Seña], [CreateDate], [UpdateDate], [Active], [ID_EstadoPedido], [CreateUser], [SubTotal]) VALUES (41, 9, CAST(N'2023-02-22T00:00:00.0000000' AS DateTime2), 2, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(1000 AS Decimal(18, 0)), CAST(N'2023-02-22T00:00:00.0000000' AS DateTime2), CAST(N'2023-02-22T00:00:00.0000000' AS DateTime2), 1, 1, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Pedidos] ([ID_Pedido], [NumeroPedido], [Fecha], [ID_Cliente], [ID_Empleados], [Seña], [CreateDate], [UpdateDate], [Active], [ID_EstadoPedido], [CreateUser], [SubTotal]) VALUES (42, 10, CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), 1, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)), CAST(N'2023-02-22T00:00:00.0000000' AS DateTime2), CAST(N'2023-02-22T00:00:00.0000000' AS DateTime2), 1, 1, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Pedidos] ([ID_Pedido], [NumeroPedido], [Fecha], [ID_Cliente], [ID_Empleados], [Seña], [CreateDate], [UpdateDate], [Active], [ID_EstadoPedido], [CreateUser], [SubTotal]) VALUES (43, 11, CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), 1, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)), CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), 1, 3, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Pedidos] ([ID_Pedido], [NumeroPedido], [Fecha], [ID_Cliente], [ID_Empleados], [Seña], [CreateDate], [UpdateDate], [Active], [ID_EstadoPedido], [CreateUser], [SubTotal]) VALUES (44, 12, CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), 2, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(8000 AS Decimal(18, 0)), CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), 1, 4, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Pedidos] ([ID_Pedido], [NumeroPedido], [Fecha], [ID_Cliente], [ID_Empleados], [Seña], [CreateDate], [UpdateDate], [Active], [ID_EstadoPedido], [CreateUser], [SubTotal]) VALUES (45, 13, CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), 2, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(20000 AS Decimal(18, 0)), CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), 1, 4, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Pedidos] ([ID_Pedido], [NumeroPedido], [Fecha], [ID_Cliente], [ID_Empleados], [Seña], [CreateDate], [UpdateDate], [Active], [ID_EstadoPedido], [CreateUser], [SubTotal]) VALUES (46, 14, CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), 3, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)), CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), 1, 1, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Pedidos] ([ID_Pedido], [NumeroPedido], [Fecha], [ID_Cliente], [ID_Empleados], [Seña], [CreateDate], [UpdateDate], [Active], [ID_EstadoPedido], [CreateUser], [SubTotal]) VALUES (47, 15, CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), 1, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)), CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), 1, 1, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Pedidos] ([ID_Pedido], [NumeroPedido], [Fecha], [ID_Cliente], [ID_Empleados], [Seña], [CreateDate], [UpdateDate], [Active], [ID_EstadoPedido], [CreateUser], [SubTotal]) VALUES (48, 16, CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), 3, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(1 AS Decimal(18, 0)), CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), CAST(N'2023-02-23T00:00:00.0000000' AS DateTime2), 1, 2, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[Pedidos] ([ID_Pedido], [NumeroPedido], [Fecha], [ID_Cliente], [ID_Empleados], [Seña], [CreateDate], [UpdateDate], [Active], [ID_EstadoPedido], [CreateUser], [SubTotal]) VALUES (52, 17, CAST(N'2023-03-14T22:13:51.5743127' AS DateTime2), 1, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(10 AS Decimal(18, 0)), CAST(N'2023-03-14T22:13:51.6062536' AS DateTime2), NULL, 1, 1, N'923ee297-e3c7-4a26-8861-896c522498ad', CAST(100 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Pedidos] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([ID_Producto], [CodigoProducto], [Color], [Composicion], [Estampa], [NombreProducto], [Precio], [Tejido], [TallePrenda], [TipoProducto], [CreateDate], [UpdateDate], [Active], [Stock]) VALUES (1, N'952a5b23-089a-4169-b70c-fa96d5bac290', N'Color [White]', N'a', N'a', N'a', CAST(100 AS Decimal(18, 0)), N'a', N'a', N'a', CAST(N'2023-03-07T16:36:39.6190524' AS DateTime2), NULL, 1, 1000)
INSERT [dbo].[Producto] ([ID_Producto], [CodigoProducto], [Color], [Composicion], [Estampa], [NombreProducto], [Precio], [Tejido], [TallePrenda], [TipoProducto], [CreateDate], [UpdateDate], [Active], [Stock]) VALUES (2, N'3900dbca-b6df-4d99-864f-ea23d1ff7bb2', N'Color [Black]', N'a', N'a', N'ae', CAST(250 AS Decimal(18, 0)), N'a', N'a', N'a', CAST(N'2023-03-07T16:36:52.6989552' AS DateTime2), NULL, 1, 1000)
INSERT [dbo].[Producto] ([ID_Producto], [CodigoProducto], [Color], [Composicion], [Estampa], [NombreProducto], [Precio], [Tejido], [TallePrenda], [TipoProducto], [CreateDate], [UpdateDate], [Active], [Stock]) VALUES (3, N'1a9f272c-758b-4bd7-b9a9-2b3dcb1c50ed', N'Color [White]', N'asda', N'12312', N'asd', CAST(48 AS Decimal(18, 0)), N'asd', N'XS', N'2ad', CAST(N'2023-03-11T14:06:19.0714892' AS DateTime2), NULL, 1, 30)
INSERT [dbo].[Producto] ([ID_Producto], [CodigoProducto], [Color], [Composicion], [Estampa], [NombreProducto], [Precio], [Tejido], [TallePrenda], [TipoProducto], [CreateDate], [UpdateDate], [Active], [Stock]) VALUES (4, N'cb520f92-75a3-4bba-b110-3c461735c824', N'Color [White]', N'asda', N'12312', N'asde', CAST(64 AS Decimal(18, 0)), N'asd', N'L', N'2ad', CAST(N'2023-03-11T14:06:48.2547607' AS DateTime2), NULL, 1, 50)
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductoProveedor] ON 

INSERT [dbo].[ProductoProveedor] ([ID_ProductoProveedor], [CodigoProducto], [NombreProducto], [TipoTela], [CantidadRollos], [MarcaTela], [Precio], [ID_Proveedor], [CreateDate], [UpdateDate], [Active]) VALUES (4, N'12345', N'Juan', N'Tela', N'10', N'Pirulo', N'10000', 2, CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ProductoProveedor] ([ID_ProductoProveedor], [CodigoProducto], [NombreProducto], [TipoTela], [CantidadRollos], [MarcaTela], [Precio], [ID_Proveedor], [CreateDate], [UpdateDate], [Active]) VALUES (5, N'123', N'UAI', N'Tesla', N'5000', N'Loco', N'10', 2, CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), 1)
INSERT [dbo].[ProductoProveedor] ([ID_ProductoProveedor], [CodigoProducto], [NombreProducto], [TipoTela], [CantidadRollos], [MarcaTela], [Precio], [ID_Proveedor], [CreateDate], [UpdateDate], [Active]) VALUES (6, N'2234234', N'asdas', N'asdsg', N'122', N'aaaa', N'20', 3, CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[ProductoProveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON 

INSERT [dbo].[Proveedor] ([ID_Proveedor], [DNI], [EstadoProveedor], [FechaNac], [LugarEmpresa], [Mail], [Nombre], [CreateDate], [UpdateDate], [Active], [CreateUser]) VALUES (1, N'42886243', N'Activo', CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), N'Opa', N'asd@hotmail.com', N'aa', CAST(N'2022-06-05T21:00:39.6200000' AS DateTime2), CAST(N'2022-07-23T13:07:12.2804955' AS DateTime2), 1, N'9245fe4a-d402-451c-b9ed-9c1a04247482')
INSERT [dbo].[Proveedor] ([ID_Proveedor], [DNI], [EstadoProveedor], [FechaNac], [LugarEmpresa], [Mail], [Nombre], [CreateDate], [UpdateDate], [Active], [CreateUser]) VALUES (2, N'1111111', N'asd', CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), N'asd', N'add@gmail.com', N'ddd6', CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), CAST(N'2022-12-16T15:15:37.1789224' AS DateTime2), 1, N'00000000-0000-0000-0000-000000000000')
INSERT [dbo].[Proveedor] ([ID_Proveedor], [DNI], [EstadoProveedor], [FechaNac], [LugarEmpresa], [Mail], [Nombre], [CreateDate], [UpdateDate], [Active], [CreateUser]) VALUES (3, N'1111111', NULL, CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), N'asd', N'add@gmail.com', N'ddd6', CAST(N'2022-12-16T15:15:55.1155930' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, N'00000000-0000-0000-0000-000000000000')
INSERT [dbo].[Proveedor] ([ID_Proveedor], [DNI], [EstadoProveedor], [FechaNac], [LugarEmpresa], [Mail], [Nombre], [CreateDate], [UpdateDate], [Active], [CreateUser]) VALUES (4, N'1111111', NULL, CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), N'asd', N'add@gmail.com', N'ddd6', CAST(N'2022-12-16T15:18:23.1854617' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, N'00000000-0000-0000-0000-000000000000')
INSERT [dbo].[Proveedor] ([ID_Proveedor], [DNI], [EstadoProveedor], [FechaNac], [LugarEmpresa], [Mail], [Nombre], [CreateDate], [UpdateDate], [Active], [CreateUser]) VALUES (5, N'1111111', NULL, CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), N'asd', N'add@gmail.com', N'ddd6', CAST(N'2022-12-16T15:18:40.0312696' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, N'00000000-0000-0000-0000-000000000000')
INSERT [dbo].[Proveedor] ([ID_Proveedor], [DNI], [EstadoProveedor], [FechaNac], [LugarEmpresa], [Mail], [Nombre], [CreateDate], [UpdateDate], [Active], [CreateUser]) VALUES (6, N'1111111', NULL, CAST(N'2000-08-28T00:00:00.0000000' AS DateTime2), N'asdr', N'add@gmail.com', N'ddd6', CAST(N'2023-01-07T17:21:43.9700000' AS DateTime2), CAST(N'2023-02-15T23:46:37.3866667' AS DateTime2), 1, N'00000000-0000-0000-0000-000000000000')
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO
/****** Object:  Index [IX_DetallePedido_ID_Producto]    Script Date: 14/3/2023 22:49:52 ******/
CREATE NONCLUSTERED INDEX [IX_DetallePedido_ID_Producto] ON [dbo].[DetallePedido]
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DetallePedidoFabricas_ID_Producto]    Script Date: 14/3/2023 22:49:52 ******/
CREATE NONCLUSTERED INDEX [IX_DetallePedidoFabricas_ID_Producto] ON [dbo].[DetallePedidoFabricas]
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrdenDeTrabajoFabrica_ID_Sector]    Script Date: 14/3/2023 22:49:52 ******/
CREATE NONCLUSTERED INDEX [IX_OrdenDeTrabajoFabrica_ID_Sector] ON [dbo].[OrdenDeTrabajoFabrica]
(
	[ID_Sector] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Pedidos_ID_Cliente]    Script Date: 14/3/2023 22:49:52 ******/
CREATE NONCLUSTERED INDEX [IX_Pedidos_ID_Cliente] ON [dbo].[Pedidos]
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Pedidos_ID_Empleados]    Script Date: 14/3/2023 22:49:52 ******/
CREATE NONCLUSTERED INDEX [IX_Pedidos_ID_Empleados] ON [dbo].[Pedidos]
(
	[ID_Empleados] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Pedidos_ID_EstadoPedido]    Script Date: 14/3/2023 22:49:52 ******/
CREATE NONCLUSTERED INDEX [IX_Pedidos_ID_EstadoPedido] ON [dbo].[Pedidos]
(
	[ID_EstadoPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PedidosFabrica_ID_Empleados]    Script Date: 14/3/2023 22:49:52 ******/
CREATE NONCLUSTERED INDEX [IX_PedidosFabrica_ID_Empleados] ON [dbo].[PedidosFabrica]
(
	[ID_Empleados] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductoProveedor_ID_Proveedor]    Script Date: 14/3/2023 22:49:52 ******/
CREATE NONCLUSTERED INDEX [IX_ProductoProveedor_ID_Proveedor] ON [dbo].[ProductoProveedor]
(
	[ID_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Venta_ID_Producto]    Script Date: 14/3/2023 22:49:52 ******/
CREATE NONCLUSTERED INDEX [IX_Venta_ID_Producto] ON [dbo].[Venta]
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cliente] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Cliente] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[DetallePedido] ADD  DEFAULT ((0)) FOR [Cantidad]
GO
ALTER TABLE [dbo].[Empleados] ADD  DEFAULT (newid()) FOR [ID_Empleados]
GO
ALTER TABLE [dbo].[Empleados] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Empleados] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[EstadoPedido] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Factura] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Factura] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[OrdenDeTrabajo] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[OrdenDeTrabajo] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[OrdenDeTrabajo] ADD  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [CreateUser]
GO
ALTER TABLE [dbo].[OrdenDeTrabajoFabrica] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[OrdenDeTrabajoFabrica] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Pedidos] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [Fecha]
GO
ALTER TABLE [dbo].[Pedidos] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Pedidos] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Pedidos] ADD  DEFAULT ((0)) FOR [ID_EstadoPedido]
GO
ALTER TABLE [dbo].[Pedidos] ADD  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [CreateUser]
GO
ALTER TABLE [dbo].[Pedidos] ADD  DEFAULT ((0.0)) FOR [SubTotal]
GO
ALTER TABLE [dbo].[PedidosFabrica] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[PedidosFabrica] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT (newid()) FOR [CodigoProducto]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ('') FOR [Color]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ('') FOR [Composicion]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ('') FOR [Estampa]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ('') FOR [NombreProducto]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0.0)) FOR [Precio]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ('') FOR [Tejido]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ('') FOR [TallePrenda]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ('') FOR [TipoProducto]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [Stock]
GO
ALTER TABLE [dbo].[ProductoProveedor] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[ProductoProveedor] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Proveedor] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Proveedor] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Proveedor] ADD  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [CreateUser]
GO
ALTER TABLE [dbo].[Sector] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Sector] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Venta] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Venta] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Venta] ADD  DEFAULT ('00000000-0000-0000-0000-000000000000') FOR [CreateUser]
GO
ALTER TABLE [dbo].[DetallePedido]  WITH CHECK ADD  CONSTRAINT [FK_DetallePedido_Pedidos_ID_DetallePedido] FOREIGN KEY([ID_DetallePedido])
REFERENCES [dbo].[Pedidos] ([ID_Pedido])
GO
ALTER TABLE [dbo].[DetallePedido] CHECK CONSTRAINT [FK_DetallePedido_Pedidos_ID_DetallePedido]
GO
ALTER TABLE [dbo].[DetallePedido]  WITH CHECK ADD  CONSTRAINT [FK_DetallePedido_Producto_ID_Producto] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Producto] ([ID_Producto])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetallePedido] CHECK CONSTRAINT [FK_DetallePedido_Producto_ID_Producto]
GO
ALTER TABLE [dbo].[DetallePedidoFabricas]  WITH CHECK ADD  CONSTRAINT [FK_DetallePedidoFabricas_PedidosFabrica_ID_DetallePedidosFabrica] FOREIGN KEY([ID_DetallePedidosFabrica])
REFERENCES [dbo].[PedidosFabrica] ([ID_PedidosFabrica])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetallePedidoFabricas] CHECK CONSTRAINT [FK_DetallePedidoFabricas_PedidosFabrica_ID_DetallePedidosFabrica]
GO
ALTER TABLE [dbo].[DetallePedidoFabricas]  WITH CHECK ADD  CONSTRAINT [FK_DetallePedidoFabricas_Producto_ID_Producto] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Producto] ([ID_Producto])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetallePedidoFabricas] CHECK CONSTRAINT [FK_DetallePedidoFabricas_Producto_ID_Producto]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Pedidos_ID_Factura] FOREIGN KEY([ID_Factura])
REFERENCES [dbo].[Pedidos] ([ID_Pedido])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Pedidos_ID_Factura]
GO
ALTER TABLE [dbo].[OrdenDeTrabajo]  WITH CHECK ADD  CONSTRAINT [FK_OrdenDeTrabajo_Pedidos_ID_OrdenDeTrabajo] FOREIGN KEY([ID_OrdenDeTrabajo])
REFERENCES [dbo].[Pedidos] ([ID_Pedido])
GO
ALTER TABLE [dbo].[OrdenDeTrabajo] CHECK CONSTRAINT [FK_OrdenDeTrabajo_Pedidos_ID_OrdenDeTrabajo]
GO
ALTER TABLE [dbo].[OrdenDeTrabajo]  WITH CHECK ADD  CONSTRAINT [FK_OrdenDeTrabajo_Sector_ID_OrdenDeTrabajo] FOREIGN KEY([ID_OrdenDeTrabajo])
REFERENCES [dbo].[Sector] ([ID_Sector])
GO
ALTER TABLE [dbo].[OrdenDeTrabajo] CHECK CONSTRAINT [FK_OrdenDeTrabajo_Sector_ID_OrdenDeTrabajo]
GO
ALTER TABLE [dbo].[OrdenDeTrabajoFabrica]  WITH CHECK ADD  CONSTRAINT [FK_OrdenDeTrabajoFabrica_PedidosFabrica_ID_OrdenDeTrabajoFabrica] FOREIGN KEY([ID_OrdenDeTrabajoFabrica])
REFERENCES [dbo].[PedidosFabrica] ([ID_PedidosFabrica])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrdenDeTrabajoFabrica] CHECK CONSTRAINT [FK_OrdenDeTrabajoFabrica_PedidosFabrica_ID_OrdenDeTrabajoFabrica]
GO
ALTER TABLE [dbo].[OrdenDeTrabajoFabrica]  WITH CHECK ADD  CONSTRAINT [FK_OrdenDeTrabajoFabrica_Sector_ID_Sector] FOREIGN KEY([ID_Sector])
REFERENCES [dbo].[Sector] ([ID_Sector])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrdenDeTrabajoFabrica] CHECK CONSTRAINT [FK_OrdenDeTrabajoFabrica_Sector_ID_Sector]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Cliente_ID_Cliente] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Cliente] ([ID_Cliente])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Cliente_ID_Cliente]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_Empleados_ID_Empleados] FOREIGN KEY([ID_Empleados])
REFERENCES [dbo].[Empleados] ([ID_Empleados])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_Empleados_ID_Empleados]
GO
ALTER TABLE [dbo].[Pedidos]  WITH CHECK ADD  CONSTRAINT [FK_Pedidos_EstadoPedido_ID_EstadoPedido] FOREIGN KEY([ID_EstadoPedido])
REFERENCES [dbo].[EstadoPedido] ([ID_EstadoPedido])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pedidos] CHECK CONSTRAINT [FK_Pedidos_EstadoPedido_ID_EstadoPedido]
GO
ALTER TABLE [dbo].[PedidosFabrica]  WITH CHECK ADD  CONSTRAINT [FK_PedidosFabrica_Empleados_ID_Empleados] FOREIGN KEY([ID_Empleados])
REFERENCES [dbo].[Empleados] ([ID_Empleados])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PedidosFabrica] CHECK CONSTRAINT [FK_PedidosFabrica_Empleados_ID_Empleados]
GO
ALTER TABLE [dbo].[ProductoProveedor]  WITH CHECK ADD  CONSTRAINT [FK_ProductoProveedor_Proveedor_ID_Proveedor] FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[Proveedor] ([ID_Proveedor])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductoProveedor] CHECK CONSTRAINT [FK_ProductoProveedor_Proveedor_ID_Proveedor]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Producto_ID_Producto] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Producto] ([ID_Producto])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Producto_ID_Producto]
GO
USE [master]
GO
ALTER DATABASE [DBProyectoTextil3] SET  READ_WRITE 
GO
