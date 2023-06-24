USE [master]
GO
/****** Object:  Database [DBProyectoTextil]    Script Date: 23/6/2023 21:54:57 ******/
CREATE DATABASE [DBProyectoTextil]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBProyectoTextil', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DBProyectoTextil.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBProyectoTextil_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DBProyectoTextil_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DBProyectoTextil] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBProyectoTextil].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBProyectoTextil] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBProyectoTextil] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBProyectoTextil] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBProyectoTextil] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBProyectoTextil] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBProyectoTextil] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBProyectoTextil] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBProyectoTextil] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBProyectoTextil] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBProyectoTextil] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBProyectoTextil] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBProyectoTextil] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBProyectoTextil] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBProyectoTextil] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBProyectoTextil] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBProyectoTextil] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBProyectoTextil] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBProyectoTextil] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBProyectoTextil] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBProyectoTextil] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBProyectoTextil] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [DBProyectoTextil] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBProyectoTextil] SET RECOVERY FULL 
GO
ALTER DATABASE [DBProyectoTextil] SET  MULTI_USER 
GO
ALTER DATABASE [DBProyectoTextil] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBProyectoTextil] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBProyectoTextil] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBProyectoTextil] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBProyectoTextil] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBProyectoTextil] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBProyectoTextil', N'ON'
GO
ALTER DATABASE [DBProyectoTextil] SET QUERY_STORE = OFF
GO
USE [DBProyectoTextil]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 23/6/2023 21:54:57 ******/
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
/****** Object:  Table [dbo].[BolsilloInterior]    Script Date: 23/6/2023 21:54:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BolsilloInterior](
	[ID_BolsilloInterior] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Codigo] [varchar](100) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_BolsilloInterior] PRIMARY KEY CLUSTERED 
(
	[ID_BolsilloInterior] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 23/6/2023 21:54:57 ******/
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
/****** Object:  Table [dbo].[DetallePedido]    Script Date: 23/6/2023 21:54:57 ******/
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
/****** Object:  Table [dbo].[DetallePedidoFabricas]    Script Date: 23/6/2023 21:54:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallePedidoFabricas](
	[ID_DetallePedidosFabrica] [int] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[Empleados]    Script Date: 23/6/2023 21:54:57 ******/
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
/****** Object:  Table [dbo].[EstadoPedido]    Script Date: 23/6/2023 21:54:57 ******/
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
/****** Object:  Table [dbo].[EstadoPedidoFabrica]    Script Date: 23/6/2023 21:54:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoPedidoFabrica](
	[ID_EstadoPedidoFabrica] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [varchar](50) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_EstadoPedidoFabrica] PRIMARY KEY CLUSTERED 
(
	[ID_EstadoPedidoFabrica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 23/6/2023 21:54:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[ID_Factura] [int] NOT NULL,
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
/****** Object:  Table [dbo].[HistorialPedidos]    Script Date: 23/6/2023 21:54:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistorialPedidos](
	[ID_HistorialPedidos] [int] IDENTITY(1,1) NOT NULL,
	[ID_Pedido] [int] NOT NULL,
	[ID_EstadoPedido] [int] NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_HistorialPedidos] PRIMARY KEY CLUSTERED 
(
	[ID_HistorialPedidos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lazo]    Script Date: 23/6/2023 21:54:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lazo](
	[ID_Lazo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Codigo] [varchar](100) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Lazo] PRIMARY KEY CLUSTERED 
(
	[ID_Lazo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdenDeTrabajo]    Script Date: 23/6/2023 21:54:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdenDeTrabajo](
	[ID_OrdenDeTrabajo] [int] NOT NULL,
	[FechaInicio] [datetime2](7) NOT NULL,
	[ID_Pedido] [int] NOT NULL,
	[ID_Sector] [int] NOT NULL,
	[EstadoOrden] [nvarchar](max) NULL,
	[FechaCerrado] [datetime2](7) NULL,
	[CreateUser] [uniqueidentifier] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_OrdenDeTrabajo] PRIMARY KEY CLUSTERED 
(
	[ID_OrdenDeTrabajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdenDeTrabajoFabrica]    Script Date: 23/6/2023 21:54:57 ******/
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
/****** Object:  Table [dbo].[Pedidos]    Script Date: 23/6/2023 21:54:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedidos](
	[ID_Pedido] [int] IDENTITY(1,1) NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[ID_Empleados] [uniqueidentifier] NOT NULL,
	[ID_EstadoPedido] [int] NOT NULL,
	[NumeroPedido] [int] NOT NULL,
	[SubTotal] [decimal](18, 0) NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
	[Seña] [decimal](18, 0) NULL,
	[CreateUser] [uniqueidentifier] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Pedidos] PRIMARY KEY CLUSTERED 
(
	[ID_Pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PedidosFabrica]    Script Date: 23/6/2023 21:54:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PedidosFabrica](
	[ID_PedidosFabrica] [int] IDENTITY(1,1) NOT NULL,
	[ID_Empleados] [uniqueidentifier] NOT NULL,
	[ID_EstadoPedidoFabrica] [int] NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
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
/****** Object:  Table [dbo].[Producto]    Script Date: 23/6/2023 21:54:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ID_Producto] [int] IDENTITY(1,1) NOT NULL,
	[CodigoProducto] [uniqueidentifier] NOT NULL,
	[Color] [varchar](100) NOT NULL,
	[Precio] [decimal](18, 0) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[TallePrenda] [varchar](50) NOT NULL,
	[Stock] [int] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NULL,
	[Active] [bit] NOT NULL,
	[ID_BolsilloInterior] [int] NOT NULL,
	[ID_TipoPrenda] [int] NOT NULL,
	[ID_Lazo] [int] NOT NULL,
	[ID_TelaBase] [int] NOT NULL,
	[ID_TelaCombinacion] [int] NOT NULL,
	[ID_Transfer] [int] NOT NULL,
	[ID_Vivo] [int] NOT NULL,
	[ImagenPrenda] [varchar](max) NOT NULL,
	[Composicion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoProveedor]    Script Date: 23/6/2023 21:54:57 ******/
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
/****** Object:  Table [dbo].[Proveedor]    Script Date: 23/6/2023 21:54:57 ******/
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
	[CreateUser] [uniqueidentifier] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[ID_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sector]    Script Date: 23/6/2023 21:54:57 ******/
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
/****** Object:  Table [dbo].[TelaBase]    Script Date: 23/6/2023 21:54:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TelaBase](
	[ID_TelaBase] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Codigo] [varchar](100) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_TelaBase] PRIMARY KEY CLUSTERED 
(
	[ID_TelaBase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TelaCombinacion]    Script Date: 23/6/2023 21:54:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TelaCombinacion](
	[ID_TelaCombinacion] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Codigo] [varchar](100) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_TelaCombinacion] PRIMARY KEY CLUSTERED 
(
	[ID_TelaCombinacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoPrenda]    Script Date: 23/6/2023 21:54:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPrenda](
	[ID_TipoPrenda] [int] IDENTITY(1,1) NOT NULL,
	[TipoPrenda] [varchar](100) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_TipoPrenda] PRIMARY KEY CLUSTERED 
(
	[ID_TipoPrenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transfer]    Script Date: 23/6/2023 21:54:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transfer](
	[ID_Transfer] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](50) NOT NULL,
	[Imagen] [varchar](max) NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Transfer] PRIMARY KEY CLUSTERED 
(
	[ID_Transfer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 23/6/2023 21:54:57 ******/
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
	[CreateUser] [uniqueidentifier] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[ID_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vivo]    Script Date: 23/6/2023 21:54:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vivo](
	[ID_Vivo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Codigo] [varchar](100) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Vivo] PRIMARY KEY CLUSTERED 
(
	[ID_Vivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230315195910_InitialCreate', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230319051503_ADD_TABLE_HISTORIALPEDIDOS', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230326215414_ADD_TABLES_EXTRA_PRODUCTO', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230327003651_DELETE_TABLE_COMPOSICION', N'5.0.11')
GO
INSERT [dbo].[Empleados] ([ID_Empleados], [Apellido], [Nombre], [Residencia], [Legajo], [DNI], [CreateDate], [UpdateDate], [Active]) VALUES (N'3e0cef31-fa59-4fd7-9b01-ea4b6816239f', N'PRUEBA', N'PRUEBA', N'Calle falsa 123', N'ASDR-JPT', N'12345678', CAST(N'2023-03-27T00:37:14.4933333' AS DateTime2), NULL, 1)
GO
SET IDENTITY_INSERT [dbo].[EstadoPedido] ON 

INSERT [dbo].[EstadoPedido] ([ID_EstadoPedido], [Estado], [Active]) VALUES (1, N'SinAsignar', 1)
INSERT [dbo].[EstadoPedido] ([ID_EstadoPedido], [Estado], [Active]) VALUES (2, N'EnProducción', 1)
INSERT [dbo].[EstadoPedido] ([ID_EstadoPedido], [Estado], [Active]) VALUES (3, N'EnDepósito', 1)
INSERT [dbo].[EstadoPedido] ([ID_EstadoPedido], [Estado], [Active]) VALUES (4, N'Entregado', 1)
INSERT [dbo].[EstadoPedido] ([ID_EstadoPedido], [Estado], [Active]) VALUES (5, N'Cancelado', 1)
SET IDENTITY_INSERT [dbo].[EstadoPedido] OFF
GO
SET IDENTITY_INSERT [dbo].[EstadoPedidoFabrica] ON 

INSERT [dbo].[EstadoPedidoFabrica] ([ID_EstadoPedidoFabrica], [Estado], [Active]) VALUES (1, N'EnDepósito', 1)
INSERT [dbo].[EstadoPedidoFabrica] ([ID_EstadoPedidoFabrica], [Estado], [Active]) VALUES (2, N'Terminado', 1)
INSERT [dbo].[EstadoPedidoFabrica] ([ID_EstadoPedidoFabrica], [Estado], [Active]) VALUES (3, N'EnProducción', 1)
INSERT [dbo].[EstadoPedidoFabrica] ([ID_EstadoPedidoFabrica], [Estado], [Active]) VALUES (4, N'SinAsignar', 1)
SET IDENTITY_INSERT [dbo].[EstadoPedidoFabrica] OFF
GO
/****** Object:  Index [IX_DetallePedido_ID_Pedido]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_DetallePedido_ID_Pedido] ON [dbo].[DetallePedido]
(
	[ID_Pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DetallePedido_ID_Producto]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_DetallePedido_ID_Producto] ON [dbo].[DetallePedido]
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DetallePedidoFabricas_ID_PedidosFabrica]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_DetallePedidoFabricas_ID_PedidosFabrica] ON [dbo].[DetallePedidoFabricas]
(
	[ID_PedidosFabrica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DetallePedidoFabricas_ID_Producto]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_DetallePedidoFabricas_ID_Producto] ON [dbo].[DetallePedidoFabricas]
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_HistorialPedidos_ID_EstadoPedido]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_HistorialPedidos_ID_EstadoPedido] ON [dbo].[HistorialPedidos]
(
	[ID_EstadoPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_HistorialPedidos_ID_Pedido]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_HistorialPedidos_ID_Pedido] ON [dbo].[HistorialPedidos]
(
	[ID_Pedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrdenDeTrabajoFabrica_ID_Sector]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_OrdenDeTrabajoFabrica_ID_Sector] ON [dbo].[OrdenDeTrabajoFabrica]
(
	[ID_Sector] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Pedidos_ID_Cliente]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_Pedidos_ID_Cliente] ON [dbo].[Pedidos]
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Pedidos_ID_Empleados]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_Pedidos_ID_Empleados] ON [dbo].[Pedidos]
(
	[ID_Empleados] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Pedidos_ID_EstadoPedido]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_Pedidos_ID_EstadoPedido] ON [dbo].[Pedidos]
(
	[ID_EstadoPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PedidosFabrica_ID_Empleados]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_PedidosFabrica_ID_Empleados] ON [dbo].[PedidosFabrica]
(
	[ID_Empleados] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PedidosFabrica_ID_EstadoPedidoFabrica]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_PedidosFabrica_ID_EstadoPedidoFabrica] ON [dbo].[PedidosFabrica]
(
	[ID_EstadoPedidoFabrica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Producto_ID_BolsilloInterior]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_Producto_ID_BolsilloInterior] ON [dbo].[Producto]
(
	[ID_BolsilloInterior] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Producto_ID_Lazo]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_Producto_ID_Lazo] ON [dbo].[Producto]
(
	[ID_Lazo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Producto_ID_TelaBase]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_Producto_ID_TelaBase] ON [dbo].[Producto]
(
	[ID_TelaBase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Producto_ID_TelaCombinacion]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_Producto_ID_TelaCombinacion] ON [dbo].[Producto]
(
	[ID_TelaCombinacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Producto_ID_TipoPrenda]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_Producto_ID_TipoPrenda] ON [dbo].[Producto]
(
	[ID_TipoPrenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Producto_ID_Transfer]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_Producto_ID_Transfer] ON [dbo].[Producto]
(
	[ID_Transfer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Producto_ID_Vivo]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_Producto_ID_Vivo] ON [dbo].[Producto]
(
	[ID_Vivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductoProveedor_ID_Proveedor]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_ProductoProveedor_ID_Proveedor] ON [dbo].[ProductoProveedor]
(
	[ID_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Venta_ID_Producto]    Script Date: 23/6/2023 21:54:58 ******/
CREATE NONCLUSTERED INDEX [IX_Venta_ID_Producto] ON [dbo].[Venta]
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BolsilloInterior] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Cliente] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Cliente] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Empleados] ADD  DEFAULT (newid()) FOR [ID_Empleados]
GO
ALTER TABLE [dbo].[Empleados] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Empleados] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[EstadoPedido] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[EstadoPedidoFabrica] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Factura] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Factura] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[HistorialPedidos] ADD  DEFAULT (getdate()) FOR [Fecha]
GO
ALTER TABLE [dbo].[Lazo] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[OrdenDeTrabajo] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[OrdenDeTrabajo] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[OrdenDeTrabajoFabrica] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[OrdenDeTrabajoFabrica] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Pedidos] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Pedidos] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[PedidosFabrica] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[PedidosFabrica] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT (newid()) FOR [CodigoProducto]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [Stock]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [ID_BolsilloInterior]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [ID_TipoPrenda]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [ID_Lazo]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [ID_TelaBase]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [ID_TelaCombinacion]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [ID_Transfer]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ((0)) FOR [ID_Vivo]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ('') FOR [ImagenPrenda]
GO
ALTER TABLE [dbo].[Producto] ADD  DEFAULT ('') FOR [Composicion]
GO
ALTER TABLE [dbo].[ProductoProveedor] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[ProductoProveedor] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Proveedor] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Proveedor] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Sector] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Sector] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[TelaBase] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[TelaCombinacion] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[TipoPrenda] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Transfer] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Transfer] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Venta] ADD  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Venta] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[Vivo] ADD  DEFAULT (CONVERT([bit],(1))) FOR [Active]
GO
ALTER TABLE [dbo].[DetallePedido]  WITH CHECK ADD  CONSTRAINT [FK_DetallePedido_Pedidos_ID_Pedido] FOREIGN KEY([ID_Pedido])
REFERENCES [dbo].[Pedidos] ([ID_Pedido])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetallePedido] CHECK CONSTRAINT [FK_DetallePedido_Pedidos_ID_Pedido]
GO
ALTER TABLE [dbo].[DetallePedido]  WITH CHECK ADD  CONSTRAINT [FK_DetallePedido_Producto_ID_Producto] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Producto] ([ID_Producto])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetallePedido] CHECK CONSTRAINT [FK_DetallePedido_Producto_ID_Producto]
GO
ALTER TABLE [dbo].[DetallePedidoFabricas]  WITH CHECK ADD  CONSTRAINT [FK_DetallePedidoFabricas_PedidosFabrica_ID_PedidosFabrica] FOREIGN KEY([ID_PedidosFabrica])
REFERENCES [dbo].[PedidosFabrica] ([ID_PedidosFabrica])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetallePedidoFabricas] CHECK CONSTRAINT [FK_DetallePedidoFabricas_PedidosFabrica_ID_PedidosFabrica]
GO
ALTER TABLE [dbo].[DetallePedidoFabricas]  WITH CHECK ADD  CONSTRAINT [FK_DetallePedidoFabricas_Producto_ID_Producto] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Producto] ([ID_Producto])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetallePedidoFabricas] CHECK CONSTRAINT [FK_DetallePedidoFabricas_Producto_ID_Producto]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Pedidos_ID_Factura] FOREIGN KEY([ID_Factura])
REFERENCES [dbo].[Pedidos] ([ID_Pedido])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Pedidos_ID_Factura]
GO
ALTER TABLE [dbo].[HistorialPedidos]  WITH CHECK ADD  CONSTRAINT [FK_HistorialPedidos_EstadoPedido_ID_EstadoPedido] FOREIGN KEY([ID_EstadoPedido])
REFERENCES [dbo].[EstadoPedido] ([ID_EstadoPedido])
GO
ALTER TABLE [dbo].[HistorialPedidos] CHECK CONSTRAINT [FK_HistorialPedidos_EstadoPedido_ID_EstadoPedido]
GO
ALTER TABLE [dbo].[HistorialPedidos]  WITH CHECK ADD  CONSTRAINT [FK_HistorialPedidos_Pedidos_ID_Pedido] FOREIGN KEY([ID_Pedido])
REFERENCES [dbo].[Pedidos] ([ID_Pedido])
GO
ALTER TABLE [dbo].[HistorialPedidos] CHECK CONSTRAINT [FK_HistorialPedidos_Pedidos_ID_Pedido]
GO
ALTER TABLE [dbo].[OrdenDeTrabajo]  WITH CHECK ADD  CONSTRAINT [FK_OrdenDeTrabajo_Pedidos_ID_OrdenDeTrabajo] FOREIGN KEY([ID_OrdenDeTrabajo])
REFERENCES [dbo].[Pedidos] ([ID_Pedido])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrdenDeTrabajo] CHECK CONSTRAINT [FK_OrdenDeTrabajo_Pedidos_ID_OrdenDeTrabajo]
GO
ALTER TABLE [dbo].[OrdenDeTrabajo]  WITH CHECK ADD  CONSTRAINT [FK_OrdenDeTrabajo_Sector_ID_OrdenDeTrabajo] FOREIGN KEY([ID_OrdenDeTrabajo])
REFERENCES [dbo].[Sector] ([ID_Sector])
ON DELETE CASCADE
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
ALTER TABLE [dbo].[PedidosFabrica]  WITH CHECK ADD  CONSTRAINT [FK_PedidosFabrica_EstadoPedidoFabrica_ID_EstadoPedidoFabrica] FOREIGN KEY([ID_EstadoPedidoFabrica])
REFERENCES [dbo].[EstadoPedidoFabrica] ([ID_EstadoPedidoFabrica])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PedidosFabrica] CHECK CONSTRAINT [FK_PedidosFabrica_EstadoPedidoFabrica_ID_EstadoPedidoFabrica]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_BolsilloInterior_ID_BolsilloInterior] FOREIGN KEY([ID_BolsilloInterior])
REFERENCES [dbo].[BolsilloInterior] ([ID_BolsilloInterior])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_BolsilloInterior_ID_BolsilloInterior]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Lazo_ID_Lazo] FOREIGN KEY([ID_Lazo])
REFERENCES [dbo].[Lazo] ([ID_Lazo])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Lazo_ID_Lazo]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_TelaBase_ID_TelaBase] FOREIGN KEY([ID_TelaBase])
REFERENCES [dbo].[TelaBase] ([ID_TelaBase])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_TelaBase_ID_TelaBase]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_TelaCombinacion_ID_TelaCombinacion] FOREIGN KEY([ID_TelaCombinacion])
REFERENCES [dbo].[TelaCombinacion] ([ID_TelaCombinacion])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_TelaCombinacion_ID_TelaCombinacion]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_TipoPrenda_ID_TipoPrenda] FOREIGN KEY([ID_TipoPrenda])
REFERENCES [dbo].[TipoPrenda] ([ID_TipoPrenda])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_TipoPrenda_ID_TipoPrenda]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Transfer_ID_Transfer] FOREIGN KEY([ID_Transfer])
REFERENCES [dbo].[Transfer] ([ID_Transfer])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Transfer_ID_Transfer]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Vivo_ID_Vivo] FOREIGN KEY([ID_Vivo])
REFERENCES [dbo].[Vivo] ([ID_Vivo])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Vivo_ID_Vivo]
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
ALTER DATABASE [DBProyectoTextil] SET  READ_WRITE 
GO
