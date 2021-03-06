USE [master]
GO
/****** Object:  Database [GestionCC]    Script Date: 06/09/2014 22:34:31 ******/
CREATE DATABASE [GestionCC] ON  PRIMARY 
( NAME = N'GestionCC', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\GestionCC.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GestionCC_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\GestionCC_1.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GestionCC] SET COMPATIBILITY_LEVEL = 90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GestionCC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GestionCC] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [GestionCC] SET ANSI_NULLS OFF
GO
ALTER DATABASE [GestionCC] SET ANSI_PADDING OFF
GO
ALTER DATABASE [GestionCC] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [GestionCC] SET ARITHABORT OFF
GO
ALTER DATABASE [GestionCC] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [GestionCC] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [GestionCC] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [GestionCC] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [GestionCC] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [GestionCC] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [GestionCC] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [GestionCC] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [GestionCC] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [GestionCC] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [GestionCC] SET  DISABLE_BROKER
GO
ALTER DATABASE [GestionCC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [GestionCC] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [GestionCC] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [GestionCC] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [GestionCC] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [GestionCC] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [GestionCC] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [GestionCC] SET  READ_WRITE
GO
ALTER DATABASE [GestionCC] SET RECOVERY SIMPLE
GO
ALTER DATABASE [GestionCC] SET  MULTI_USER
GO
ALTER DATABASE [GestionCC] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [GestionCC] SET DB_CHAINING OFF
GO
USE [GestionCC]
GO
/****** Object:  User [saftec]    Script Date: 06/09/2014 22:34:31 ******/
CREATE USER [saftec] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[FormaPago]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FormaPago](
	[idFormaPago] [int] IDENTITY(1,1) NOT NULL,
	[descripcionFormaPago] [varchar](50) NOT NULL,
 CONSTRAINT [PK_FormaPago] PRIMARY KEY CLUSTERED 
(
	[idFormaPago] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[FormaPago] ON
INSERT [dbo].[FormaPago] ([idFormaPago], [descripcionFormaPago]) VALUES (1, N'Cuenta Corriente')
INSERT [dbo].[FormaPago] ([idFormaPago], [descripcionFormaPago]) VALUES (2, N'Tarjeta')
INSERT [dbo].[FormaPago] ([idFormaPago], [descripcionFormaPago]) VALUES (3, N'Cheque')
INSERT [dbo].[FormaPago] ([idFormaPago], [descripcionFormaPago]) VALUES (4, N'Efectivo')
SET IDENTITY_INSERT [dbo].[FormaPago] OFF
/****** Object:  Table [dbo].[Marca]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Marca](
	[Id_Marca] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Marca] PRIMARY KEY CLUSTERED 
(
	[Id_Marca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Marca] ON
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (20, N'AE')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (21, N'AGUSTINA BERTERO')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (22, N'BERSHKA')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (23, N'CUSTO BARCELONA')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (24, N'DG')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (25, N'DIGNA HEREDERA')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (26, N'DIOSA LUNA')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (27, N'ECOLE')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (28, N'FOREVER XXI')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (29, N'GLAM')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (30, N'GUGGA')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (31, N'IMPORT')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (32, N'INE OTERO')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (33, N'LALA VALLE')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (34, N'LILAGRACE')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (35, N'MONTJUIC')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (36, N'NATALIA COV')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (37, N'OPR')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (38, N'OTHILIA')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (39, N'PAZ CORNU')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (40, N'PHILLIP PLEIN')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (41, N'PINK')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (42, N'PRADA')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (43, N'ROSH')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (44, N'ROUSE')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (45, N'SOHANA')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (46, N'SERGIO ADARO')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (47, N'SHANNA')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (48, N'VS')
INSERT [dbo].[Marca] ([Id_Marca], [Descripcion]) VALUES (49, N'VOCES')
SET IDENTITY_INSERT [dbo].[Marca] OFF
/****** Object:  Table [dbo].[Gasto]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Gasto](
	[Id_Gasto] [int] IDENTITY(1,1) NOT NULL,
	[DesGasto] [varchar](50) NOT NULL,
	[Importe] [float] NOT NULL,
	[FechaGasto] [datetime] NOT NULL,
	[AfectaCaja] [char](1) NULL,
 CONSTRAINT [PK_Gasto] PRIMARY KEY CLUSTERED 
(
	[Id_Gasto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Gasto] ON
INSERT [dbo].[Gasto] ([Id_Gasto], [DesGasto], [Importe], [FechaGasto], [AfectaCaja]) VALUES (10, N'Gast de agua', 200, CAST(0x0000A2EC00000000 AS DateTime), N'S')
INSERT [dbo].[Gasto] ([Id_Gasto], [DesGasto], [Importe], [FechaGasto], [AfectaCaja]) VALUES (11, N'Pago del agua', 150, CAST(0x0000A2F300000000 AS DateTime), N'S')
INSERT [dbo].[Gasto] ([Id_Gasto], [DesGasto], [Importe], [FechaGasto], [AfectaCaja]) VALUES (12, N'Gasto de Sistema', 200, CAST(0x0000A2F400000000 AS DateTime), N'S')
INSERT [dbo].[Gasto] ([Id_Gasto], [DesGasto], [Importe], [FechaGasto], [AfectaCaja]) VALUES (13, N'Gasto de dispenser d', 300, CAST(0x0000A30200000000 AS DateTime), N'S')
SET IDENTITY_INSERT [dbo].[Gasto] OFF
/****** Object:  Table [dbo].[ConfigParameters]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ConfigParameters](
	[MailFrom] [nvarchar](50) NOT NULL,
	[DefaultText] [nvarchar](50) NOT NULL,
	[AlwaysSend] [bit] NOT NULL,
	[AlwaysAsk] [bit] NOT NULL,
	[Password] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ConfigParameters] ([MailFrom], [DefaultText], [AlwaysSend], [AlwaysAsk], [Password]) VALUES (N'leandro.mlisa@gmail.com', N'Glam le agradece por su compra.
', 1, 1, N'laliho*65')
/****** Object:  Table [dbo].[Cliente]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[DNI] [varchar](50) NULL,
	[Direccion] [varchar](50) NULL,
	[Localidad] [varchar](50) NULL,
	[Telefono] [varchar](50) NULL,
	[Comentario] [varchar](50) NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Importe] [float] NOT NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id_cliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (157, N'AZUCENA', N'', N'4323978', N'Rosario', N'156698586', N'', N'MAMA FLAVIA', 14860, N'martindiguilio@hotmail.com')
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (158, N'ANABELA', NULL, N'MORENO 2000', N'Rosario', NULL, NULL, N'SUN BED', 1120, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (159, N'ANI', NULL, NULL, N'Rosario', N'156432098', NULL, N'BRASILERA ', 660, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (160, N'ANA PAULA', NULL, NULL, N'Rosario', N'153072531', NULL, N'ELIZALDE', 0, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (161, N'BRENDA', NULL, N'SAN LORENZO 2019 4B', N'Rosario', N'3471686522', NULL, N'GROH', 895, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (162, N'BRENDA', NULL, NULL, N'Rosario', N'159213824', NULL, N'COSTELLO', 0, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (163, N'CAROLINA', NULL, NULL, N'Rosario', NULL, NULL, N'GIOSA', 47, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (164, N'CINTHIA', NULL, N'156968927', N'Rosario', N'156696927', NULL, N'HARAS', 566, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (165, N'CAROLINA', NULL, NULL, N'Rosario', NULL, NULL, N'BALERINI', 0, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (166, N'FLOR ', NULL, N'LAS PA', N'LAS PAREJAS ', NULL, NULL, N'CATENA', 0, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (167, N'FLAVIA ', NULL, NULL, N'Rosario', NULL, NULL, N'FELDKICHER', 0, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (168, N'ISABEL', NULL, N'MONTEVIDEO 1800', N'Rosario', NULL, NULL, N'FLORES POLICIA', 0, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (169, N'FERNANDA ', NULL, NULL, N'Rosario', NULL, NULL, N'PELUQUERA', 0, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (170, N'GLADYS', NULL, N'ITALIA 1500', N'Rosario', NULL, NULL, N'VECINA', 0, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (171, N'JESICA ', NULL, N'LAS PA', N'LAS PAREJAS ', NULL, NULL, N'GROH', 462, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (172, N'JUGE', NULL, N'ITALIA 1607 6A', N'Rosario', NULL, NULL, N'VECINA', 0, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (173, N'LILI', NULL, N'TORRE DE LA LIBERTAD', N'Rosario', NULL, NULL, N'CONDITI', 0, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (174, N'LUCIANA MEMI', NULL, NULL, N'Rosario', NULL, NULL, N'PALOMBO', 212, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (175, N'LILI', NULL, N'MONTEVIDEO 1600', N'Rosario', N'155203674', NULL, N'GESTORA', 300, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (176, N'LORENA', NULL, N'ZEBALLOS 1520 2 B', N'Rosario', N'4214564', NULL, N'CASINI', 392, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (177, N'MARTA', NULL, NULL, N'Rosario', NULL, NULL, N'TALLER', 736, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (178, N'MAJO', NULL, N'MONTEVIDEO 1607 5A', N'Rosario', NULL, NULL, N'VECINA', 90, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (179, N'MARIA INES', NULL, NULL, N'Rosario', N'155119931', NULL, N'VISITADORA MEDICA', 280, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (180, N'MARITE', NULL, N'MONTEVIDEO 1749 8', N'Rosario', N'156286304', NULL, N'CAMES', 20, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (181, N'MARTA', NULL, N'ESPAÑA 1660 1 A', N'Rosario', N'156062771', NULL, N'marta ', 1106, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (182, N'MARCELA ', NULL, NULL, N'Rosario', N'155328416', NULL, N'CMB', 329, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (183, N'MARIAN', NULL, N'COSTANERA ', N'Rosario', NULL, NULL, N'PORRECA', 0, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (184, N'MANUELA', NULL, NULL, N'Rosario', NULL, NULL, N'SAN MARINO', 0, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (185, N'MARCELA ', NULL, N'ESPAÑA Y MONTEVIDEO', N'Rosario', N'155865487', N'4488416', N'PERFUMERIA', 243, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (186, N'MIRIAM', NULL, N'SARMIENTO Y SAN LUIS0', N'Rosario', NULL, NULL, N'PELUQUERA', 2931, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (187, N'NATALIA ', NULL, NULL, N'Rosario', NULL, NULL, N'CASTILLO', 290, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (188, N'NATALIA ', NULL, NULL, N'Rosario', N'153743426', NULL, N'LOPEZ', 0, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (189, N'NATALIA ', NULL, N'MONTEVIDEO 1835 2B ', N'Rosario', N'156823335', NULL, N'LOBATO', 0, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (190, N'OFELIA', NULL, N'ITALIA 1631 3 A', N'Rosario', N'4471416', NULL, N'VECINA', 327, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (191, N'PAULI', NULL, NULL, N'Rosario', NULL, N'400 acta', N'PALAVECCINO', 575, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (192, N'RATA', NULL, N'COCHABAMBA Y ESPAÑA', N'Rosario', NULL, NULL, N'DI MONACO', 420, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (193, N'ROMI', NULL, NULL, N'Rosario', NULL, NULL, N'JARDIN', 810, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (194, N'SILVINA', NULL, N'ITALIA 1631 3 A', N'Rosario', NULL, NULL, N'HIJA OFELIA', 130, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (195, N'GABRIELA ', NULL, N'9 DE JULIO 1855', N'Rosario', N'153029322', N'4497284', N'ROMAN', 315, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (196, N'SOLE', NULL, NULL, N'Rosario', NULL, NULL, N'HIJA MARTA', 140, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (197, N'SILVI ', NULL, NULL, N'Rosario', NULL, NULL, N'NUERA MARCE', 0, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (198, N'LUCIANA ', NULL, NULL, N'Rosario', N'156474540', NULL, N'DEL FONZO ', 0, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (199, N'ANABELA', NULL, N'ENTRE RIOS 1925 DTO 4', N'Rosario', N'152787131', N'4819758', N'FARABELLI', 0, NULL)
INSERT [dbo].[Cliente] ([Id_cliente], [Nombre], [DNI], [Direccion], [Localidad], [Telefono], [Comentario], [Apellido], [Importe], [Email]) VALUES (200, N'MARIA FERNANDA', NULL, N'ITALIA 1532', N'Rosario', NULL, N'4263209', N'FABRICA PASTAS', 0, NULL)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
/****** Object:  Table [dbo].[CajaDiaria]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CajaDiaria](
	[Id_Caja] [int] IDENTITY(1,1) NOT NULL,
	[Ingreso] [float] NULL,
	[Egreso] [float] NULL,
	[FechaOperacion] [datetime] NOT NULL,
	[DescripcionOperacion] [varchar](50) NULL,
	[CajaInicial] [float] NULL,
 CONSTRAINT [PK_CajaDiaria] PRIMARY KEY CLUSTERED 
(
	[Id_Caja] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CajaDiaria] ON
INSERT [dbo].[CajaDiaria] ([Id_Caja], [Ingreso], [Egreso], [FechaOperacion], [DescripcionOperacion], [CajaInicial]) VALUES (119, NULL, NULL, CAST(0x0000A30000000000 AS DateTime), N'', 0)
INSERT [dbo].[CajaDiaria] ([Id_Caja], [Ingreso], [Egreso], [FechaOperacion], [DescripcionOperacion], [CajaInicial]) VALUES (120, NULL, NULL, CAST(0x0000A30200000000 AS DateTime), N'', 0)
INSERT [dbo].[CajaDiaria] ([Id_Caja], [Ingreso], [Egreso], [FechaOperacion], [DescripcionOperacion], [CajaInicial]) VALUES (121, NULL, 200, CAST(0x0000A30200000000 AS DateTime), N'Saco el cambio de la caja', 0)
SET IDENTITY_INSERT [dbo].[CajaDiaria] OFF
/****** Object:  Table [dbo].[AuditVentas]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AuditVentas](
	[Id_AuditVentas] [int] IDENTITY(1,1) NOT NULL,
	[FechaVentaAnt] [varchar](50) NULL,
	[FechaVentaNueva] [varchar](50) NULL,
	[CuentaCorrienteAnt] [bit] NULL,
	[CuentaCorrienteNueva] [bit] NULL,
 CONSTRAINT [PK_AuditVentas] PRIMARY KEY CLUSTERED 
(
	[Id_AuditVentas] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoUsuario]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoUsuario](
	[Id_TipoUsuario] [int] IDENTITY(1,1) NOT NULL,
	[CodTipo] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_T] PRIMARY KEY CLUSTERED 
(
	[Id_TipoUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TipoUsuario] ON
INSERT [dbo].[TipoUsuario] ([Id_TipoUsuario], [CodTipo], [Descripcion]) VALUES (1, 1, N'Administrador')
INSERT [dbo].[TipoUsuario] ([Id_TipoUsuario], [CodTipo], [Descripcion]) VALUES (2, 2, N'Operador')
INSERT [dbo].[TipoUsuario] ([Id_TipoUsuario], [CodTipo], [Descripcion]) VALUES (3, 3, N'Cliente')
SET IDENTITY_INSERT [dbo].[TipoUsuario] OFF
/****** Object:  Table [dbo].[TipoArticulo]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoArticulo](
	[Id_TipoArticulo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoArticulo] PRIMARY KEY CLUSTERED 
(
	[Id_TipoArticulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TipoArticulo] ON
INSERT [dbo].[TipoArticulo] ([Id_TipoArticulo], [Descripcion]) VALUES (38, N'VESTIDO')
INSERT [dbo].[TipoArticulo] ([Id_TipoArticulo], [Descripcion]) VALUES (39, N'BLAZZER')
INSERT [dbo].[TipoArticulo] ([Id_TipoArticulo], [Descripcion]) VALUES (40, N'BUZO')
INSERT [dbo].[TipoArticulo] ([Id_TipoArticulo], [Descripcion]) VALUES (41, N'CALZA')
INSERT [dbo].[TipoArticulo] ([Id_TipoArticulo], [Descripcion]) VALUES (42, N'CALZA PANTALON')
INSERT [dbo].[TipoArticulo] ([Id_TipoArticulo], [Descripcion]) VALUES (43, N'CAMISA')
INSERT [dbo].[TipoArticulo] ([Id_TipoArticulo], [Descripcion]) VALUES (44, N'CAMPERA')
INSERT [dbo].[TipoArticulo] ([Id_TipoArticulo], [Descripcion]) VALUES (45, N'CHAQUETA')
INSERT [dbo].[TipoArticulo] ([Id_TipoArticulo], [Descripcion]) VALUES (46, N'JEANS')
INSERT [dbo].[TipoArticulo] ([Id_TipoArticulo], [Descripcion]) VALUES (47, N'MONO')
INSERT [dbo].[TipoArticulo] ([Id_TipoArticulo], [Descripcion]) VALUES (48, N'MUSCU')
INSERT [dbo].[TipoArticulo] ([Id_TipoArticulo], [Descripcion]) VALUES (49, N'PANTALON')
INSERT [dbo].[TipoArticulo] ([Id_TipoArticulo], [Descripcion]) VALUES (50, N'PIJAMERO')
INSERT [dbo].[TipoArticulo] ([Id_TipoArticulo], [Descripcion]) VALUES (51, N'POLLERA')
INSERT [dbo].[TipoArticulo] ([Id_TipoArticulo], [Descripcion]) VALUES (52, N'REMERA')
INSERT [dbo].[TipoArticulo] ([Id_TipoArticulo], [Descripcion]) VALUES (53, N'SHORT')
INSERT [dbo].[TipoArticulo] ([Id_TipoArticulo], [Descripcion]) VALUES (54, N'SWETER')
INSERT [dbo].[TipoArticulo] ([Id_TipoArticulo], [Descripcion]) VALUES (55, N'TOP')
INSERT [dbo].[TipoArticulo] ([Id_TipoArticulo], [Descripcion]) VALUES (56, N'VESTIDO')
SET IDENTITY_INSERT [dbo].[TipoArticulo] OFF
/****** Object:  View [dbo].[ViGastosPorDia]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViGastosPorDia]
AS
SELECT     TOP (100) PERCENT CONVERT(varchar, FechaGasto, 103) AS Fecha, ISNULL(SUM(Importe), 0) AS Total
FROM         dbo.Gasto
WHERE     (AfectaCaja = 'S')
GROUP BY CONVERT(varchar, FechaGasto, 103)
ORDER BY Fecha
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Gasto"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViGastosPorDia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViGastosPorDia'
GO
/****** Object:  View [dbo].[ViCajaDiaria]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViCajaDiaria]
AS
SELECT     TOP (100) PERCENT FechaOperacion AS Fecha, ISNULL(SUM(Ingreso), 0) AS TotalIngreso, ISNULL(SUM(Egreso), 0) AS TotalEgreso, ISNULL(SUM(CajaInicial), 0) 
                      AS CajaInicial
FROM         dbo.CajaDiaria
GROUP BY FechaOperacion
ORDER BY Fecha
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CajaDiaria"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 221
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 2460
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViCajaDiaria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViCajaDiaria'
GO
/****** Object:  StoredProcedure [dbo].[sp_ABMGastos]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ABMGastos] 

@Descripcion varchar(20), @Importe float,@FechaGasto Datetime,@Id_Gasto int,@AfectaCaja char,@Estado char(1)


AS
	

		 
		
BEGIN

IF @Estado='A' 
BEGIN 

INSERT INTO Gasto(DesGasto,Importe,FechaGasto,AfectaCaja) VALUES (@Descripcion,@Importe,@FechaGasto,@AfectaCaja)


END

IF @Estado='M'
BEGIN

UPDATE Gasto SET DesGasto=@Descripcion,Importe=@Importe,FechaGasto=@FechaGasto,AfectaCaja=@AfectaCaja where Id_Gasto=@Id_Gasto

END
END


IF @Estado='B'
BEGIN
DELETE FROM Gasto WHERE Id_Gasto=@Id_Gasto
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ABMClientes]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ABMClientes] 

@Nombre varchar(20),@Apellido varchar(20), @dni VARCHAR(20),@Direccion varchar(20),@Localidad varchar(20),
@Telefono varchar(20),@Comentario varchar(20),@Estado char(1),@Id_Cliente int, @importe float,@Email varchar(50)


AS

		
		 
		
BEGIN

IF @Estado='A' 
BEGIN 
INSERT INTO Cliente(Nombre,Apellido,dni,Direccion,Localidad,Telefono,Comentario,Importe,Email) VALUES (@Nombre,@Apellido,@dni,@Direccion,@Localidad,@Telefono,@Comentario,@importe,@Email)
END

IF @Estado='M'
BEGIN
UPDATE Cliente SET Nombre=@Nombre,Apellido=@Apellido,DNI=@dni,Direccion=@Direccion,Localidad=@Localidad,Telefono=@Telefono,Comentario=@Comentario,Email=@Email where Id_cliente=@Id_Cliente
END


IF @Estado='B'
BEGIN
DELETE FROM Cliente WHERE Id_cliente=@Id_Cliente
END




END
GO
/****** Object:  StoredProcedure [dbo].[sp_ABMMarcas]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ABMMarcas] 

@Descripcion varchar(20), @Id_Marca int,@Estado char(1)


AS
	

		 
		
BEGIN

IF @Estado='A' 
BEGIN 

INSERT INTO Marca(Descripcion) VALUES (@Descripcion)


END

IF @Estado='M'
BEGIN

UPDATE Marca SET Descripcion=@Descripcion where Id_Marca=@Id_Marca

END



END


IF @Estado='B'
BEGIN
DELETE FROM Marca WHERE Id_Marca=@Id_Marca
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Config_Update]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Config_Update]
	@pAlwaysSend bit,
	@pAlwaysAsk bit,
	@pPassword varchar(50),
	@pMailFrom varchar(50),
	@pDefaultText varchar(50)

AS
BEGIN
	
	UPDATE ConfigParameters 
	SET AlwaysSend = @pAlwaysSend,
	AlwaysAsk = @pAlwaysAsk,
	Password = @pPassword,
	MailFrom = @pMailFrom,
	DefaultText = @pDefaultText
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Config_Select]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Config_Select]

AS
BEGIN

	SELECT * FROM ConfigParameters

END
GO
/****** Object:  StoredProcedure [dbo].[sp_Cliente_SelectOne]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Cliente_SelectOne]
	@pIDCliente int
AS
BEGIN

	SELECT *
	FROM Cliente
	WHERE Id_cliente = @pIDCliente

END
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[Id_Venta] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[FechaVenta] [datetime] NOT NULL,
	[CostoVenta] [float] NULL,
	[ImporteTotal] [float] NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[Id_Venta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Venta] ON
INSERT [dbo].[Venta] ([Id_Venta], [Id_Cliente], [FechaVenta], [CostoVenta], [ImporteTotal]) VALUES (408, 157, CAST(0x0000A32F01888E12 AS DateTime), 500, 1000)
INSERT [dbo].[Venta] ([Id_Venta], [Id_Cliente], [FechaVenta], [CostoVenta], [ImporteTotal]) VALUES (409, 157, CAST(0x0000A32F0188DEED AS DateTime), 500, 1000)
INSERT [dbo].[Venta] ([Id_Venta], [Id_Cliente], [FechaVenta], [CostoVenta], [ImporteTotal]) VALUES (410, 157, CAST(0x0000A32F0189643F AS DateTime), 500, 1000)
INSERT [dbo].[Venta] ([Id_Venta], [Id_Cliente], [FechaVenta], [CostoVenta], [ImporteTotal]) VALUES (411, 157, CAST(0x0000A32F018A9E1F AS DateTime), 700, 1200)
INSERT [dbo].[Venta] ([Id_Venta], [Id_Cliente], [FechaVenta], [CostoVenta], [ImporteTotal]) VALUES (412, 157, CAST(0x0000A3440128C733 AS DateTime), 500, 800)
INSERT [dbo].[Venta] ([Id_Venta], [Id_Cliente], [FechaVenta], [CostoVenta], [ImporteTotal]) VALUES (413, 157, CAST(0x0000A344012977A5 AS DateTime), 500, 900)
INSERT [dbo].[Venta] ([Id_Venta], [Id_Cliente], [FechaVenta], [CostoVenta], [ImporteTotal]) VALUES (414, 157, CAST(0x0000A344012A67C5 AS DateTime), 200, 180)
INSERT [dbo].[Venta] ([Id_Venta], [Id_Cliente], [FechaVenta], [CostoVenta], [ImporteTotal]) VALUES (415, 157, CAST(0x0000A344012C5D22 AS DateTime), 500, 900)
INSERT [dbo].[Venta] ([Id_Venta], [Id_Cliente], [FechaVenta], [CostoVenta], [ImporteTotal]) VALUES (416, 157, CAST(0x0000A344012DFCAC AS DateTime), 500, 800)
INSERT [dbo].[Venta] ([Id_Venta], [Id_Cliente], [FechaVenta], [CostoVenta], [ImporteTotal]) VALUES (417, 157, CAST(0x0000A34401303EFE AS DateTime), 1200, 1680)
INSERT [dbo].[Venta] ([Id_Venta], [Id_Cliente], [FechaVenta], [CostoVenta], [ImporteTotal]) VALUES (418, 157, CAST(0x0000A344013211D3 AS DateTime), 1000, 1800)
INSERT [dbo].[Venta] ([Id_Venta], [Id_Cliente], [FechaVenta], [CostoVenta], [ImporteTotal]) VALUES (419, 157, CAST(0x0000A34401328D8C AS DateTime), 500, 1000)
INSERT [dbo].[Venta] ([Id_Venta], [Id_Cliente], [FechaVenta], [CostoVenta], [ImporteTotal]) VALUES (420, 157, CAST(0x0000A3450147ACB8 AS DateTime), 500, 1000)
INSERT [dbo].[Venta] ([Id_Venta], [Id_Cliente], [FechaVenta], [CostoVenta], [ImporteTotal]) VALUES (421, 157, CAST(0x0000A3450147D777 AS DateTime), 500, 1000)
INSERT [dbo].[Venta] ([Id_Venta], [Id_Cliente], [FechaVenta], [CostoVenta], [ImporteTotal]) VALUES (422, 157, CAST(0x0000A345014847EB AS DateTime), 500, 1000)
INSERT [dbo].[Venta] ([Id_Venta], [Id_Cliente], [FechaVenta], [CostoVenta], [ImporteTotal]) VALUES (423, 157, CAST(0x0000A3450148EAD5 AS DateTime), 500, 1000)
INSERT [dbo].[Venta] ([Id_Venta], [Id_Cliente], [FechaVenta], [CostoVenta], [ImporteTotal]) VALUES (424, 158, CAST(0x0000A3450148FCF4 AS DateTime), 500, 1000)
INSERT [dbo].[Venta] ([Id_Venta], [Id_Cliente], [FechaVenta], [CostoVenta], [ImporteTotal]) VALUES (425, 157, CAST(0x0000A34501493B59 AS DateTime), 500, 1000)
SET IDENTITY_INSERT [dbo].[Venta] OFF
/****** Object:  Table [dbo].[Usuario]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Contrasenia] [varchar](50) NOT NULL,
	[Id_TipoUsuario] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON
INSERT [dbo].[Usuario] ([Id_Usuario], [Usuario], [Contrasenia], [Id_TipoUsuario]) VALUES (49, N'sempait', N'algoritmos', 1)
INSERT [dbo].[Usuario] ([Id_Usuario], [Usuario], [Contrasenia], [Id_TipoUsuario]) VALUES (51, N'operador', N'operador', 2)
INSERT [dbo].[Usuario] ([Id_Usuario], [Usuario], [Contrasenia], [Id_TipoUsuario]) VALUES (57, N'taty', N'adsadsa', 1)
INSERT [dbo].[Usuario] ([Id_Usuario], [Usuario], [Contrasenia], [Id_TipoUsuario]) VALUES (59, N'hola', N'hola', 1)
INSERT [dbo].[Usuario] ([Id_Usuario], [Usuario], [Contrasenia], [Id_TipoUsuario]) VALUES (60, N'a', N'a', 1)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
/****** Object:  StoredProcedure [dbo].[sp_ABMTipoArticulos]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ABMTipoArticulos] 

@Descripcion varchar(20), @Id_TipoArticulo int,@Estado char(1)


AS
	

		 
		
BEGIN

IF @Estado='A' 
BEGIN 

INSERT INTO TipoArticulo(Descripcion) VALUES (@Descripcion)


END

IF @Estado='M'
BEGIN

UPDATE TipoArticulo SET Descripcion=@Descripcion where Id_TipoArticulo=@Id_TipoArticulo

END



END


IF @Estado='B'
BEGIN
DELETE FROM TipoArticulo WHERE Id_TipoArticulo=@Id_TipoArticulo
END
GO
/****** Object:  Table [dbo].[Articulo]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Articulo](
	[Id_Articulo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](max) NOT NULL,
	[id_TipoArticulo] [int] NOT NULL,
	[Codigo] [varchar](50) NULL,
	[Stock] [int] NULL,
	[Id_Marca] [int] NULL,
	[Costo] [float] NULL,
	[Talle] [varchar](50) NULL,
 CONSTRAINT [PK_Articulo] PRIMARY KEY CLUSTERED 
(
	[Id_Articulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Articulo] ON
INSERT [dbo].[Articulo] ([Id_Articulo], [Descripcion], [id_TipoArticulo], [Codigo], [Stock], [Id_Marca], [Costo], [Talle]) VALUES (2646, N'vestido', 38, N'00000', 6, 20, 500, N'x')
INSERT [dbo].[Articulo] ([Id_Articulo], [Descripcion], [id_TipoArticulo], [Codigo], [Stock], [Id_Marca], [Costo], [Talle]) VALUES (2647, N'asdadsa', 38, N'00001', 0, 20, 200, N'M')
SET IDENTITY_INSERT [dbo].[Articulo] OFF
/****** Object:  UserDefinedFunction [dbo].[func_GetIDFormaPago]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_GetIDFormaPago] 
(
	@pDescripcionFormaPago varchar(50)
)
RETURNS int
AS
BEGIN

	DECLARE @idFormaPago int = (SELECT idFormaPago FROM FormaPago WHERE descripcionFormaPago = @pDescripcionFormaPago)

	RETURN @idFormaPago
	
END
GO
/****** Object:  Table [dbo].[Entrega]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Entrega](
	[Id_Entrega] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[Importe] [nchar](10) NOT NULL,
	[FechaEntrega] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Entrega] PRIMARY KEY CLUSTERED 
(
	[Id_Entrega] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PagoEfectuado]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PagoEfectuado](
	[Id_PagoCliente] [int] IDENTITY(1,1) NOT NULL,
	[Id_cliente] [int] NOT NULL,
	[Importe] [float] NOT NULL,
	[FechaPago] [datetime] NOT NULL,
 CONSTRAINT [PK_PagoEfectuado] PRIMARY KEY CLUSTERED 
(
	[Id_PagoCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PagoEfectuado] ON
INSERT [dbo].[PagoEfectuado] ([Id_PagoCliente], [Id_cliente], [Importe], [FechaPago]) VALUES (109, 157, 300, CAST(0x0000A30200000000 AS DateTime))
INSERT [dbo].[PagoEfectuado] ([Id_PagoCliente], [Id_cliente], [Importe], [FechaPago]) VALUES (110, 157, 2, CAST(0x0000A32F016E5DD8 AS DateTime))
SET IDENTITY_INSERT [dbo].[PagoEfectuado] OFF
/****** Object:  Table [dbo].[Precio]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Precio](
	[Id_Precio] [int] IDENTITY(1,1) NOT NULL,
	[FechaPrecio] [datetime] NOT NULL,
	[Precio] [float] NOT NULL,
	[Id_Articulo] [int] NOT NULL,
 CONSTRAINT [PK_Precio] PRIMARY KEY CLUSTERED 
(
	[Id_Precio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Precio] ON
INSERT [dbo].[Precio] ([Id_Precio], [FechaPrecio], [Precio], [Id_Articulo]) VALUES (3267, CAST(0x0000A32F012BC64B AS DateTime), 2, 2646)
INSERT [dbo].[Precio] ([Id_Precio], [FechaPrecio], [Precio], [Id_Articulo]) VALUES (3268, CAST(0x0000A32F017349AE AS DateTime), 1000, 2646)
INSERT [dbo].[Precio] ([Id_Precio], [FechaPrecio], [Precio], [Id_Articulo]) VALUES (3269, CAST(0x0000A32F018A9AAB AS DateTime), 200, 2647)
SET IDENTITY_INSERT [dbo].[Precio] OFF
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[id_Venta] [int] NOT NULL,
	[id_DetalleVenta] [int] IDENTITY(1,1) NOT NULL,
	[id_Articulo] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [float] NOT NULL,
 CONSTRAINT [PK_DetalleVenta] PRIMARY KEY CLUSTERED 
(
	[id_DetalleVenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DetalleVenta] ON
INSERT [dbo].[DetalleVenta] ([id_Venta], [id_DetalleVenta], [id_Articulo], [Cantidad], [Precio]) VALUES (408, 553, 2646, 1, 1000)
INSERT [dbo].[DetalleVenta] ([id_Venta], [id_DetalleVenta], [id_Articulo], [Cantidad], [Precio]) VALUES (409, 554, 2646, 1, 1000)
INSERT [dbo].[DetalleVenta] ([id_Venta], [id_DetalleVenta], [id_Articulo], [Cantidad], [Precio]) VALUES (410, 555, 2646, 1, 1000)
INSERT [dbo].[DetalleVenta] ([id_Venta], [id_DetalleVenta], [id_Articulo], [Cantidad], [Precio]) VALUES (411, 556, 2646, 1, 1000)
INSERT [dbo].[DetalleVenta] ([id_Venta], [id_DetalleVenta], [id_Articulo], [Cantidad], [Precio]) VALUES (411, 557, 2647, 1, 200)
INSERT [dbo].[DetalleVenta] ([id_Venta], [id_DetalleVenta], [id_Articulo], [Cantidad], [Precio]) VALUES (412, 558, 2646, 1, 1000)
INSERT [dbo].[DetalleVenta] ([id_Venta], [id_DetalleVenta], [id_Articulo], [Cantidad], [Precio]) VALUES (413, 559, 2646, 1, 1000)
INSERT [dbo].[DetalleVenta] ([id_Venta], [id_DetalleVenta], [id_Articulo], [Cantidad], [Precio]) VALUES (414, 560, 2647, 1, 200)
INSERT [dbo].[DetalleVenta] ([id_Venta], [id_DetalleVenta], [id_Articulo], [Cantidad], [Precio]) VALUES (415, 561, 2646, 1, 1000)
INSERT [dbo].[DetalleVenta] ([id_Venta], [id_DetalleVenta], [id_Articulo], [Cantidad], [Precio]) VALUES (416, 562, 2646, 1, 1000)
INSERT [dbo].[DetalleVenta] ([id_Venta], [id_DetalleVenta], [id_Articulo], [Cantidad], [Precio]) VALUES (417, 563, 2646, 2, 1000)
INSERT [dbo].[DetalleVenta] ([id_Venta], [id_DetalleVenta], [id_Articulo], [Cantidad], [Precio]) VALUES (417, 564, 2647, 1, 200)
INSERT [dbo].[DetalleVenta] ([id_Venta], [id_DetalleVenta], [id_Articulo], [Cantidad], [Precio]) VALUES (418, 565, 2646, 2, 1000)
INSERT [dbo].[DetalleVenta] ([id_Venta], [id_DetalleVenta], [id_Articulo], [Cantidad], [Precio]) VALUES (419, 566, 2646, 1, 1000)
INSERT [dbo].[DetalleVenta] ([id_Venta], [id_DetalleVenta], [id_Articulo], [Cantidad], [Precio]) VALUES (420, 567, 2646, 1, 1000)
INSERT [dbo].[DetalleVenta] ([id_Venta], [id_DetalleVenta], [id_Articulo], [Cantidad], [Precio]) VALUES (421, 568, 2646, 1, 1000)
INSERT [dbo].[DetalleVenta] ([id_Venta], [id_DetalleVenta], [id_Articulo], [Cantidad], [Precio]) VALUES (422, 569, 2646, 1, 1000)
INSERT [dbo].[DetalleVenta] ([id_Venta], [id_DetalleVenta], [id_Articulo], [Cantidad], [Precio]) VALUES (423, 570, 2646, 1, 1000)
INSERT [dbo].[DetalleVenta] ([id_Venta], [id_DetalleVenta], [id_Articulo], [Cantidad], [Precio]) VALUES (424, 571, 2646, 1, 1000)
INSERT [dbo].[DetalleVenta] ([id_Venta], [id_DetalleVenta], [id_Articulo], [Cantidad], [Precio]) VALUES (425, 572, 2646, 1, 1000)
SET IDENTITY_INSERT [dbo].[DetalleVenta] OFF
/****** Object:  Table [dbo].[VentaParcial]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VentaParcial](
	[Id_Articulo] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Id_TipoArticulo] [int] NOT NULL,
 CONSTRAINT [PK_VentaParcial] PRIMARY KEY CLUSTERED 
(
	[Id_Articulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VentaFormaPago]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentaFormaPago](
	[idFormaPago] [int] NOT NULL,
	[idVenta] [int] NOT NULL,
	[Importe] [decimal](10, 2) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (1, 412, CAST(800.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (1, 413, CAST(900.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (1, 414, CAST(180.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (1, 415, CAST(900.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (1, 416, CAST(800.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (1, 417, CAST(1680.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (1, 418, CAST(1800.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (4, 420, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (2, 420, CAST(500.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (1, 421, CAST(1000.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (2, 422, CAST(1000.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (1, 424, CAST(1000.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (4, 409, CAST(200.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (3, 409, CAST(100.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (1, 409, CAST(700.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (2, 410, CAST(1000.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (1, 425, CAST(1000.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (1, 408, CAST(1000.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (4, 411, CAST(1000.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (1, 411, CAST(200.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (1, 419, CAST(1000.00 AS Decimal(10, 2)))
INSERT [dbo].[VentaFormaPago] ([idFormaPago], [idVenta], [Importe]) VALUES (1, 423, CAST(1000.00 AS Decimal(10, 2)))
/****** Object:  StoredProcedure [dbo].[sp_DescontarStock]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[sp_DescontarStock] 

@Id_Articulo int,@Cantidad int


AS

		 
		
BEGIN
UPDATE Articulo SET Stock=(Stock-@Cantidad)
WHERE Id_Articulo=@Id_Articulo

END
GO
/****** Object:  StoredProcedure [dbo].[sp_ABMusuarios]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ABMusuarios] 

@Usuario varchar(20),@Contraseña varchar(20),
@Privilegio int,@Estado char(1),@Id_Usu int


AS

	
BEGIN

DECLARE @Result bit


IF @Estado='A' 
BEGIN 

INSERT INTO USUARIO(Usuario,Contrasenia,Id_TipoUsuario) VALUES (@Usuario,@Contraseña,@Privilegio)

END

IF @Estado='M'
BEGIN
UPDATE USUARIO SET Usuario=@Usuario,Contrasenia=@Contraseña,Id_TipoUsuario=@Privilegio where Id_Usuario=@Id_Usu
END


IF @Estado='B'

BEGIN
DELETE FROM USUARIO WHERE Id_usuario=@Id_Usu
END


IF @Estado='V'
BEGIN
DECLARE @Pass varchar(50)
SET @Pass =(SELECT Contrasenia FROM Usuario WHERE Usuario=@Usuario)
IF @Pass=@Contraseña
BEGIN
SET @Result=1
SELECT @Result
END
ELSE
SET @Result=0
SELECT @Result 
END

END
GO
/****** Object:  StoredProcedure [dbo].[sp_ABMPagosEfectuados]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ABMPagosEfectuados] 

@Id_Cliente int,@FechaPago Datetime,@Monto float,@Estado char(1),@Id_Pago int


AS
	

		 
		
BEGIN

IF @Estado='A' 
BEGIN 

INSERT INTO PagoEfectuado(Id_Cliente,Importe,FechaPago) Values (@Id_Cliente,@Monto,@FechaPago)

UPDATE Cliente SET Importe=(Importe-@Monto)WHERE id_cliente=@Id_Cliente

END

IF @Estado='M'
BEGIN

Update PagoEfectuado SET Importe=@Monto,FechaPago=@FechaPago WHERE Id_pagoCliente=@Id_pago

END


IF @Estado='B'
BEGIN
DELETE FROM PagoEfectuado WHERE Id_PagoCliente=@Id_Pago

UPDATE Cliente SET Importe=(Importe + @Monto) WHERE id_cliente=@Id_Cliente
END


END
GO
/****** Object:  StoredProcedure [dbo].[sp_ActualizarStock]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ActualizarStock] 

@Id_Articulo int,@Cantidad int,@Estado char(1)


AS

		 
		
BEGIN
IF @Estado='A'
BEGIN
UPDATE Articulo SET Stock=(Stock-@Cantidad)
WHERE Id_Articulo=@Id_Articulo
END
IF @Estado='B'
BEGIN
UPDATE Articulo SET Stock=(Stock+@Cantidad)
WHERE Id_Articulo=@Id_ArticulO
END


IF @Estado='M'
BEGIN
UPDATE Articulo SET Stock=(Stock-@Cantidad)
WHERE Id_Articulo=@Id_Articulo
END


END
GO
/****** Object:  View [dbo].[ViPagosPorDia]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViPagosPorDia]
AS
SELECT     CONVERT(VARCHAR, FechaPago, 103) AS Fecha, ISNULL(SUM(Importe), 0) AS TotalPagos
FROM         dbo.PagoEfectuado
GROUP BY CONVERT(VARCHAR, FechaPago, 103)
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "PagoEfectuado"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 216
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViPagosPorDia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViPagosPorDia'
GO
/****** Object:  View [dbo].[ViVentasPorDia]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViVentasPorDia]
AS
SELECT     CONVERT(VARCHAR, FechaVenta, 103) AS Fecha, ISNULL(SUM(ImporteTotal), 0) AS Total
FROM         dbo.Venta
WHERE     (FormaPago = 'Efectivo')
GROUP BY CONVERT(VARCHAR, FechaVenta, 103)
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Venta"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 214
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViVentasPorDia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViVentasPorDia'
GO
/****** Object:  View [dbo].[ViResultadoCajaDiaria]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViResultadoCajaDiaria]
AS
SELECT     TOP (100) PERCENT dbo.ViCajaDiaria.Fecha, SUM(dbo.ViCajaDiaria.TotalIngreso) AS Ingresos, SUM(dbo.ViCajaDiaria.TotalEgreso) AS Egresos, 
                      SUM(dbo.ViPagosPorDia.TotalPagos) AS Pagos, SUM(dbo.ViGastosPorDia.Total) AS Gastos, ISNULL(SUM(dbo.ViVentasPorDia.Total), 0) AS Ventas, 
                      ISNULL(SUM(dbo.ViCajaDiaria.TotalIngreso), 0) + ISNULL(SUM(dbo.ViPagosPorDia.TotalPagos), 0) + ISNULL(SUM(dbo.ViVentasPorDia.Total), 0) 
                      + ISNULL(SUM(dbo.ViCajaDiaria.CajaInicial), 0) - ISNULL(SUM(dbo.ViCajaDiaria.TotalEgreso), 0) - ISNULL(SUM(dbo.ViGastosPorDia.Total), 0) AS Resultado, 
                      SUM(dbo.ViCajaDiaria.CajaInicial) AS CajaInicial
FROM         dbo.ViCajaDiaria LEFT OUTER JOIN
                      dbo.ViPagosPorDia ON CONVERT(VARCHAR, dbo.ViCajaDiaria.Fecha, 103) = dbo.ViPagosPorDia.Fecha LEFT OUTER JOIN
                      dbo.ViVentasPorDia ON CONVERT(VARCHAR, dbo.ViCajaDiaria.Fecha, 103) = dbo.ViVentasPorDia.Fecha LEFT OUTER JOIN
                      dbo.ViGastosPorDia ON CONVERT(VARCHAR, dbo.ViCajaDiaria.Fecha, 103) = dbo.ViGastosPorDia.Fecha
GROUP BY dbo.ViCajaDiaria.Fecha
ORDER BY dbo.ViCajaDiaria.Fecha
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[28] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ViCajaDiaria"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 110
               Right = 594
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ViPagosPorDia"
            Begin Extent = 
               Top = 0
               Left = 236
               Bottom = 95
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ViVentasPorDia"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 95
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ViGastosPorDia"
            Begin Extent = 
               Top = 6
               Left = 632
               Bottom = 95
               Right = 808
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViResultadoCajaDiaria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViResultadoCajaDiaria'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViResultadoCajaDiaria'
GO
/****** Object:  View [dbo].[ViArticulos]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViArticulos]
AS
SELECT     dbo.Articulo.Id_Articulo, dbo.Articulo.Descripcion, dbo.Precio.Precio, dbo.TipoArticulo.Descripcion AS TipoArticulo, dbo.TipoArticulo.Id_TipoArticulo, dbo.Articulo.Stock, 
                      dbo.Articulo.Codigo
FROM         dbo.Articulo INNER JOIN
                      dbo.Precio ON dbo.Articulo.Id_Articulo = dbo.Precio.Id_Articulo INNER JOIN
                      dbo.TipoArticulo ON dbo.Articulo.id_TipoArticulo = dbo.TipoArticulo.Id_TipoArticulo AND dbo.Precio.FechaPrecio =
                          (SELECT     MAX(FechaPrecio) AS Expr1
                            FROM          dbo.Precio AS P
                            WHERE      (Id_Articulo = dbo.Articulo.Id_Articulo)) AND dbo.Articulo.Id_Articulo NOT IN
                          (SELECT     Id_Articulo
                            FROM          dbo.VentaParcial)
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Articulo"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 110
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Precio"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 125
               Right = 396
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TipoArticulo"
            Begin Extent = 
               Top = 6
               Left = 434
               Bottom = 95
               Right = 595
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViArticulos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViArticulos'
GO
/****** Object:  StoredProcedure [dbo].[sp_ABMItemVenta]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ABMItemVenta] 

@Id_Articulo int,@Cantidad int,@Precio float,@Estado char(1)


AS
DECLARE

@Id_Cliente int,
@FechaVenta datetime,
@FormaPago varchar,
@id_Venta int

	


		 
		
BEGIN





IF @Estado='A' 
BEGIN 

SET @id_Venta =(SELECT MAX(id_Venta) FROM Venta)

INSERT INTO DetalleVenta(id_Venta,id_Articulo,Cantidad,Precio) VALUES(@id_Venta,@Id_Articulo,@Cantidad,@Precio)
END


END
GO
/****** Object:  StoredProcedure [dbo].[sp_ABMArticulos]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ABMArticulos] 

@Descripcion varchar(50),@Id_Articulo int,@Precio float, @Id_TipoArticulo int,@Estado varchar(1),@Codigo varchar(5),@Stock int,@Marca int,@Costo float,@Talle Varchar(2)


AS
	
DECLARE
		@PrecioActual Float,
		@Result bit
		
BEGIN

IF @Estado='A' 
BEGIN 

INSERT INTO Articulo(Descripcion,Id_TipoArticulo,Codigo,Stock,Id_Marca,Costo,Talle) VALUES (@Descripcion,@Id_TipoArticulo,@Codigo,@Stock,@Marca,@Costo,@Talle)

declare cursorarticulos cursor for
SELECT MAX(Id_articulo)
FROM Articulo


open cursorarticulos
fetch cursorarticulos INTO @Id_Articulo

close cursorarticulos
deallocate cursorarticulos

INSERT INTO Precio(FechaPrecio,Precio,Id_Articulo) VALUES(GETDATE(),@Precio,@Id_Articulo)

END

IF @Estado='M'
BEGIN

declare cursorprecio cursor for
SELECT PRECIO from Precio
WHERE ID_ARTICULO=@Id_Articulo AND 
FECHAPRECIO = 
(SELECT MAX(FECHAPRECIO)FROM PRECIO
WHERE ID_ARTICULO=@Id_Articulo)

open cursorprecio
fetch cursorprecio into @PrecioActual

close cursorprecio
deallocate cursorprecio

IF @Precio=@PrecioActual
BEGIN
UPDATE Articulo SET Descripcion=@Descripcion,Id_TipoArticulo=@Id_TipoArticulo,Stock=@Stock,Codigo=@Codigo,Costo=@Costo,Talle=@Talle where Id_Articulo=@Id_Articulo
END

ELSE
INSERT INTO Precio(FechaPrecio,Precio,Id_Articulo) VALUES(GETDATE(),@Precio,@Id_Articulo)

UPDATE Articulo SET Descripcion=@Descripcion,Id_TipoArticulo=@Id_TipoArticulo,Id_Marca=@Marca where Id_Articulo=@Id_Articulo
END






IF @Estado='B'
BEGIN
DELETE FROM Articulo WHERE Id_Articulo=@Id_Articulo
END


END
GO
/****** Object:  StoredProcedure [dbo].[sp_VentaFormaPago_Insert]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_VentaFormaPago_Insert]
	@pIDVenta int,
	@pEfectivo decimal(10,2),
	@pCheque decimal(10,2),
	@pTarjeta decimal(10,2),
	@pCuentaCorriente decimal(10,2)
AS
BEGIN

	IF(@pEfectivo ! = 0)
		INSERT INTO VentaFormaPago
		(
			idVenta,
			idFormaPago,
			Importe
		)
		VALUES
		(
			@pIDVenta,
			dbo.func_GetIDFormaPago ('Efectivo'),
			@pEfectivo
		)
		
	IF(@pCheque! = 0)
		INSERT INTO VentaFormaPago
		(
			idVenta,
			idFormaPago,
			Importe
		)
		VALUES
		(
			@pIDVenta,
			dbo.func_GetIDFormaPago ('Cheque'),
			@pCheque
		)
		
	IF(@pTarjeta ! = 0)
		INSERT INTO VentaFormaPago
		(
			idVenta,
			idFormaPago,
			Importe
		)
		VALUES
		(
			@pIDVenta,
			dbo.func_GetIDFormaPago ('Tarjeta'),
			@pTarjeta
		)
		
	IF(@pCuentaCorriente ! = 0)
		INSERT INTO VentaFormaPago
		(
			idVenta,
			idFormaPago,
			Importe
		)
		VALUES
		(
			@pIDVenta,
			dbo.func_GetIDFormaPago ('Cuenta Corriente'),
			@pCuentaCorriente
		)

END
GO
/****** Object:  StoredProcedure [dbo].[sp_IECajaDiaria]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_IECajaDiaria] 

@Descripcion varchar(50),@Ingreso float,
@Egreso float,@FechaOperacion datetime,@FechaPos datetime,@Estado varchar,@CajaInicial float


AS
DECLARE

@CajaInicialPos Float

SET @CajaInicialPos = 0
	
BEGIN

IF @Estado='I'
BEGIN
INSERT INTO CajaDiaria(Ingreso,FechaOperacion,DescripcionOperacion,CajaInicial)VALUES(@Ingreso,@FechaOperacion,@Descripcion,@CajaInicial)
END


IF @Estado='E'
BEGIN
INSERT INTO CajaDiaria(Egreso,FechaOperacion,DescripcionOperacion,CajaInicial)VALUES(@Egreso,@FechaOperacion,@Descripcion,@CajaInicial)
END




IF @Estado='C'
BEGIN


--Consigo el valor de el resultado de la caja del dia anterior
declare SaldoCaja cursor for
SELECT Resultado
FROM ViResultadoCajaDiaria
WHERE CONVERT(VARCHAR,Fecha,103)=CONVERT(VARCHAR,@FechaOperacion,103)

open SaldoCaja
fetch SaldoCaja INTO @CajaInicial

close SaldoCaja
deallocate SaldoCaja

--Verifico si la caja inicial del dia posterior esta en 0, si es asi hago un INSERT sino un UPDATE

declare CajaInicial cursor for
SELECT CajaInicial
FROM CajaDiaria
WHERE CONVERT(VARCHAR,FechaOperacion,103)=CONVERT(VARCHAR,@FechaPos,103)

open CajaInicial
fetch CajaInicial INTO @CajaInicialPos

close CajaInicial
deallocate CajaInicial

IF (@CajaInicialPos=0)
BEGIN
INSERT INTO CajaDiaria(FechaOperacion,DescripcionOperacion,CajaInicial)VALUES(@FechaPos,@Descripcion,@CajaInicial)
END
ELSE
BEGIN
UPDATE CajaDiaria SET CajaInicial=@CajaInicial
WHERE CONVERT(VARCHAR,FechaOperacion,103)=CONVERT(VARCHAR,@FechaPos,103)
END
END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ABMVentas]    Script Date: 06/09/2014 22:34:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ABMVentas] 

@Id_Cliente int,
@FechaVenta datetime,
@Estado char(1),
@Id_Venta int,
@ImporteTotal float,
@CostoVenta float,
@Efectivo decimal(10,2),
@Cheque decimal (10,2),
@Tarjeta decimal (10,2),
@CuentaCorriente decimal (10,2)

AS
DECLARE

@ID_ArticuloDevuelto int,
@CantidadDevuelta int


BEGIN

IF @Estado='A' 
BEGIN 
INSERT INTO Venta(Id_Cliente,FechaVenta) VALUES (@Id_Cliente,@FechaVenta)
EXECUTE dbo.sp_VentaFormaPago_Insert @@IDENTITY, @Efectivo, @Cheque, @Tarjeta, @CuentaCorriente
END



IF @Estado='B'
BEGIN

--Devuelvo el Stock de la venta al articulo/s en cuestion

declare cursorItemVenta cursor for
SELECT Id_Articulo,Cantidad FROM DetalleVenta
WHERE Id_Venta=@Id_Venta

open cursorItemVenta
FETCH cursorItemVenta INTO @Id_ArticuloDevuelto,@CantidadDevuelta

WHILE @@FETCH_STATUS=0
BEGIN
UPDATE Articulo SET Stock=Stock+@CantidadDevuelta
WHERE Id_Articulo=@Id_ArticuloDevuelto


FETCH NEXT FROM cursorItemVenta INTO @Id_ArticuloDevuelto,@CantidadDevuelta
END



--Borro la venta
DELETE FROM Venta WHERE Id_Venta=@Id_Venta

--Resto el saldo de dicha venta a la cuenta corriente del cliente en cuestion si es que la venta era por ctacte
IF (EXISTS (SELECT * FROM VentaFormaPago WHERE idVenta = @Id_Venta AND idFormaPago = 'Cuenta Corriente'))
BEGIN
DECLARE @montoCuentaCorriente int = (SELECT importe FROM VentaFormaPago WHERE idVenta = @Id_Venta AND idFormaPago = 'Cuenta Corriente')
UPDATE Cliente SET Importe=(Importe-@montoCuentaCorriente) WHERE Id_Cliente=@Id_Cliente
END
END

IF @Estado='C'
BEGIN
SET @Id_Venta =(SELECT MAX(id_Venta) FROM Venta)
		
UPDATE VENTA SET ImporteTotal=@ImporteTotal,CostoVenta=@CostoVenta WHERE Id_Venta=@Id_Venta


IF @CuentaCorriente > 0
BEGIN
UPDATE CLIENTE SET Importe=Importe+@CuentaCorriente Where Id_cliente=@Id_Cliente
END

END

END
GO
/****** Object:  ForeignKey [FK_Venta_Cliente]    Script Date: 06/09/2014 22:34:31 ******/
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Cliente] ([Id_cliente])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cliente]
GO
/****** Object:  ForeignKey [FK_Usuario_Usuario]    Script Date: 06/09/2014 22:34:31 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Usuario] FOREIGN KEY([Id_TipoUsuario])
REFERENCES [dbo].[TipoUsuario] ([Id_TipoUsuario])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Usuario]
GO
/****** Object:  ForeignKey [FK_Articulo_TipoArticulo]    Script Date: 06/09/2014 22:34:31 ******/
ALTER TABLE [dbo].[Articulo]  WITH CHECK ADD  CONSTRAINT [FK_Articulo_TipoArticulo] FOREIGN KEY([Id_Marca])
REFERENCES [dbo].[Marca] ([Id_Marca])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Articulo] CHECK CONSTRAINT [FK_Articulo_TipoArticulo]
GO
/****** Object:  ForeignKey [FK_Entrega_Cliente]    Script Date: 06/09/2014 22:34:31 ******/
ALTER TABLE [dbo].[Entrega]  WITH CHECK ADD  CONSTRAINT [FK_Entrega_Cliente] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Cliente] ([Id_cliente])
GO
ALTER TABLE [dbo].[Entrega] CHECK CONSTRAINT [FK_Entrega_Cliente]
GO
/****** Object:  ForeignKey [FK_PagoEfectuado_PagoEfectuado]    Script Date: 06/09/2014 22:34:31 ******/
ALTER TABLE [dbo].[PagoEfectuado]  WITH CHECK ADD  CONSTRAINT [FK_PagoEfectuado_PagoEfectuado] FOREIGN KEY([Id_cliente])
REFERENCES [dbo].[Cliente] ([Id_cliente])
GO
ALTER TABLE [dbo].[PagoEfectuado] CHECK CONSTRAINT [FK_PagoEfectuado_PagoEfectuado]
GO
/****** Object:  ForeignKey [FK_Precio_Articulo]    Script Date: 06/09/2014 22:34:31 ******/
ALTER TABLE [dbo].[Precio]  WITH CHECK ADD  CONSTRAINT [FK_Precio_Articulo] FOREIGN KEY([Id_Articulo])
REFERENCES [dbo].[Articulo] ([Id_Articulo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Precio] CHECK CONSTRAINT [FK_Precio_Articulo]
GO
/****** Object:  ForeignKey [FK_DetalleVenta_Venta]    Script Date: 06/09/2014 22:34:31 ******/
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Venta] FOREIGN KEY([id_Venta])
REFERENCES [dbo].[Venta] ([Id_Venta])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_Venta]
GO
/****** Object:  ForeignKey [FK_VentaParcial_VentaParcial]    Script Date: 06/09/2014 22:34:31 ******/
ALTER TABLE [dbo].[VentaParcial]  WITH CHECK ADD  CONSTRAINT [FK_VentaParcial_VentaParcial] FOREIGN KEY([Id_Articulo])
REFERENCES [dbo].[Articulo] ([Id_Articulo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VentaParcial] CHECK CONSTRAINT [FK_VentaParcial_VentaParcial]
GO
/****** Object:  ForeignKey [FK_VentaFormaPago_FormaPago]    Script Date: 06/09/2014 22:34:31 ******/
ALTER TABLE [dbo].[VentaFormaPago]  WITH CHECK ADD  CONSTRAINT [FK_VentaFormaPago_FormaPago] FOREIGN KEY([idFormaPago])
REFERENCES [dbo].[FormaPago] ([idFormaPago])
GO
ALTER TABLE [dbo].[VentaFormaPago] CHECK CONSTRAINT [FK_VentaFormaPago_FormaPago]
GO
/****** Object:  ForeignKey [FK_VentaFormaPago_Venta]    Script Date: 06/09/2014 22:34:31 ******/
ALTER TABLE [dbo].[VentaFormaPago]  WITH CHECK ADD  CONSTRAINT [FK_VentaFormaPago_Venta] FOREIGN KEY([idVenta])
REFERENCES [dbo].[Venta] ([Id_Venta])
GO
ALTER TABLE [dbo].[VentaFormaPago] CHECK CONSTRAINT [FK_VentaFormaPago_Venta]
GO
