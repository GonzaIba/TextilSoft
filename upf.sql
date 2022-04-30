USE [master]
GO
/****** Object:  Database [upf]    Script Date: 29/4/2022 22:56:16 ******/
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
/****** Object:  User [testUser2]    Script Date: 29/4/2022 22:56:17 ******/
CREATE USER [testUser2] FOR LOGIN [testUser2] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [testUser2]
GO
/****** Object:  Table [dbo].[Log]    Script Date: 29/4/2022 22:56:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Log](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Thread] [varchar](255) NOT NULL,
	[Level] [varchar](50) NOT NULL,
	[Logger] [varchar](255) NOT NULL,
	[Message] [varchar](4000) NOT NULL,
	[Exception] [varchar](2000) NULL,
 CONSTRAINT [PK_Log4NetLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permiso]    Script Date: 29/4/2022 22:56:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permiso](
	[nombre] [varchar](100) NULL,
	[id_permiso] [int] IDENTITY(1,1) NOT NULL,
	[permiso] [varchar](50) NULL,
 CONSTRAINT [PK_permiso_1] PRIMARY KEY CLUSTERED 
(
	[id_permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permiso_permiso]    Script Date: 29/4/2022 22:56:17 ******/
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
/****** Object:  Table [dbo].[prueba]    Script Date: 29/4/2022 22:56:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prueba](
	[id] [int] NOT NULL,
	[dni] [int] NULL,
 CONSTRAINT [PK_prueba] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 29/4/2022 22:56:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_usuario] [int] NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[Contraseña] [varchar](200) NOT NULL,
	[Email] [varchar](200) NULL,
	[DNI] [int] NOT NULL,
	[AccesFailed] [int] NOT NULL,
	[EmailConfirmado] [bit] NULL,
	[DateTimeEmail] [datetime] NULL,
	[NumeroTeléfono] [varchar](50) NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios_permisos]    Script Date: 29/4/2022 22:56:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios_permisos](
	[id_usuario] [int] NOT NULL,
	[id_permiso] [int] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[permiso] ON 

INSERT [dbo].[permiso] ([nombre], [id_permiso], [permiso]) VALUES (N'mivieja', 1, N'PuedeHacerE')
INSERT [dbo].[permiso] ([nombre], [id_permiso], [permiso]) VALUES (N'lalala', 2, N'PuedeHacerG')
INSERT [dbo].[permiso] ([nombre], [id_permiso], [permiso]) VALUES (N'paja', 3, N'PuedeHacerA')
INSERT [dbo].[permiso] ([nombre], [id_permiso], [permiso]) VALUES (N'Papa', 4, NULL)
INSERT [dbo].[permiso] ([nombre], [id_permiso], [permiso]) VALUES (N'Jejox', 5, N'PuedeHacerA')
INSERT [dbo].[permiso] ([nombre], [id_permiso], [permiso]) VALUES (N'Papa', 6, NULL)
INSERT [dbo].[permiso] ([nombre], [id_permiso], [permiso]) VALUES (N'FamiliaGomez', 7, NULL)
INSERT [dbo].[permiso] ([nombre], [id_permiso], [permiso]) VALUES (N'FamiliaJonson', 8, NULL)
INSERT [dbo].[permiso] ([nombre], [id_permiso], [permiso]) VALUES (N'Patente1', 9, N'JAJAJA')
SET IDENTITY_INSERT [dbo].[permiso] OFF
GO
SET IDENTITY_INSERT [dbo].[permiso_permiso] ON 

INSERT [dbo].[permiso_permiso] ([id_permiso_permiso], [id_permiso_padre], [id_permiso_hijo]) VALUES (1, 7, 1)
INSERT [dbo].[permiso_permiso] ([id_permiso_permiso], [id_permiso_padre], [id_permiso_hijo]) VALUES (2, 7, 2)
INSERT [dbo].[permiso_permiso] ([id_permiso_permiso], [id_permiso_padre], [id_permiso_hijo]) VALUES (3, 8, 3)
INSERT [dbo].[permiso_permiso] ([id_permiso_permiso], [id_permiso_padre], [id_permiso_hijo]) VALUES (4, 8, 5)
INSERT [dbo].[permiso_permiso] ([id_permiso_permiso], [id_permiso_padre], [id_permiso_hijo]) VALUES (5, 8, 7)
INSERT [dbo].[permiso_permiso] ([id_permiso_permiso], [id_permiso_padre], [id_permiso_hijo]) VALUES (6, 7, 8)
SET IDENTITY_INSERT [dbo].[permiso_permiso] OFF
GO
INSERT [dbo].[usuarios] ([id_usuario], [nombre], [Contraseña], [Email], [DNI], [AccesFailed], [EmailConfirmado], [DateTimeEmail], [NumeroTeléfono]) VALUES (1, N'JuanNoLLegas', N'1234', N'gonza_28.00@hotmail.com', 42997283, 0, 1, CAST(N'2022-04-10T13:58:56.000' AS DateTime), NULL)
INSERT [dbo].[usuarios] ([id_usuario], [nombre], [Contraseña], [Email], [DNI], [AccesFailed], [EmailConfirmado], [DateTimeEmail], [NumeroTeléfono]) VALUES (2, N'Pool', N'1234', N'gonzaloiba.28.00@gmail.com', 42886278, 0, 1, CAST(N'2022-04-10T14:00:00.000' AS DateTime), NULL)
GO
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (1, 1)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (1, 2)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (1, 3)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (1, 7)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (2, 1)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (2, 2)
INSERT [dbo].[usuarios_permisos] ([id_usuario], [id_permiso]) VALUES (2, 3)
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
/****** Object:  StoredProcedure [dbo].[SP_LOGIN]    Script Date: 29/4/2022 22:56:17 ******/
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
