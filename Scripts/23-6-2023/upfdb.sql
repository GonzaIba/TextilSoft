USE [master]
GO
/****** Object:  Database [upf]    Script Date: 23/6/2023 21:56:05 ******/
CREATE DATABASE [upf]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'upf', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\upf.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'upf_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\upf_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [upf] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [upf].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [upf] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [upf] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [upf] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [upf] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [upf] SET ARITHABORT OFF 
GO
ALTER DATABASE [upf] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [upf] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [upf] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [upf] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [upf] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [upf] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [upf] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [upf] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [upf] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [upf] SET  DISABLE_BROKER 
GO
ALTER DATABASE [upf] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [upf] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [upf] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [upf] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [upf] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [upf] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [upf] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [upf] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [upf] SET  MULTI_USER 
GO
ALTER DATABASE [upf] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [upf] SET DB_CHAINING OFF 
GO
ALTER DATABASE [upf] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [upf] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [upf] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [upf] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'upf', N'ON'
GO
ALTER DATABASE [upf] SET QUERY_STORE = OFF
GO
USE [upf]
GO
/****** Object:  User [testUser2]    Script Date: 23/6/2023 21:56:05 ******/
CREATE USER [testUser2] FOR LOGIN [testUser2] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [testUser]    Script Date: 23/6/2023 21:56:05 ******/
CREATE USER [testUser] FOR LOGIN [testUser] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [testUser2]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 23/6/2023 21:56:05 ******/
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
/****** Object:  Table [dbo].[Company]    Script Date: 23/6/2023 21:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[CompanyId] [int] NOT NULL,
	[CompanyName] [varchar](200) NOT NULL,
	[CompanyCuil] [varchar](50) NOT NULL,
	[CompanyPhone] [varchar](50) NULL,
	[CompanyMail] [varchar](250) NULL,
	[CompanyLocation] [varchar](250) NULL,
	[CompanyApiKey] [varchar](64) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanyAuthentication]    Script Date: 23/6/2023 21:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyAuthentication](
	[CompanyAuthenticationId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyId] [int] NOT NULL,
	[CanUseLoginAndRegister] [bit] NOT NULL,
	[UserRequireUniqueEmail] [bit] NOT NULL,
	[SignInRequireConfirmedAccount] [bit] NOT NULL,
	[MaxFailedAccessAttempts] [int] NOT NULL,
 CONSTRAINT [PK_CompanyAuthentication] PRIMARY KEY CLUSTERED 
(
	[CompanyAuthenticationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanyCustomize]    Script Date: 23/6/2023 21:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyCustomize](
	[CompanyCustomizeId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyId] [int] NOT NULL,
	[CompanyLogo] [varchar](max) NULL,
	[CompanyColor] [varchar](50) NULL,
 CONSTRAINT [PK_CompanyCustomize] PRIMARY KEY CLUSTERED 
(
	[CompanyCustomizeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanyPasswordConfig]    Script Date: 23/6/2023 21:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyPasswordConfig](
	[CompanyPasswordConfigId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyAuthenticationId] [int] NOT NULL,
	[CountLength] [int] NOT NULL,
	[RequireNonAlphanumeric] [bit] NOT NULL,
	[RequireLowercase] [bit] NOT NULL,
	[RequireUppercase] [bit] NOT NULL,
	[RequireDigit] [bit] NOT NULL,
 CONSTRAINT [PK_CompanyPasswordConfig] PRIMARY KEY CLUSTERED 
(
	[CompanyPasswordConfigId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanySendGridConfiguration]    Script Date: 23/6/2023 21:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanySendGridConfiguration](
	[CompanySendGridConfigId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyId] [int] NOT NULL,
	[ApiKey] [varchar](500) NOT NULL,
	[From] [varchar](100) NOT NULL,
	[DisplayName] [varchar](50) NOT NULL,
	[ApiKeyId] [varchar](500) NOT NULL,
 CONSTRAINT [PK_CompanySendGridConfiguration] PRIMARY KEY CLUSTERED 
(
	[CompanySendGridConfigId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logs]    Script Date: 23/6/2023 21:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs](
	[LoggerId] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Thread] [varchar](500) NOT NULL,
	[Level] [varchar](500) NOT NULL,
	[Logger] [varchar](500) NOT NULL,
	[Message] [varchar](max) NOT NULL,
	[Exception] [varchar](max) NULL,
	[CompanyId] [int] NOT NULL,
 CONSTRAINT [PK_Logs] PRIMARY KEY CLUSTERED 
(
	[LoggerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permiso]    Script Date: 23/6/2023 21:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permiso](
	[nombre] [varchar](100) NULL,
	[id_permiso] [int] IDENTITY(1,1) NOT NULL,
	[permiso] [varchar](50) NULL,
	[CompanyId] [int] NOT NULL,
 CONSTRAINT [PK_permiso_1] PRIMARY KEY CLUSTERED 
(
	[id_permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permiso_permiso]    Script Date: 23/6/2023 21:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permiso_permiso](
	[id_permiso_permiso] [int] IDENTITY(1,1) NOT NULL,
	[id_permiso_padre] [int] NULL,
	[id_permiso_hijo] [int] NULL,
 CONSTRAINT [PK_permiso_permiso] PRIMARY KEY CLUSTERED 
(
	[id_permiso_permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 23/6/2023 21:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[CompanyId] [int] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Contraseña] [varchar](200) NOT NULL,
	[Email] [varchar](200) NULL,
	[DNI] [int] NOT NULL,
	[AccesFailed] [int] NOT NULL,
	[EmailConfirmado] [bit] NOT NULL,
	[DateTimeEmail] [datetime] NULL,
	[NumeroTeléfono] [varchar](50) NULL,
	[IsOwner] [bit] NOT NULL,
	[Active] [bit] NOT NULL,
	[DateDisabledUser] [datetime] NULL,
	[VerifyCode] [int] NULL,
	[EnableAnimators] [bit] NOT NULL,
	[EnableSlicePanel] [bit] NOT NULL,
	[EnableVolume] [bit] NOT NULL,
	[Volume] [int] NOT NULL,
	[IdiomaSeleccionado] [varchar](10) NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios_permisos]    Script Date: 23/6/2023 21:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios_permisos](
	[id_usuario] [int] NOT NULL,
	[id_permiso] [int] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220724184010_ADD_COMPANY', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220724213608_ALTER_PERMISOS', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220725225956_ADD_COMPANYCUSTOMIZE', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230117174310_ALTER_USER_COMPANYCUSTOMIZE', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230119004113_ADD_COMPANYAUTHENTICATION_COMPANYPASSWORDCONFIG', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230122215939_ALTER_USERMODEL', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230226020347_ALTER_USERMODEL_ADD', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230315014634_ALTER_USER_ADDCOLUMN', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230319134835_ADD_TABLE_SENDGRID', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230319145107_ADD_TABLE_LOGS', N'5.0.11')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230319145535_ALTER_TABLE_LOGS', N'5.0.11')
GO
INSERT [dbo].[Company] ([CompanyId], [CompanyName], [CompanyCuil], [CompanyPhone], [CompanyMail], [CompanyLocation], [CompanyApiKey], [Active]) VALUES (200, N'TextilSoft', N'22222222', N'1598547685', N'gonza_28.00@hotmail.com', N'Rawson 92', N'SV.JASBCFSBDFIUSGBYBUICJSDF', 1)
INSERT [dbo].[Company] ([CompanyId], [CompanyName], [CompanyCuil], [CompanyPhone], [CompanyMail], [CompanyLocation], [CompanyApiKey], [Active]) VALUES (300, N'SoftSolutions', N'11111111', N'1544345434', N'gonza_28.00@hotmail.com', N'Roma 1243', N'SV.423KJHASHSUFBUSFa', 1)
GO
SET IDENTITY_INSERT [dbo].[CompanyAuthentication] ON 

INSERT [dbo].[CompanyAuthentication] ([CompanyAuthenticationId], [CompanyId], [CanUseLoginAndRegister], [UserRequireUniqueEmail], [SignInRequireConfirmedAccount], [MaxFailedAccessAttempts]) VALUES (1, 200, 1, 1, 1, 5)
INSERT [dbo].[CompanyAuthentication] ([CompanyAuthenticationId], [CompanyId], [CanUseLoginAndRegister], [UserRequireUniqueEmail], [SignInRequireConfirmedAccount], [MaxFailedAccessAttempts]) VALUES (3, 300, 1, 1, 1, 10)
SET IDENTITY_INSERT [dbo].[CompanyAuthentication] OFF
GO
SET IDENTITY_INSERT [dbo].[CompanyCustomize] ON 

INSERT [dbo].[CompanyCustomize] ([CompanyCustomizeId], [CompanyId], [CompanyLogo], [CompanyColor]) VALUES (1, 300, N'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', N'Blue')
INSERT [dbo].[CompanyCustomize] ([CompanyCustomizeId], [CompanyId], [CompanyLogo], [CompanyColor]) VALUES (2, 200, N'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', N'Black')
SET IDENTITY_INSERT [dbo].[CompanyCustomize] OFF
GO
SET IDENTITY_INSERT [dbo].[CompanyPasswordConfig] ON 

INSERT [dbo].[CompanyPasswordConfig] ([CompanyPasswordConfigId], [CompanyAuthenticationId], [CountLength], [RequireNonAlphanumeric], [RequireLowercase], [RequireUppercase], [RequireDigit]) VALUES (1, 1, 2, 0, 0, 0, 0)
INSERT [dbo].[CompanyPasswordConfig] ([CompanyPasswordConfigId], [CompanyAuthenticationId], [CountLength], [RequireNonAlphanumeric], [RequireLowercase], [RequireUppercase], [RequireDigit]) VALUES (2, 3, 9, 1, 0, 0, 1)
SET IDENTITY_INSERT [dbo].[CompanyPasswordConfig] OFF
GO
SET IDENTITY_INSERT [dbo].[CompanySendGridConfiguration] ON 

INSERT [dbo].[CompanySendGridConfiguration] ([CompanySendGridConfigId], [CompanyId], [ApiKey], [From], [DisplayName], [ApiKeyId]) VALUES (1, 200, N'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', N'elaiasmurf10@hotmail.com', N'Elaias Murf', N'L0vrtjdrQ42l5119_TvkpQ')
SET IDENTITY_INSERT [dbo].[CompanySendGridConfiguration] OFF
GO
SET IDENTITY_INSERT [dbo].[Logs] ON 

INSERT [dbo].[Logs] ([LoggerId], [Date], [Thread], [Level], [Logger], [Message], [Exception], [CompanyId]) VALUES (2, CAST(N'2023-03-19T11:57:20.1400000' AS DateTime2), N'   at UI.TextilSoft.Controllers.PedidosController`1.ObtenerPedidos(Int32 pageIndex, Int32 pageCount, Expression`1 filterExpression, String orderBy, Boolean ascending, Boolean EsPedido) in D:\Repositorios-SmartGit\TextilSoft\Aplicacion\UI.TextilSoft\Controllers\PedidosController.cs:line 109', N'aa', N'??', N'Usuario: Leopoldo:11111111 Ocurrió un error fatal al obtener pedidosUnable to cast object of type ''Domain.GenericEntity.PaginatedList`1[Domain.Entities.ListarPedidosFabricaEntity]'' to type ''Domain.GenericEntity.PaginatedList`1[Domain.Entities.ListarPedidosEntity]''.', N'InvalidCastException', 200)
INSERT [dbo].[Logs] ([LoggerId], [Date], [Thread], [Level], [Logger], [Message], [Exception], [CompanyId]) VALUES (3, CAST(N'2023-03-19T13:10:53.2800000' AS DateTime2), N'   at UI.TextilSoft.Controllers.PedidosController`1.ObtenerPedidos(Int32 pageIndex, Int32 pageCount, Expression`1 filterExpression, String orderBy, Boolean ascending, Boolean EsPedido) in D:\Repositorios-SmartGit\TextilSoft\Aplicacion\UI.TextilSoft\Controllers\PedidosController.cs:line 109', N'aa', N'??', N'Usuario: Leopoldo:11111111 Ocurrió un error fatal al obtener pedidosUnable to cast object of type ''Domain.GenericEntity.PaginatedList`1[Domain.Entities.ListarPedidosFabricaEntity]'' to type ''Domain.GenericEntity.PaginatedList`1[Domain.Entities.ListarPedidosEntity]''.', N'InvalidCastException', 200)
SET IDENTITY_INSERT [dbo].[Logs] OFF
GO
SET IDENTITY_INSERT [dbo].[permiso] ON 

INSERT [dbo].[permiso] ([nombre], [id_permiso], [permiso], [CompanyId]) VALUES (N'mivieja', 1, N'PuedeUsarProduccion', 200)
INSERT [dbo].[permiso] ([nombre], [id_permiso], [permiso], [CompanyId]) VALUES (N'lalala', 2, N'PuedeUsarConfiguracion', 200)
INSERT [dbo].[permiso] ([nombre], [id_permiso], [permiso], [CompanyId]) VALUES (N'paja', 3, N'PuedeUsarPedidos', 200)
INSERT [dbo].[permiso] ([nombre], [id_permiso], [permiso], [CompanyId]) VALUES (N'Papa', 6, NULL, 200)
INSERT [dbo].[permiso] ([nombre], [id_permiso], [permiso], [CompanyId]) VALUES (N'FamiliaGomez', 7, NULL, 200)
INSERT [dbo].[permiso] ([nombre], [id_permiso], [permiso], [CompanyId]) VALUES (N'FamiliaJonson', 8, NULL, 200)
INSERT [dbo].[permiso] ([nombre], [id_permiso], [permiso], [CompanyId]) VALUES (N'jejejeje', 15, NULL, 200)
INSERT [dbo].[permiso] ([nombre], [id_permiso], [permiso], [CompanyId]) VALUES (N'FamiliaTest', 22, NULL, 200)
INSERT [dbo].[permiso] ([nombre], [id_permiso], [permiso], [CompanyId]) VALUES (N'Administrador', 25, N'EsAdmin', 200)
SET IDENTITY_INSERT [dbo].[permiso] OFF
GO
SET IDENTITY_INSERT [dbo].[permiso_permiso] ON 

INSERT [dbo].[permiso_permiso] ([id_permiso_permiso], [id_permiso_padre], [id_permiso_hijo]) VALUES (3, 8, 3)
INSERT [dbo].[permiso_permiso] ([id_permiso_permiso], [id_permiso_padre], [id_permiso_hijo]) VALUES (4, 8, 5)
INSERT [dbo].[permiso_permiso] ([id_permiso_permiso], [id_permiso_padre], [id_permiso_hijo]) VALUES (11, 8, 7)
INSERT [dbo].[permiso_permiso] ([id_permiso_permiso], [id_permiso_padre], [id_permiso_hijo]) VALUES (27, 22, 3)
INSERT [dbo].[permiso_permiso] ([id_permiso_permiso], [id_permiso_padre], [id_permiso_hijo]) VALUES (68, 6, 1)
INSERT [dbo].[permiso_permiso] ([id_permiso_permiso], [id_permiso_padre], [id_permiso_hijo]) VALUES (70, 15, 1)
INSERT [dbo].[permiso_permiso] ([id_permiso_permiso], [id_permiso_padre], [id_permiso_hijo]) VALUES (73, 7, 2)
INSERT [dbo].[permiso_permiso] ([id_permiso_permiso], [id_permiso_padre], [id_permiso_hijo]) VALUES (74, 7, 15)
SET IDENTITY_INSERT [dbo].[permiso_permiso] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([id_usuario], [CompanyId], [Nombre], [Contraseña], [Email], [DNI], [AccesFailed], [EmailConfirmado], [DateTimeEmail], [NumeroTeléfono], [IsOwner], [Active], [DateDisabledUser], [VerifyCode], [EnableAnimators], [EnableSlicePanel], [EnableVolume], [Volume], [IdiomaSeleccionado]) VALUES (1, 200, N'JuanNoLLegas', N'a', N'asdasdasd.com', 42997283, 0, 1, CAST(N'2022-04-10T13:58:56.000' AS DateTime), NULL, 1, 1, NULL, 319359, 1, 1, 1, 10, NULL)
INSERT [dbo].[usuarios] ([id_usuario], [CompanyId], [Nombre], [Contraseña], [Email], [DNI], [AccesFailed], [EmailConfirmado], [DateTimeEmail], [NumeroTeléfono], [IsOwner], [Active], [DateDisabledUser], [VerifyCode], [EnableAnimators], [EnableSlicePanel], [EnableVolume], [Volume], [IdiomaSeleccionado]) VALUES (2, 200, N'Pool', N'9TdmMgJy', N'gonzaloiba.28.00@gmail.com', 42886278, 0, 1, CAST(N'2022-04-10T14:00:00.000' AS DateTime), NULL, 0, 1, NULL, 251122, 1, 1, 1, 10, NULL)
INSERT [dbo].[usuarios] ([id_usuario], [CompanyId], [Nombre], [Contraseña], [Email], [DNI], [AccesFailed], [EmailConfirmado], [DateTimeEmail], [NumeroTeléfono], [IsOwner], [Active], [DateDisabledUser], [VerifyCode], [EnableAnimators], [EnableSlicePanel], [EnableVolume], [Volume], [IdiomaSeleccionado]) VALUES (3, 200, N'Leopoldo', N'a', N'1', 11111111, 0, 1, NULL, NULL, 1, 1, NULL, NULL, 0, 0, 0, 10, NULL)
INSERT [dbo].[usuarios] ([id_usuario], [CompanyId], [Nombre], [Contraseña], [Email], [DNI], [AccesFailed], [EmailConfirmado], [DateTimeEmail], [NumeroTeléfono], [IsOwner], [Active], [DateDisabledUser], [VerifyCode], [EnableAnimators], [EnableSlicePanel], [EnableVolume], [Volume], [IdiomaSeleccionado]) VALUES (4, 200, N'Pool2', N'wtQNWSF1', N'sada@er.co', 0, 0, 0, NULL, NULL, 0, 1, NULL, NULL, 1, 1, 1, 10, NULL)
INSERT [dbo].[usuarios] ([id_usuario], [CompanyId], [Nombre], [Contraseña], [Email], [DNI], [AccesFailed], [EmailConfirmado], [DateTimeEmail], [NumeroTeléfono], [IsOwner], [Active], [DateDisabledUser], [VerifyCode], [EnableAnimators], [EnableSlicePanel], [EnableVolume], [Volume], [IdiomaSeleccionado]) VALUES (5, 200, N'asdsa', N'azQMPoJQ', N'pepe@hotmail.com', 0, 1, 0, NULL, NULL, 0, 1, NULL, 123456, 1, 1, 1, 10, NULL)
INSERT [dbo].[usuarios] ([id_usuario], [CompanyId], [Nombre], [Contraseña], [Email], [DNI], [AccesFailed], [EmailConfirmado], [DateTimeEmail], [NumeroTeléfono], [IsOwner], [Active], [DateDisabledUser], [VerifyCode], [EnableAnimators], [EnableSlicePanel], [EnableVolume], [Volume], [IdiomaSeleccionado]) VALUES (6, 200, N'pepe', N'28Gonzza_', N'pepe@co.com', 0, 0, 0, NULL, NULL, 0, 1, NULL, 123456, 1, 1, 1, 10, NULL)
INSERT [dbo].[usuarios] ([id_usuario], [CompanyId], [Nombre], [Contraseña], [Email], [DNI], [AccesFailed], [EmailConfirmado], [DateTimeEmail], [NumeroTeléfono], [IsOwner], [Active], [DateDisabledUser], [VerifyCode], [EnableAnimators], [EnableSlicePanel], [EnableVolume], [Volume], [IdiomaSeleccionado]) VALUES (13, 300, N'DonPepote', N'a', N'asdasdasd.com', 0, 0, 0, NULL, NULL, 0, 1, NULL, NULL, 1, 1, 1, 10, NULL)
INSERT [dbo].[usuarios] ([id_usuario], [CompanyId], [Nombre], [Contraseña], [Email], [DNI], [AccesFailed], [EmailConfirmado], [DateTimeEmail], [NumeroTeléfono], [IsOwner], [Active], [DateDisabledUser], [VerifyCode], [EnableAnimators], [EnableSlicePanel], [EnableVolume], [Volume], [IdiomaSeleccionado]) VALUES (14, 200, N'12312a', N'a', N'asdasd@hotmail.com', 0, 0, 0, NULL, NULL, 0, 1, NULL, 984976, 1, 1, 1, 10, NULL)
INSERT [dbo].[usuarios] ([id_usuario], [CompanyId], [Nombre], [Contraseña], [Email], [DNI], [AccesFailed], [EmailConfirmado], [DateTimeEmail], [NumeroTeléfono], [IsOwner], [Active], [DateDisabledUser], [VerifyCode], [EnableAnimators], [EnableSlicePanel], [EnableVolume], [Volume], [IdiomaSeleccionado]) VALUES (15, 200, N'DonPepote3', N'aaa', N'aaasd@ht.com', 0, 0, 0, NULL, NULL, 0, 1, NULL, 502215, 1, 1, 1, 10, NULL)
INSERT [dbo].[usuarios] ([id_usuario], [CompanyId], [Nombre], [Contraseña], [Email], [DNI], [AccesFailed], [EmailConfirmado], [DateTimeEmail], [NumeroTeléfono], [IsOwner], [Active], [DateDisabledUser], [VerifyCode], [EnableAnimators], [EnableSlicePanel], [EnableVolume], [Volume], [IdiomaSeleccionado]) VALUES (16, 200, N'aaasd', N'vuieaa20', N'a@hom.com', 0, 2, 0, NULL, NULL, 0, 1, NULL, 598578, 1, 1, 1, 10, NULL)
INSERT [dbo].[usuarios] ([id_usuario], [CompanyId], [Nombre], [Contraseña], [Email], [DNI], [AccesFailed], [EmailConfirmado], [DateTimeEmail], [NumeroTeléfono], [IsOwner], [Active], [DateDisabledUser], [VerifyCode], [EnableAnimators], [EnableSlicePanel], [EnableVolume], [Volume], [IdiomaSeleccionado]) VALUES (17, 200, N'', N'aaaasda12', N'asdasdasda@gmail.co', 0, 0, 0, NULL, NULL, 0, 1, NULL, 404900, 1, 1, 1, 10, NULL)
INSERT [dbo].[usuarios] ([id_usuario], [CompanyId], [Nombre], [Contraseña], [Email], [DNI], [AccesFailed], [EmailConfirmado], [DateTimeEmail], [NumeroTeléfono], [IsOwner], [Active], [DateDisabledUser], [VerifyCode], [EnableAnimators], [EnableSlicePanel], [EnableVolume], [Volume], [IdiomaSeleccionado]) VALUES (1018, 200, N'admin', N'admin', N'diploma@alumnos.UAI.edu.ar', 12345678, 0, 1, NULL, NULL, 1, 1, NULL, NULL, 1, 1, 1, 1, NULL)
INSERT [dbo].[usuarios] ([id_usuario], [CompanyId], [Nombre], [Contraseña], [Email], [DNI], [AccesFailed], [EmailConfirmado], [DateTimeEmail], [NumeroTeléfono], [IsOwner], [Active], [DateDisabledUser], [VerifyCode], [EnableAnimators], [EnableSlicePanel], [EnableVolume], [Volume], [IdiomaSeleccionado]) VALUES (3020, 200, N'leopolda', N'as', N'gonza_28.00@hotmail.com', 0, 0, 0, NULL, NULL, 0, 1, NULL, 299295, 1, 1, 1, 1, NULL)
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (1018, 25)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (1, 25)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (4, 1)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (2, 1)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (1, 7)
GO
ALTER TABLE [dbo].[Logs] ADD  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[usuarios] ADD  CONSTRAINT [DF_usuarios_EnableAnimators]  DEFAULT (CONVERT([bit],(1))) FOR [EnableAnimators]
GO
ALTER TABLE [dbo].[usuarios] ADD  CONSTRAINT [DF_usuarios_EnableSlicePanel]  DEFAULT (CONVERT([bit],(1))) FOR [EnableSlicePanel]
GO
ALTER TABLE [dbo].[usuarios] ADD  CONSTRAINT [DF_usuarios_EnableVolume]  DEFAULT (CONVERT([bit],(1))) FOR [EnableVolume]
GO
ALTER TABLE [dbo].[usuarios] ADD  CONSTRAINT [DF_usuarios_Volume]  DEFAULT ((1)) FOR [Volume]
GO
ALTER TABLE [dbo].[CompanyCustomize]  WITH CHECK ADD  CONSTRAINT [FK_CompanyCustomize_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[CompanyCustomize] CHECK CONSTRAINT [FK_CompanyCustomize_Company]
GO
ALTER TABLE [dbo].[CompanySendGridConfiguration]  WITH CHECK ADD  CONSTRAINT [FK_CompanySendGridConfiguration_Company_CompanyId] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CompanySendGridConfiguration] CHECK CONSTRAINT [FK_CompanySendGridConfiguration_Company_CompanyId]
GO
ALTER TABLE [dbo].[Logs]  WITH CHECK ADD  CONSTRAINT [FK_Logs_Company_CompanyId] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Logs] CHECK CONSTRAINT [FK_Logs_Company_CompanyId]
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [FK_usuarios_Company]
GO
ALTER TABLE [dbo].[usuarios_permisos]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_permisos_permiso] FOREIGN KEY([id_permiso])
REFERENCES [dbo].[permiso] ([id_permiso])
GO
ALTER TABLE [dbo].[usuarios_permisos] CHECK CONSTRAINT [FK_usuarios_permisos_permiso]
GO
ALTER TABLE [dbo].[usuarios_permisos]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_permisos_usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[usuarios_permisos] CHECK CONSTRAINT [FK_usuarios_permisos_usuarios]
GO
/****** Object:  StoredProcedure [dbo].[SP_LOGIN]    Script Date: 23/6/2023 21:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_LOGIN]
@Usuario varchar(50),
@Contraseña varchar(50),
@Resultado bit output
AS
BEGIN
	set @Resultado = 0
		if exists(Select * from tblUsuarios where usuario = @Usuario and contraseña = @Contraseña)
			begin
				set @Resultado = 1
			end
END
GO
USE [master]
GO
ALTER DATABASE [upf] SET  READ_WRITE 
GO
