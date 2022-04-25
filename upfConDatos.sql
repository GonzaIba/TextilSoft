USE [upf]
GO
/****** Object:  Table [dbo].[Log]    Script Date: 24/4/2022 22:18:54 ******/
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
/****** Object:  Table [dbo].[permiso]    Script Date: 24/4/2022 22:18:54 ******/
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
/****** Object:  Table [dbo].[permiso_permiso]    Script Date: 24/4/2022 22:18:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permiso_permiso](
	[id_permiso_padre] [int] NULL,
	[id_permiso_hijo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prueba]    Script Date: 24/4/2022 22:18:54 ******/
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
/****** Object:  Table [dbo].[usuarios]    Script Date: 24/4/2022 22:18:54 ******/
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
/****** Object:  Table [dbo].[usuarios_permisos]    Script Date: 24/4/2022 22:18:54 ******/
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
INSERT [dbo].[permiso] ([nombre], [id_permiso], [permiso]) VALUES (N'Patente1', 9, N'PuedeHacerA')
SET IDENTITY_INSERT [dbo].[permiso] OFF
GO
INSERT [dbo].[permiso_permiso] ([id_permiso_padre], [id_permiso_hijo]) VALUES (7, 1)
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
/****** Object:  StoredProcedure [dbo].[SP_LOGIN]    Script Date: 24/4/2022 22:18:54 ******/
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
